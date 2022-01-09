using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHub.Shared.Expenses
{
    public class ExpenseBillTo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Expense")]
        public int ExpenseId { get; set; }
        [ForeignKey("Roommate")]
        public int RoommateId { get; set; }
        public decimal Amount { get; set; }

        public virtual Expense Expense { get; set; }
        public virtual Roommate Roommate { get; set; }
    }
}
