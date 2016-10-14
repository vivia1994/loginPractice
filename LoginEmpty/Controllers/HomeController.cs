using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginEmpty.Models;

namespace LoginEmpty.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Login
        public ActionResult Login(string username, string password)
        {
            Session.RemoveAll();
            DatabaseContext userDbContext = new DatabaseContext();
            DbSqlQuery<User> result = userDbContext.Users.SqlQuery("Select * from Users where username = @p0", username);
            if(!result.Any())
                return Redirect("Index");
            if(result.First().Password != password)
                return Redirect("Index");
            Session.Add("userInfo", result.First());
            return Redirect("Info");
        }

        // GET: Home
        public ActionResult Info()
        {
            User user = (User) Session["userInfo"];
            ViewBag.UserInfo = user;
            return View();
        }
    }
}