using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private TaiKhoanDAO() { }

        public DataTable getAllTaiKhoan()
        {
            string query = "Select * from TaiKhoan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllQuyen()
        {
            string query = "Select * from Quyen";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool insertTaiKhoan(string user,string pass)
        {
            int trangthai = 0;
            string query = "insert into TaiKhoan (TenDangNhap,MatKhau,TrangThai) values( @TenDangNhap , @MatKhau , @TrangThai)";
            int result =  DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, pass, trangthai });
            return result == 1;
        }
        public bool addQuyen(string id,string quyen)
        {
            
            string query = "UPDATE Quyen SET Quyen = @Quyen WHERE MaTK = @MaTK";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quyen , id });
            return result == 1;
        }

        public bool isUserNameExist(string username)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = @TenDangNhap ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dt.Rows.Count > 0;
        }
        public bool UpdateTaiKhoan(string user, string pass)
        {
            string query = "update TaiKhoan set TenDangNhap = @TenDangNhap and MatKhau = @MatKhau ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, pass });
            return result == 1;
        }
        public bool DelTaiKhoan(string id)
        {
            int result = 0;
            string query = "delete from TaiKhoan where MaTK = @MaTK ";
            string query1 = "delete from Quyen where MaTK = @MaTK ";
            result = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { id });
            result = result +DataProvider.Instance.ExecuteNonQuery(query1, new object[] { id });
            return result == 2;
        }
    }
}
