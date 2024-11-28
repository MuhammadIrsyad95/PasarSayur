using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasarSayur.Domain.Entities
{
    public class ReportStockModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int AvailableStock { get; set; }
    }

}
