using System;
using System.ComponentModel.DataAnnotations;

namespace CrmUpSchool.UILayer.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage="Please enter your username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your surname.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string Phonenumber { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "Please enter your password again.")]
        //public string Surname { get; set; }
    }
}
