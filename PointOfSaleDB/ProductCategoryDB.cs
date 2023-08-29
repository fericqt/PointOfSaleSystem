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
    public class ProductCategoryDB : ICustomRepo<CustomDBHelper, ProductCategoryDTO, string>
    {
        public ProductCategoryDB()
        {
            this.conn = new CustomDBHelper(CustomCurrentLogin.connString);
            this.tableName = "tblproductcategory";
        }

        public CustomDBHelper conn { get; set; }
        public string tableName { get; set; }
        public string tableNameDetails { get; set; }

        public bool DeleteData(string idTrack)
        {
            return conn.DeleteManual(tableName, $"WHERE IdTrack = {idTrack}");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public ProductCategoryDTO GetById(string idTrack)
        {
            return conn.GetData<ProductCategoryDTO>($"SELECT * FROM {tableName} WHERE IdTrack = {idTrack}");
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
            throw new NotImplementedException();
        }

        public string GetStringID(string columnName, string whereStatement)
        {
            throw new NotImplementedException();
        }

        public void LoadComboBox(CustomComboBox cmb)
        {
            conn.FillCustomComboBox(cmb, "CategoryName", "IdTrack", $"SELECT * FROM {tableName}");
        }

        public void LoadListAll(DataGridView dgv, string SearchValue = null)
        {
            conn.FillDGV(dgv, $"SELECT * FROM {tableName}");
        }

        public void LoadListById(DataGridView dgv, string idTrack, string SearchValue = null)
        {
            throw new NotImplementedException();
        }

        public bool SaveData(ProductCategoryDTO sDTO)
        {
            if (sDTO.DataValidation())
            {
                return conn.SaveManual(tableName, sDTO);
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }

        public bool UpdateData(ProductCategoryDTO sDTO)
        {
            if (sDTO.DataValidation())
            {
                return conn.UpdateManual(tableName, $"WHERE IdTrack = {sDTO.IdTrack}", sDTO);
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }
    }
}
