using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;
using Vidly.DAL;
using System.Data.Entity;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        private DatabaseContext _db = new DatabaseContext();
        public CustomersController()
        {
            _db = new DatabaseContext();
        }

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }

        public ViewResult Index()
        {
            return View(_db.Customers.Include(c => c.Membership).ToList());
        }

        public ActionResult Details(int id)
        {
            var customer = _db.Customers.Include(c => c.Membership).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var ViewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _db.Memberships.ToList()
                };
                return View("CustomerForm", ViewModel);
            }

            if (customer.Id == 0)
               _db.Customers.Add(customer);
            else
            {
                var customerInDb = _db.Customers.SingleOrDefault(c => c.Id == customer.Id);

                customerInDb.Name = customer.Name;
                customerInDb.Birthday = customer.Birthday;
                customerInDb.MembershipId = customer.MembershipId;
                customerInDb.isSubscribed = customer.isSubscribed;
                //TryUpdateModel(customerInDb);
            }
            _db.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _db.Customers.SingleOrDefault(m => m.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _db.Memberships.ToList()
            };

            return View("CustomerForm", viewModel);
        }

        public ActionResult New()
        {
            var membershipTypes = _db.Memberships.ToList();
            var view = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View("CustomerForm", view);
        }

        public IEnumerable<Customer> getCustomers()
        {
            return _db.Customers.ToList();
        }

        public IEnumerable<Membership> getMemberships()
        {
            return _db.Memberships.ToList();
        }

    }
}