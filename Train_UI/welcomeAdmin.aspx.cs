using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train_BLL;
using Train_Bo;

namespace Train_UI
{
    public partial class welcomeAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRoleID"]!=null && Session["UserRoleID"].ToString() =="1")
            {
                Label3.Text = "welcome " + Session["UserName"];
                
            }
            else
                Response.Redirect("login.aspx");
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addtraindetails.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewadmin.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("loginaspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbookinglist.aspx");
        }

       
    }
}