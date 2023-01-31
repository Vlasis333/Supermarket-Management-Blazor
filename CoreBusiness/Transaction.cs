using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; } // in case product name changes
        public double Price { get; set; }
        public int BeforeQuantity { get; set; }
        public int SoldQuantity { get; set; }
        public string CashierName { get; set; }
    }
}
