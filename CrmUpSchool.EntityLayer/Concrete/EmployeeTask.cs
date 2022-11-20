using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.EntityLayer.Concrete
{
    public class EmployeeTask
    {
        [Key]
        public int EmployeeTaskID { get; set; }
        
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } 
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public List<EmployeeTaskDetail> EmployeeTaskDetails { get; set; }

    }
}
