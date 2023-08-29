using FerPROJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleBL
{
    public class SalesDetailsDTO : CustomBLValidator, ICustomBL
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } = CustomCurrentLogin.GetCurrentDateTime();
        public string TransNo { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public decimal Qty { get; set; }
        public decimal RemainingQty { get; set; }
        public decimal Discount { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount => ((Price * Qty) - Discount);

        public bool Validation()
        {
            if(Qty > RemainingQty)
            {
                CustomShowMessage.WarningMessageBox("Qty to purchase is morethan the qty remaining!", "Warning");
                return false;
            }
            return true;
        }
    }
}
