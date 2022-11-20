using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeMail { get; set; }
        public string EmployeeImage { get; set; }
        public int CategoryID { get; set; } // relation with Category table
        public Category Category { get; set; }
        public bool EmployeeStatus { get; set; }
        public List<EmployeeTask> EmployeeTasks { get; set; }

    }
}
