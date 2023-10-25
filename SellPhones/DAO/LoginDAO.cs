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
            string query = "Select * from TaiKhoan where TenDangNhap = @tenTK and MatKhau = @matkhau ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name, password });
        }

        
        
        public bool active(string id)
        {
            int result = 0;
            string query = "update TAIKHOAN set trangthai = 1 where MaTK = @id";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
