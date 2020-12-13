using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train_Bo;

namespace Train_DAL
{
    public class LoginDAL
    {

        string constr = "Data Source=ingnrilpsql01;Initial catalog=AHD16_AMS69_Common;User Id=a37;Password=a37;";
        SqlConnection con;

        public DataSet login(LoginBO lbo)
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_viewTrainlogin_madhusudhanBbyName", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", lbo.UserName);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
