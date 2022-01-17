using System.Linq;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models.Database;

namespace ToDoList.Controllers
{
    public class LoginController : Controller
    {
        private ToDoContext _context {get; }
        public LoginController(ToDoContext context)
        {
            _context = context;
        }
        // public User UserInDB()
        // {
        //     return _context.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
        // }
        [HttpGet("")]

        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("Register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(_context.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                
                    // You may consider returning to the View at this point
                    return Index();
                }
                // Initializing a PasswordHasher object, providing our User class as its type
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                //Save your user object to the database
                _context.Add(user);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.UserId);

                return RedirectToAction("Dashboard", "ToDo");
            }
            else
            {
                return Index();
            }
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                User userInDb = _context.Users.FirstOrDefault(u => u.Email == userSubmission.LoginEmail);
                // If no user exists with provided email
                if(userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");

                    return Index();
                }
                    // Initialize hasher object
                    PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                
                    // verify provided password against hash stored in db
                    var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.LoginPassword);
                
                    // result can be compared to 0 for failure
                    if(result == 0)
                    {
                        // handle failure (this should be similar to how "existing email" is handled)
                        ModelState.AddModelError("LoginEmail", "Invalid Email/Password");

                        return Index();
                    }
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return RedirectToAction("Dashboard", "ToDo");
                }
                else
                {
                    return Index();
                }
        }
        [HttpGet("logout")]
        public RedirectToActionResult LogOut()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
    }
}