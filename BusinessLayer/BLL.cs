using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    
    public class BLL
    {
        DAL dataLayer = new DAL();
        public bool AuthorizeUser(MyUser user)
        {
            return dataLayer.AuthorizeUSer(user.UserId, user.Password);
        }

        public  string GetUSerName(int userId)
        {
            return dataLayer.GetUserName(userId);
        }
    }
}
