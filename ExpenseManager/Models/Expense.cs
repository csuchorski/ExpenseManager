using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseManager.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Expense")]
        [Required]
        public string ExpenseName { get; set; }
        
        [Range(1,Double.MaxValue, ErrorMessage ="Value should be greater than 0")]
        [Required]
        public double Amount { get; set; }
        public DateTime ExpenseDate { get; set; }

        public Expense()
        {
            ExpenseDate = DateTime.Now;
        }
    }
}
