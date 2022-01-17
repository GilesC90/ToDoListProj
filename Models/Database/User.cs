using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ToDoList.Models.Database;

namespace ToDoList.Models.Database
{
    public class User
    {
        [Key]
        public int UserId {get; set;}

        [Required(ErrorMessage = "Please provide a first name")]
        [Display(Name = "First Name: ")]
        [MinLength(3, ErrorMessage = "Please provide a first name with at least 3 characters")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Names may only contain letters and spaces.")]
        public string FirstName {get; set;}

        [Required(ErrorMessage = "Please provide a last name")]
        [Display(Name = "Last Name: ")]
        [MinLength(3, ErrorMessage = "Please provide a last name with at least 3 characters")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Names may only contain letters and spaces.")]
        public string LastName {get; set;}

        [Required(ErrorMessage = "Please provide an email")]
        [Display(Name = "Email: ")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please provide a valid email address.")]
        [MinLength(8, ErrorMessage = "Please provide an email with at least 8 characters")]
        public string Email {get; set;}
        
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Please provide a password")]
        [MinLength(8, ErrorMessage = "Please provide a password with at least 8 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "Password MUST contain at least 1 Uppercase Letter, 1 Lowercase Letter, 1 Number, and 1 Special Character.")]
        public string Password {get; set;}

        [NotMapped]
        [Display(Name = "Confirm Password: ")]
        [Compare("Password", ErrorMessage = "Your passwords do not match.")]
        [DataType(DataType.Password)]
        public string Confirm {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        public List<Activity> ActivityToDo {get; set;}
        public List<RSVP> ActivityJoining {get; set;}
    }
}