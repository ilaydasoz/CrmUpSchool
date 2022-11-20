using System;
using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.UILayer.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage= "Please fill out the role name.")]
        public string RoleName { get; set; }
    }
}
