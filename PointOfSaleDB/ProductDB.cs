using FerPROJ;
using FerPROJ.FerDB;
using PointOfSaleBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleDB
{
    public class ProductDB : ICustomRepo<CustomDBHelper, ProductDTO, string>
    {
        public ProductDB()
        {
            this.conn = new CustomDBHelper(CustomCurrentLogin.connString);
            this.tableName = "tblproduct";
        }

        public CustomDBHelper conn { get; set; }
        public string tableName { get; set; }
        public string tableNameDetails { get; set; }

        public bool DeleteData(string idTrack)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ProductDTO GetById(string idTrack)
        {
            string[] fieldToExclude = {"PriceIncrease" };
            return conn.GetData<ProductDTO>($"SELECT * FROM {tableName} WHERE ProductCode = '{idTrack}'", fieldToExclude);
        }

        public string GetDetailsById(string idTrack)
        {
            throw new NotImplementedException();
        }

        public int GetIntMaxMinID(string MaxMin, string columnName, string whereCondition = "")
        {
            throw new NotImplementedException();
        }

        public List<string> GetListDetails(string idTrack)
        {
            throw new NotImplementedException();
        }

        public string GetNewID()
        {
            return conn.GetCustomID("PC", tableName);
        }

        public string GetStringID(string columnName, string whereStatement)
        {
            throw new NotImplementedException();
        }

        public void LoadComboBox(CustomComboBox cmb)
        {
            throw new NotImplementedException();
        }

        public void LoadListAll(DataGridView dgv, string SearchValue = null)
        {
            conn.FillDGV(dgv, $"SELECT * FROM {tableName}");
        }

        public void LoadListById(DataGridView dgv, string idTrack, string SearchValue = null)
        {
            throw new NotImplementedException();
        }

        public bool SaveData(ProductDTO sDTO)
        {
            if (sDTO.DataValidation())
            {
                sDTO.ProductCode = GetNewID();
                return conn.SaveManual(tableName, sDTO);
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }

        public bool UpdateData(ProductDTO sDTO)
        {
            if (sDTO.DataValidation())
            {
                return conn.UpdateManual(tableName, $"WHERE ProductCode = '{sDTO.ProductCode}'" ,sDTO);
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }
    }
}
