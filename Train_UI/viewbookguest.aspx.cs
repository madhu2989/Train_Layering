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
    public partial class viewbookguest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserRoleId"].ToString()!="1")
            {
                if(!Page.IsPostBack)
                {
                    binddetailbook();
                }
                
            }
           
        }
        public void binddetailbook()
        {
            TrainBLL tbll = new TrainBLL();
            DataSet ds = new DataSet();
            ds = tbll.displaybook();
            GridView5.DataSource = ds;
            GridView5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcomeGuest.aspx");
        }
    }
}