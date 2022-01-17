using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models.Database
{
    public class RSVP
    {
        [Key]
        public int RsvpId {get; set; }
        public int UserId {get; set; }
        public User RSVPedBy {get; set; }
        public int ActivityId {get; set; }
        public Activity ActivityRSVPed {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;

    }
}