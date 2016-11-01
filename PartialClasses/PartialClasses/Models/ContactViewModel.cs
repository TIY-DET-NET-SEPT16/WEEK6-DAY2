using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PartialClasses.Models
{
    public class ContactViewModel
    {
        [DisplayName("Customer")]
        public string CustomerToContact { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayName("Movie Name")]
        public Movy MovieOverdue { get; set; }
    }
}