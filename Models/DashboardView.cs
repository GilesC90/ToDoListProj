using System.Collections.Generic;
using ToDoList.Models.Database;

namespace ToDoList.Models
{
    public class DashboardView
    {
        public string UserName {get; set; }
        public int LoggedInUser {get; set; }
        public User HostedBy {get; set; }
        public List<Activity> AllActivities {get; set; }
        public RSVP status {get; set; }
    }
}