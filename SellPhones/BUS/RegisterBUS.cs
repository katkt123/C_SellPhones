using SellPhones.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhones.BUS
{
    public class RegisterBUS
    {
        private RegisterDAO rgDAO;

        public string Register(string user, string pass, string name, string address, string phone)
        {
            if (rgDAO.isUserNameExist(user))
            {
                return "Tên Đăng Nhập Đã Được Tạo";
            }
            else if (rgDAO.Register(user, pass, name, address, phone)) return "Đăng Ký Thành Công";
            else return "Đăng Ký Thất Bại";
            
        } 
    }
}
