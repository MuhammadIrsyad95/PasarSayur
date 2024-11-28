using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarSayur.Domain.Entities
{
    public class ReportPOSModel
    {
        public int TransactionId { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime TransactionDate { get; set; }
    }

}
