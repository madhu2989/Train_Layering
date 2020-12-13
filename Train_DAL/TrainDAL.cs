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
    public class TrainDAL
    {
        string constr = "Data Source=ingnrilpsql01;Initial catalog=AHD16_AMS69_Common;User Id=a37;Password=a37;";
        SqlConnection con;

        public int addTraindetails(TrainBO tbo)
        {
            int retTrainId = 0;
            try
            {
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_insertTrainMaster_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainId", tbo.TrainId);
                cmd.Parameters.AddWithValue("@TrainName", tbo.TrainName);
                cmd.Parameters.AddWithValue("@Source", tbo.Source);
                cmd.Parameters.AddWithValue("@Destination", tbo.Destination);
                cmd.Parameters.AddWithValue("@TicketFare", tbo.TicketFare);
                SqlParameter para = new SqlParameter("@TrainIdout", SqlDbType.Int);
                para.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(para);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    retTrainId = Convert.ToInt32(cmd.Parameters["@TrainIdout"].Value);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return retTrainId;
        }

        public DataSet display()
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_viewTrainMaster_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public int delete(int d)
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_deleteTrainBooking_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookingId", d);
                con.Open();
                int p = cmd.ExecuteNonQuery();
                con.Close();
                return p;
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(ds);
                //return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataSet viewbyid(TrainBO tbo)
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_viewTrainMaster_MadhusudhanBbyid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainId", tbo.TrainId);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //BOOKING
        public int bookticket(TrainBO tbo)
        {
            int retbookId = 0;
            try
            {
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_insertTrainBooking_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookingId", tbo.BookId);
                cmd.Parameters.AddWithValue("@TrainId", tbo.TrainId);
                cmd.Parameters.AddWithValue("@UserName", tbo.UserName);
                cmd.Parameters.AddWithValue("@Email", tbo.Email);
                cmd.Parameters.AddWithValue("@contactNo", tbo.ContactNo);
                cmd.Parameters.AddWithValue("@NoOfTicket", tbo.NoOftickets);
                cmd.Parameters.AddWithValue("@TicketAmount", tbo.TicketAmount);
                SqlParameter param = new SqlParameter("@BookingIdout", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    retbookId = Convert.ToInt32(cmd.Parameters["@BookingIdout"].Value);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
            return retbookId;
        }

        public DataSet drop()
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_viewTrainMaster_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public double getprice(int id)
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("getprice", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TrainId", id);
                con.Open();
                double p = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();
                return p;
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(ds);
                //return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int deletebook(int s)
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_deleteTrainBooking_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookingId", s);
                con.Open();
                int p = cmd.ExecuteNonQuery();
                con.Close();
                return p;
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(ds);
                //return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet displaybook()
        {
            try
            {
                DataSet ds = new DataSet();
                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("sp_viewTrainBooking_MadhusudhanB", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
