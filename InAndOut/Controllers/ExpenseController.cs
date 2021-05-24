using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
        public ActionResult Create(IFormCollection collection)
        {
           
                return RedirectToAction(nameof(Index));
            
        }


    }
}

















//        // GET: ExpenseController/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: ExpenseController/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: ExpenseController/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ExpenseController/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: ExpenseController/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: ExpenseController/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: ExpenseController/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//    }
//}
