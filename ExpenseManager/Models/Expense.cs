using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public double Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
