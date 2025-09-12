using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEcommerceAdmin.Models;

namespace MyEcommerceAdmin.Controllers
{
    // ProfileController.cs - KEEP USING TemData:

    public class ProfileController : Controller
    {
        MyEcommerceDbContext db = new MyEcommerceDbContext();

        // GET: Profile
        public ActionResult Index()
        {
            // Check if admin is logged in using TemData
            if (TemData.EmpID == 0)
            {
                return RedirectToAction("Index", "admin_Login");
            }

            return View(db.admin_Employee.Find(TemData.EmpID));
        }
    }
}