using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Models.Database;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    [Route("ToDo")]
    public class ToDoController : Controller
    {
        private ToDoContext _context {get;}
        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        [HttpGet("Home")]
        public IActionResult Dashboard()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index", "Login");
            }
            foreach(Activity thisAct in _context.Activities)
            {
                if(DateTime.Compare(DateTime.Now, thisAct.Date) > 0)
                {
                    _context.Activities.Remove(thisAct);
                }
            }
            _context.SaveChanges();
            DashboardView ViewModel = new DashboardView
            {
                LoggedInUser = (int)UserId,
                UserName = _context.Users.FirstOrDefault(u => u.UserId == (int)UserId).FirstName,
                AllActivities = _context.Activities
                    .Include(w => w.PeopleAttending)
                        .ThenInclude(u => u.RSVPedBy)
                    .Include(a => a.HostedBy)
                    .ToList()
            };

            return View(ViewModel);
        }
        
        [HttpGet("New")]
        public IActionResult NewActivity()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View("NewActivity");
        }

        [HttpPost("create")]
        public IActionResult CreateActivity(Activity fromForm)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index", "Login");
            }
            if(ModelState.IsValid)
            {
                fromForm.UserId = (int)UserId;
                _context.Add(fromForm);
                _context.SaveChanges();

                return RedirectToAction("Dashboard");
            }
            else
            {
                return NewActivity();
            }
        }

        [HttpGet("{ActivityId}")]
        public IActionResult ViewActivity(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index", "Login");
            }
            
            OneActivityView ViewModel = new OneActivityView
            {
                LoggedInUser = (int)UserId,
                ScheduledActivity = _context.Activities
                                        .Include(r => r.PeopleAttending)
                                            .ThenInclude(r => r.RSVPedBy)
                                        .Include(a => a.HostedBy)
                                        .FirstOrDefault(w => w.ActivityId == ActivityId)
            };
            if(ViewModel == null){
                return RedirectToAction("Dashboard");
            }
            return View("ActivityInfo", ViewModel);
        }

        [HttpGet("RSVP/{ActivityId}")]
        public IActionResult RSVPToActivity(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index", "Login");
            }
            RSVP Attendee = _context.RSVPs
                    .Where(w => w.ActivityId == ActivityId)
                    .FirstOrDefault(u => u.UserId == UserId);
            if(Attendee == null)
            {
                _context.RSVPs.Add(new RSVP{
                    ActivityId = ActivityId,
                    UserId = (int)UserId
                });
            }
            else
            {
                _context.RSVPs.Remove(Attendee);
            }
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("{ActivityId}/delete")]
        public IActionResult Delete(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index", "Login");
            }
            Activity activity = _context.Activities
                                .FirstOrDefault(w => w.ActivityId == ActivityId);
            _context.Activities.Remove(activity);
            _context.SaveChanges();

            return RedirectToAction("Dashboard");
        }

    }
}