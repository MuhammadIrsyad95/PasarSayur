using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarSayur.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<TransactionItemModel> Items { get; set; }  
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }

    public class TransactionItemModel
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}
