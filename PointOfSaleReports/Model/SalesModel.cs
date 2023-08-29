using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleReports.Model
{
    public class SalesModel
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } 
        public string TransNo { get; set; }
        public string CustomerName { get; set; } 
        public decimal SubTotal { get; set; }
        public decimal GrossTotal { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TenderAmount { get; set; }
        public decimal TenderChange { get; set; }
        public string ProcessedBy { get; set; } 
    }
}
