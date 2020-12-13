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
    public partial class viewadmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserRoleId"].ToString()=="1")
            {
                binddetails();
            }
            else
            {
                Response.Redirect("login.aspx");
            }
            
        }
        public void binddetails()
        {
            TrainBLL tbll = new TrainBLL();
            DataSet ds = new DataSet();
            ds = tbll.display();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandArgument != null)
            {
                if (e.CommandName.ToLower() == "cmdedit")
                {
                    Response.Redirect("addtraindetails.aspx?id=" + e.CommandArgument);
                }
                else
                {
                    TrainBO tbo = new TrainBO();
                    int d = Convert.ToInt32(e.CommandArgument);
                    TrainBLL tbll = new TrainBLL();
                    tbll.delete(d);
                }
            }
        }
    }
}