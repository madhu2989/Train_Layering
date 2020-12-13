using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train_Bo
{
    public class LoginBO
    {
      

        


        string userName;

        public string UserName
        {
          get { return userName; }
          set { userName = value; }
        }

        string password;

        public string Password
        {
          get { return password; }
          set { password = value; }
        }

        int userRoleId;

        public int UserRoleId
        {
          get { return userRoleId; }
          set { userRoleId = value; }
        }
    
    }
}
