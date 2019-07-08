using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<Membership> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}