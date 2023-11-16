using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            string getall = "select * from TaiKhoan";
            DataTable list = DataProvider.Instance.ExecuteQuery(getall, new object[] { });
            int row = list.Rows.Count + 1;
            String id;
            if (row >= 100 && row <= 999) id = "TK" + row.ToString();
            else if (row >= 10 && row <= 99) id = "TK0" + row.ToString();
            else if (row >= 1 && row <= 9) id = "TK00" + row.ToString();
            else id = "TK" + row.ToString();

            string query = "insert into TaiKhoan (MaTK,TenDangNhap,MatKhau,TrangThai) values( @id , @user , @pass ,0 )";
            int result =  DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,user, pass });

            string query1 = "insert into Quyen (MaTK) values ( @id )";
            result += DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result == 2;
        }
        public bool addQuyen(string id,string quyen)
        {
            
            string query = "UPDATE Quyen SET PhanQuyen = @PhanQuyen WHERE MaTK = @MaTK";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quyen , id });
            return result == 1;
        }

        public bool isUserNameExist(string username)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = @TenDangNhap ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dt.Rows.Count > 0;
        }
        public bool UpdateTaiKhoan(string id, string user, string pass)
        {
            string query = "update TaiKhoan set TenDangNhap = @TenDangNhap , MatKhau = @MatKhau where MaTK = @id ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user, pass , id });
            return result == 1;
        }
        public bool DelTaiKhoan(string id)
        {
            int result = 0;
            string query = "delete from TaiKhoan where MaTK = @MaTK ";
            string query1 = "delete from Quyen where MaTK = @MaTK ";
            result = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { id });
            result = result +DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result == 2;
        }
        public DataTable searchTaiKhoan(String data, String action)
        {
            string query = "";
            if (action == "Mã Tài Khoản")
                query = "select * from TaiKhoan where MaTK like '%" + data + "%'";
            else if (action == "Tên Tài Khoản")
                query = "select * from TaiKhoan where TenDangNhap like '%" + data + "%'";
            
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool KhoaTaiKhoan(string id)
        {
            int result = 0;
            string PhanQuyen = "Khóa";
            string query = "Update Quyen set PhanQuyen = @PhanQuyen where MaTK = @id";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {PhanQuyen, id});
            return result == 1;
        }

    }
}
