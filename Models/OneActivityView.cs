using ToDoList.Models.Database;

namespace ToDoList.Models
{
    public class OneActivityView
{
        public int? LoggedInUser {get; set; }
        public Activity ScheduledActivity {get; set; }
    }
}