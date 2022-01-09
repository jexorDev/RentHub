using RentHub.Shared.Expenses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHub.Shared
{
    public class Roommate
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal MonthlyRentAmount { get; set; }
        public ICollection<Expense> Expenses { get; set; }
    }
}
