using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsuranceAssignment.Models;

namespace CarInsuranceAssignment.Controllers
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Admin/Details/5
    
        // GET: Admin/Create
       

        // POST: Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
       
        // GET: Admin/Edit/5
       

        // POST: Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
       

        // GET: Admin/Delete/5
       

        // POST: Admin/Delete/5
    

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
