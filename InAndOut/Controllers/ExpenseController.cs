using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET
        public ActionResult Index()
        {
            IEnumerable<Expense> objList = _db.expenses;
            return View(objList);
        }

      



        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expense obj)
        {
            _db.expenses.Add(obj);
            _db.SaveChanges();
                return RedirectToAction("Index");
            
        }

        // GET: Delete
       
        public ActionResult Delete(int? id)
        { 
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }


        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int? id)
        {
            var obj = _db.expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.expenses.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


        // GET: Update

        public ActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.expenses.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST: Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Expense obj)
        {
            _db.expenses.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }




    }
}

















