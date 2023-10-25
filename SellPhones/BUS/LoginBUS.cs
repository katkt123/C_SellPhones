using Sellphone.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class LoginBUS
    {
        private static LoginBUS instance;
        private LoginDAO lgDAO;

        public static LoginBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoginBUS();
                return LoginBUS.instance;
            }
            private set { LoginBUS.instance = value; }
        }

        public DataTable Login(string name, string password)
        {
            return lgDAO.Login(name, password);
        }

        public String active(String id)
        {
            if (lgDAO.active(id))
            {
                return "Tài Khoản Đăng Nhập Thành Công";
            }
            else return "Tài Khoản Đăng Nhập Thất Bại";
        }


    }
}
