using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Savex.Models.Expense
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        //public string TypeOfExpense { get; set; }
        public int TypeOfExpenseId { get; set; }
        public TypeOfExpense TypeOfExpense { get; set; }
        [Required]
        public string Date { get; set; }
        public string Comment { get; set; }

    }
}
