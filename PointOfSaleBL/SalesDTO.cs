using FerPROJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleBL
{
    public class SalesDTO : CustomBLValidator, ICustomBL
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } = CustomCurrentLogin.GetCurrentDateTime();
        public string TransNo { get; set; }
        public string CustomerName { get; set; } = "Walk-In";
        public decimal SubTotal => PurchaseItem.Sum(c => c.Price * c.Qty);
        public decimal GrossTotal => PurchaseItem.Sum(c=>c.TotalAmount);
        public decimal TotalDiscount => PurchaseItem.Sum(c => c.Discount);
        public decimal TenderAmount { get; set; }
        public decimal TenderChange => TenderAmount - GrossTotal;
        public string ProcessedBy { get; set; } = CustomCurrentLogin.Username;

        public List<SalesDetailsDTO> PurchaseItem = new List<SalesDetailsDTO>();

        public bool Validation()
        {
            throw new NotImplementedException();
        }
        public void AddItem(SalesDetailsDTO itemToAdd)
        {
            PurchaseItem.Add(itemToAdd);
        }
        public void RemoveItem(SalesDetailsDTO itemToRemove)
        {
            PurchaseItem.Remove(itemToRemove);
        }
    }
}
