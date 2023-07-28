using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABCShippingCo.Models
{
    public class ShippingInfo
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AptOrSuite { get; set; }
        public string PostalZip { get; set; }
        public string Country { get; set; }

    }
}