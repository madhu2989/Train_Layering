using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Train_BLL;

namespace Train_UI
{
    public partial class viewbookinglist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserRoleID"].ToString() == "1")
            {
                if (!Page.IsPostBack)
                {
                    binddetailbook();
                }

            }
            else
                Response.Redirect("login.aspx");
        }

        public void binddetailbook()
        {
            TrainBLL tbll = new TrainBLL();
            DataSet ds = new DataSet();
            ds = tbll.displaybook();
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandArgument != null)
            {
                if (e.CommandName.ToLower() == "cmddelete")
                {
                    int p = Convert.ToInt32(e.CommandArgument);
                    TrainBLL tbll = new TrainBLL();
                    tbll.deletebook(p);
                    Label4.Text = "Deleted successfully of id " + p;
                }
            }
        }


    }
}