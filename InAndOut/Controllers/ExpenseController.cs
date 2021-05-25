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

        // POST: ExpenseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expense obj)
        {
            _db.expenses.Add(obj);
            _db.SaveChanges();
                return RedirectToAction("Index");
            
        }


    }
}

















