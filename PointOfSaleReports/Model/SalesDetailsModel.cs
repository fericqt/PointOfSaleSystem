using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleReports.Model
{
    public class SalesDetailsModel
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } 
        public string TransNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public decimal Qty { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
