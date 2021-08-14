using Maintainance.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using  Maintainance.Helpers.presidence;

namespace Maintainance.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;
        private ApplicationRoleManager _rolemanager;

        public AdminController(ApplicationRoleManager roleManger)
        {
            RoleManager = roleManger;
        }


        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _rolemanager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _rolemanager = value;
            }
        }



        public AdminController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Admin//a    dmin@yahoo.com Admin@123
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult RegisterUser()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var data = RoleManager.Roles.Select(c=>c.Name).ToList();
            foreach (var role in RoleManager.Roles)
            {
                list.Add(new SelectListItem() { Value = role.Name, Text = role.Name });
            }
            ViewBag.Roles = list;
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult ContactInfo()
        {
            var contact = _context.contacts.ToList();
            if (contact.Count==0)
            {
                Contacts contacts = new Contacts();
                contacts.Email = "Email@gmail.com";
                contacts.PhonNumber = "011xxxxxxxx";
                return View(contacts);
            }
                 var returend = contact.LastOrDefault();
                return View(returend);
        }

        public ActionResult Users()
        {
            var allusers = _context.Users.ToList();
            var roles = _context.Roles.ToList();
            var userrole = roles.Select(x => x.Users).ToArray();
            List<userroles> userroles=new List<userroles>(){ };
           
            var user = userrole[0].ToArray();
            for (int i = 0; i < user.Count(); i++)
            {
                userroles.Add(
                    new userroles
                    {
                        UserId = user[i].UserId.ToString(),
                        RoleId = user[i].RoleId.ToString()
                    });
            }

           IEnumerable< UserWRoles> userWRoles= from au in allusers
                        join ur in userroles
                        on au.Id equals ur.UserId into UserswRolesID
                        from UWRID in UserswRolesID.ToList()
                        join r in roles on UWRID.RoleId equals r.Id into UserWRoles
                        from uwr in UserWRoles
                        select new UserWRoles
                        {
                           UserId=au.Id,
                           RoleId=uwr.Id,
                           Username=au.UserName,
                           Email=au.Email,
                           Role=uwr.Name
                       };
            return View(userWRoles);

        }
        }
    }

