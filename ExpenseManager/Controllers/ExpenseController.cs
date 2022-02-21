using ExpenseManager.Data;
using ExpenseManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDBContext _db;
        public IActionResult Index()
        {
            IEnumerable<Expense> objList = _db.Expenses;
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expense obj)
        {
            _db.Expenses.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ExpenseController(ApplicationDBContext db)
        {
            _db = db;
        }
    }
}
