using ExpenseManager.Data;
using ExpenseManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }

        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }
    }
}
