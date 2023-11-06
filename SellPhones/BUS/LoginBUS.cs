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
            return LoginDAO.Instance.Login(name, password);
        }

        public String active(string id)
        {
            if (LoginDAO.Instance.active(id))
            {
                return "Tài Khoản Đăng Nhập Thành Công";
            }
            else return "Tài Khoản Đăng Nhập Thất Bại";
        }
        public String unactive(string id)
        {
            if (LoginDAO.Instance.unactive(id))
            {
                return "Tài Khoản Đăng Xuất Thành Công";
            }
            else return "Tài Khoản Đăng Xuất Thất Bại";
        }

        public DataTable id_active()
        {
            return LoginDAO.Instance.id_active();
        }

    }
}
