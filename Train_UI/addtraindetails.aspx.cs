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
    public partial class addtraindetails : System.Web.UI.Page
    {
        TrainBO tbo = new TrainBO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserRoleId"].ToString()=="1")
            {
                if (!Page.IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        binddetailsbyid();
                    }
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
           
           
        }
        public void binddetailsbyid()
        {
            tbo.TrainId = Convert.ToInt32(Request.QueryString["id"].ToString());
            DataSet ds = new DataSet();
            TrainBLL tbll = new TrainBLL();
            ds = tbll.viewbyid(tbo);

            if(ds!=null && ds.Tables.Count>0 && ds.Tables[0].Rows.Count>0)
            {
                TextBox1.Text = ds.Tables[0].Rows[0]["TrainName"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["Source"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["Destination"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["TicketFare"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Request.QueryString["id"]!=null)
            {
                tbo.TrainId = Convert.ToInt32(Request.QueryString["id"].ToString());
            }
            else
            {
                tbo.TrainId = 0;
            } 
            tbo.TrainName = TextBox1.Text;
            tbo.Source = TextBox2.Text;
            tbo.Destination = TextBox3.Text;
            tbo.TicketFare = Convert.ToDouble(TextBox4.Text);
            TrainBLL tbll = new TrainBLL();
            int res = tbll.addTraindetails(tbo);
		if(res<0)
		{
			label.Text="your booking ID is "+res;
		}


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewadmin.aspx");
        }
    }
}