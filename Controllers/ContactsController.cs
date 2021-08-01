using Maintainance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Maintainance.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Contacts
        public ActionResult Index()
        {
            var data = _context.contacts.ToList();
            return View(data);
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        [HttpPost]
        public ActionResult Create(Contacts contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.contacts.Add(contact);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View("Create", contact);
            }
            catch
            {
                return View();
            }
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int id)
        {
            var contact = getcontact(id);
            if (contact == null)
                return HttpNotFound();
            return View(contact);
        }

        // POST: Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Contacts contacts)
        {
            try
            {
                if (ModelState.IsValid) { 
                var contact = getcontact(id);
                    if (contact == null)
                        return HttpNotFound();
                    else
                    {
                        contact = contacts;
                        _context.SaveChanges();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
       
        // GET: Contacts/Delete/5
        public ActionResult Delete(int id)
        {
            var data = getcontact(id);
            if (data == null)
                return HttpNotFound();
            
            _context.contacts.Remove(data);
            return View("Index");
        }

     
        public Contacts getcontact(int id)
        {
            var contact = _context.contacts.SingleOrDefault(c => c.ID == id);
            if (contact == null)
                return null;
            else
                return contact;
        }
    }
}
