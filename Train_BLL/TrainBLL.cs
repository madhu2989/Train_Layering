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
    public class TrainBLL
    {
        TrainDAL tdal = new TrainDAL();

        public int addTraindetails(TrainBO tbo)
        {
            return tdal.addTraindetails(tbo);
        }

        public DataSet display()
        {
            return tdal.display();
        }

        public int delete(int d)
        {
            return tdal.delete(d);
        }

        public DataSet viewbyid(TrainBO tbo)
        {
            return tdal.viewbyid(tbo);
        }
        //book

        public int bookticket(TrainBO tbo)
        {
            return tdal.bookticket(tbo);
        }

        public DataSet drops()
        {
            return tdal.drop();
        }

        public double getprice(int id)
        {
            return tdal.getprice(id);
        }

        public int deletebook(int s)
        {
            return tdal.delete(s);
        }

        public DataSet displaybook()
        {
            return tdal.displaybook();
        }

    }
}
