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
    public class ExpenseCategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ExpenseCategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ExpenseCategory> objList = _db.expenseCategory;
            return View(objList);
        }


        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ExpenseCategory obj)
        {
            _db.expenseCategory.Add(obj);
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

            var obj = _db.expenseCategory.Find(id);
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
            var obj = _db.expenseCategory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.expenseCategory.Remove(obj);
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

            var obj = _db.expenseCategory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST: Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(ExpenseCategory obj)
        {
            _db.expenseCategory.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
