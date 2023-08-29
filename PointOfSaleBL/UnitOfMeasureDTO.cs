using FerPROJ;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleBL
{
    public class UnitOfMeasureDTO : CustomBLValidator, ICustomBL
    {
        public int IdTrack { get; set; }
        public string DateReference { get; set; } = CustomCurrentLogin.GetCurrentDateTime();
        [Required]
        public string UnitOfMeasure { get; set; }

        public bool Validation()
        {
            throw new NotImplementedException();
        }
    }
}
