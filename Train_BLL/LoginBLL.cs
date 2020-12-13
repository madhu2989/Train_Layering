using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_Bo;
using Train_DAL;

namespace Train_BLL
{
    public class LoginBLL
    {
        LoginDAL ldal=new LoginDAL();
        public DataSet login(LoginBO lbo)
        {
            return ldal.login(lbo);
        }
    }
}
