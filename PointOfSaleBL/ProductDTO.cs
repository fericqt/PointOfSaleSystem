using FerPROJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleBL
{
    public class ProductDTO : CustomBLValidator, ICustomBL
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } = CustomCurrentLogin.GetCurrentDateTime();
        public string ProductCode { get; set; }
        public string ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public string ProductBarcode { get; set; }
        public string ProductExpiration { get; set; } = CustomCurrentLogin.GetCurrentDateTime();
        public string ProductManufacturer { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal RemainingQty { get; set; }
        public decimal PriceCost { get; set; }
        public decimal PriceUsed { get; set; }
        public decimal PriceIncrease => PriceUsed - PriceCost;
        public string ProcessedBy { get; set; } = CustomCurrentLogin.Username;

        public bool Validation()
        {
            throw new NotImplementedException();
        }
    }
}
