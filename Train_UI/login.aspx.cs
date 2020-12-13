using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train_BLL;
using Train_Bo;

namespace Train_UI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            LoginBO lbo = new LoginBO();
            lbo.UserName = TextBox1.Text;

            LoginBLL lbll = new LoginBLL();
            ds = lbll.login(lbo);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Password_"].ToString() == TextBox2.Text)
                {
                    Session["UserName"] = ds.Tables[0].Rows[0]["UserName"].ToString();
                    Session["UserRoleID"] = ds.Tables[0].Rows[0]["UserRoleID"].ToString();
                    if (ds.Tables[0].Rows[0]["UserRoleID"].ToString() == "1")
                    {
                        Response.Redirect("welcomeAdmin.aspx");
                    }
                    else
                    {
                        Response.Redirect("welcomeGuest.aspx");
                    }
                }
              
                else
                {
                     Lab5.Text = "invalid credentials";
                }
            }
        }
    }
}