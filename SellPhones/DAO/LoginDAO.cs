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
        private LoginDAO() { }
        public DataTable Login(string name, string password)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau ";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { name, password });
        }

        public DataTable id_active()
        {
            string query = "Select * from TaiKhoan where TrangThai = 1";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { });
        }

        public bool unactive(string id)
        {
            int result = 0;
            string query = "update TaiKhoan set TrangThai = 0 where MaTK = @id";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        
        public bool active(string id)
        {
            int result = 0;
            string query = "update TaiKhoan set TrangThai = 1 where MaTK = @id";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
        public string getQuyen(string id)
        {
            string quyen = "";
            string query = "SELECT * FROM Quyen WHERE MaTK = @Matk";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (dt.Rows.Count > 0)
            {
                quyen = dt.Rows[0]["PhanQuyen"].ToString(); // Thay "TenCot" bằng tên thực của cột quyền trong bảng Quyen
            }

            return quyen;
        }
        
    }
}
