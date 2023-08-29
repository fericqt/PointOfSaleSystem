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
    public class UserDB : ICustomRepo<CustomDBHelper, UserDTO, string>
    {
        public UserDB()
        {
            this.conn = new CustomDBHelper(CustomCurrentLogin.connString);
            this.tableName = "tbluser";
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

        public UserDTO GetById(string idTrack)
        {
            return conn.GetData<UserDTO>($"SELECT * FROM tbluser WHERE UserID = '{idTrack}'");
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
            return conn.GetCustomID("UID", tableName);
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
            conn.FillDGV(dgv, $"SELECT * FROM tbluser");
        }

        public void LoadListById(DataGridView dgv, string idTrack, string SearchValue = null)
        {
            throw new NotImplementedException();
        }

        public bool SaveData(UserDTO sDTO)
        {
            sDTO.UserID = GetNewID();
            if (sDTO.DataValidation())
            {
                return conn.SaveManual(tableName, sDTO);
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }

        public bool UpdateData(UserDTO sDTO)
        {
            if (sDTO.DataValidation())
            {
                return conn.UpdateManual(tableName, $"WHERE UserID = '{sDTO.UserID}'", sDTO);
            }
            CustomShowMessage.WarningMessageBox(sDTO.Error, "Warning");
            return false;
        }
        public bool ValidateUser(UserDTO sDTO)
        {
            string UserID = conn.GetStringID("UserID", tableName, $"WHERE Username = '{sDTO.Username}' AND Password = '{sDTO.Password}'");
            if (UserID != null)
            {
                var tblu = GetById(UserID);
                CustomCurrentLogin.UserID = tblu.UserID;
                CustomCurrentLogin.Username = tblu.Username;
                CustomCurrentLogin.UserLevel = tblu.Userlevel;
                return true;
            }
            CustomShowMessage.WarningMessageBox("Invalid Username/Password!\nPlease try again!", "Warning");
            return false;
        }
    }
}
