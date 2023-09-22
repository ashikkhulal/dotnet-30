using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;

namespace day_26_lesson.Models
{
    public class EmployeeDetailsEntities
    {

        public int ID { get; set; }
		public string FullName { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string AptOrSuite { get; set; }
		public string PostalZip { get; set; }
		public string Country { get; set; }
		public bool OnVacation { get; set; }

    }
}