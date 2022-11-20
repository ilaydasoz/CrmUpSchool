using System;
using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerMail { get; set; }

    }
}
