using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sellphone.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;

        public static LoginDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public DataTable Login(string name, string password)
        {
            string query = "Select * from TaiKhoan where tenTK = @tenTK and matkhau = @matkhau ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name, password });
        }

        public bool isUserNameExist(string username)
        {
            string query = "Select * from TaiKhoan where tenTK = @tenTK ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dt.Rows.Count > 0;
        }
    }
}
