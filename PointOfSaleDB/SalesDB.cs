using FerPROJ;
using FerPROJ.FerDB;
using PointOfSaleBL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleDB
{
    public class SalesDB : ICustomRepo<CustomDBHelper, SalesDTO, SalesDetailsDTO>
    {
        public SalesDB()
        {
            this.conn = new CustomDBHelper(CustomCurrentLogin.connString);
            this.tableName = "tblsales";
            this.tableNameDetails = "tblsalesdetails";
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

        public SalesDTO GetById(string idTrack)
        {
            throw new NotImplementedException();
        }

        public SalesDetailsDTO GetDetailsById(string idTrack)
        {
            throw new NotImplementedException();
        }

        public int GetIntMaxMinID(string MaxMin, string columnName, string whereCondition = "")
        {
            throw new NotImplementedException();
        }

        public List<SalesDetailsDTO> GetListDetails(string idTrack)
        {
            throw new NotImplementedException();
        }

        public string GetNewID()
        {
            return conn.GetCustomID("ST", tableName);
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
            throw new NotImplementedException();
        }

        public void LoadListById(DataGridView dgv, string idTrack, string SearchValue = null)
        {
            throw new NotImplementedException();
        }

        public bool SaveData(SalesDTO sDTO)
        {
            string[] xField = { "RemainingQty", };

            if (sDTO.DataValidation())
            {
                sDTO.TransNo = GetNewID();               
                if(conn.SaveManual(tableName, sDTO))
                {
                    foreach(var item in sDTO.PurchaseItem)
                    {
                        UpdateProductQty(item.ProductCode, item.Qty);
                        item.TransNo = sDTO.TransNo;
                        conn.SaveDetailsManual(tableNameDetails, item, xField);
                    }
                    return true;
                }
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }

        public bool UpdateData(SalesDTO sDTO)
        {
            throw new NotImplementedException();
        }
        private void UpdateProductQty(string pCode, decimal qty)
        {
            var tblp = new ProductDB().GetById(pCode);
            decimal RemQty = tblp.RemainingQty;
            decimal NewQty = RemQty - qty;
            conn.UpdateDetailsCustom($"UPDATE tblproduct SET RemainingQty = {NewQty} WHERE ProductCode = '{pCode}'");
        }
        public DataTable GetData(string queryStatement)
        {
            return conn.GetDataTable(queryStatement);
        }
    }
}
