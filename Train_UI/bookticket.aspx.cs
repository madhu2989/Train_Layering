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
    public partial class bookticket : System.Web.UI.Page
    {
        TrainBLL tbll = new TrainBLL();
        TrainBO tbo = new TrainBO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserRoleId"].ToString()!="1")
            {
                if (!Page.IsPostBack)
                {
                    binddrop();
                }
            }
           
        }
        public void binddrop()
        {
            
            DataSet ds = new DataSet();
            ds = tbll.drops();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "TrainName";
            DropDownList1.DataValueField = "TrainId";
            DropDownList1.DataBind();
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            tbo.BookId = 0;
            tbo.UserName = TextBox1.Text;
            tbo.TrainId = Convert.ToInt32(DropDownList1.SelectedValue);
            tbo.Email = TextBox2.Text;
            tbo.ContactNo = Convert.ToDouble(TextBox3.Text);
            tbo.NoOftickets = Convert.ToInt32(TextBox4.Text);
            tbo.TicketAmount = Convert.ToDouble(TextBox5.Text);
            int r = tbll.bookticket(tbo);
            if (r > 0)
            {
                Lab1.Text = "Your booking id is " + r;
            }

        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (DropDownList1 != null)
            {
                double p = tbll.getprice(Convert.ToInt32(DropDownList1.SelectedValue));
                double amt = p * Convert.ToDouble(TextBox4.Text);
                TextBox5.Text = amt.ToString();
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(TextBox4.Text!=null)
            {
                double p = tbll.getprice(Convert.ToInt32(DropDownList1.SelectedValue));
                double amt = p * Convert.ToDouble(TextBox4.Text);
                TextBox5.Text = amt.ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("welcomeGuest.aspx");
        }
    }
}