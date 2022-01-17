using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models.Database
{
        public class LoginUser
    {
        [Required(ErrorMessage = "Please enter your email.")]
        [Display(Name = "Email: ")]
        public string LoginEmail {get; set;}
        [Required(ErrorMessage = "You must enter a password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string LoginPassword {get; set;}
    }
}