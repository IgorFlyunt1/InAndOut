using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]  
        public int Id { get; set; }

        [DisplayName("Name of Expenses")]
        public string NameExpense{ get; set; }

        [DisplayName("Amount Expenses")]
        public int AmountExpense{ get; set; }
    }
}
