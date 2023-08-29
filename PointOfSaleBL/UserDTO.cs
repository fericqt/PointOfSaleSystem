using FerPROJ;
using PointOfSaleSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleBL
{
    public class UserDTO : CustomBLValidator, ICustomBL
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } = CustomCurrentLogin.GetCurrentDateTime();
        public string UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Userlevel { get; set; } = "Admin";
        public string Status { get; set; } = BaseSettings.Status.ACTIVE.ToString();


        public bool Validation()
        {
            throw new NotImplementedException();
        }
    }
}
