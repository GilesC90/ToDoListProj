using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ToDoList.Extensions.Validations;

namespace ToDoList.Models.Database
{
    public class Activity
{
        [Key]
        public int ActivityId {get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [Display(Name = "Name: ")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Name may only contain letters and spaces.")]
        public string Name {get; set; }

        [DateValidator]
        [Display(Name = "Date and Time: ")]
        public DateTime Date {get; set; }

        [Required(ErrorMessage = "Please provide a duration for this activity.")]
        [Display(Name = "Duration: ")]
        [Range(0,120, ErrorMessage = "Because quantum physics")]
        public int Duration {get; set; }
        public string DurationString {get; set; }

        [Required(ErrorMessage = "Please provide a descripton for this activity.")]
        [Display(Name = "Description: ")]
        public string Description {get; set; }

        // Foreign Key setup for the User 
        public int? UserId {get; set; }
        public User HostedBy {get; set; }

        public List<RSVP> PeopleAttending {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
    }
}