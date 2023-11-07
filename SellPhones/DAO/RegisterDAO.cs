using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.DAO
{
    public class RegisterDAO
    {
        private static RegisterDAO instance;

        public static RegisterDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegisterDAO();
                return instance;
            }
            private set { instance = value; }
        }
        private RegisterDAO() { }
        public bool Register(string user,string pass,string name,string address,string phone)
        {
            int result = 0;
            
            string getall = "select * from TaiKhoan";
            DataTable list = DataProvider.Instance.ExecuteQuery(getall, new object[] {});
            int row = list.Rows.Count+1;
            String id;
            if (row>=100 && row<=999) id = "TK" + row.ToString();
            else if(row>=10 && row<=99) id = "TK0" + row.ToString();
            else if(row>=1 && row<=9) id = "TK00" + row.ToString();
            else id = "TK" + row.ToString();

            string getall2 = "select * from NhanVien";
            DataTable list2 = DataProvider.Instance.ExecuteQuery(getall2, new object[] { });
            int row2 = list.Rows.Count + 1;
            String id2;
            if (row >= 100 && row <= 999) id2 = "KH" + row.ToString();
            else if (row >= 10 && row <= 99) id2 = "KH0" + row.ToString();
            else if (row >= 1 && row <= 9) id2 = "KH00" + row.ToString();
            else id2 = "KH" + row.ToString();

            string query = "insert into TaiKhoan(MaTK,TenDangNhap,MatKhau,TrangThai) values( @MaTK , @TenDangNhap , @MatKhau , 0 )";
            result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, user,pass });

            string query2 = "insert into KhachHang(MaKH,TenKH,DiaChi,SDT,MaTK) values( @MaKH , @TenKH , @DiaChi , @SDT , @MaTK )";
            result = result + DataProvider.Instance.ExecuteNonQuery(query2, new object[] { id2, name,address,phone, id});
            return result == 2;

        }
        public bool isUserNameExist(string username)
        {
            string query = "Select * from TaiKhoan where TenDangNhap = @TenDangNhap ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dt.Rows.Count > 0;
        }

        

    }
}
