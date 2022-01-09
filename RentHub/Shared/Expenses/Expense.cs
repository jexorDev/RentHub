using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentHub.Shared.Expenses
{
    public class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; } 
        public DateTime DatePurchased { get; set; }
        public DateTime? DateUsed { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalCost { get; set; }
        public decimal SplitCost { get; set; }
        [ForeignKey("Roommate")]
        public int BuyerId { get; set; }
        //public Roommate Buyer { get; set; }
        //public ICollection<ExpenseBillTo> BillTos { get; set; } 
    }
}
