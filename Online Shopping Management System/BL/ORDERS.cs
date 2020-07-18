using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Online_Shopping_Management_System.BL
{
    class ORDERS
    {
        public DataTable Get_Last_order()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = dal.Read_Data("Get_last_order_ID", null);

            return Dt;
        }

        public void Add_Order(int order_id, DateTime order_date, int cust_id, string descrip , string sales_man, int Delivery_man,string total)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();
         
            SqlParameter[] paramter = new SqlParameter[7];
            paramter[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            paramter[0].Value = order_id;
            paramter[1] = new SqlParameter("@order_date", SqlDbType.Date);
            paramter[1].Value = order_date;
            paramter[2] = new SqlParameter("@Customer_id", SqlDbType.Int);
            paramter[2].Value = cust_id;
            paramter[3] = new SqlParameter("@Description_order", SqlDbType.VarChar, 250);
            paramter[3].Value = descrip;
            paramter[4] = new SqlParameter("@sales_man", SqlDbType.VarChar,50);
            paramter[4].Value = sales_man;
            paramter[5] = new SqlParameter("@Delivery_man", SqlDbType.Int);
            paramter[5].Value = Delivery_man;
            paramter[6] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            paramter[6].Value = total;

            dal.ExecuteCommand("Add_product", paramter);
            dal.Close_Connection();
            
        }


        public void Add_products_order(string id_prod, int order_ID, string quantiy, string price, double discount, string amount )
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();

            SqlParameter[] paramter = new SqlParameter[6];
            paramter[0] = new SqlParameter("@ID_PROD", SqlDbType.NChar,10);
            paramter[0].Value = id_prod;
            paramter[1] = new SqlParameter("@ID_ORDER", SqlDbType.Int);
            paramter[1].Value = order_ID;
            paramter[2] = new SqlParameter("@quantity", SqlDbType.NChar,10);
            paramter[2].Value = quantiy;
            paramter[3] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
            paramter[3].Value = price;
            paramter[4] = new SqlParameter("@discount", SqlDbType.Float);
            paramter[4].Value = discount;
            paramter[5] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            paramter[5].Value = amount;
            

            dal.ExecuteCommand("Add_Order_products", paramter);
            dal.Close_Connection();

        }

        public bool Check_Quantity(string ID,int quant)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[2];
            par[0] = new SqlParameter("@id_prod", SqlDbType.NChar, 10);
            par[0].Value = ID;
            par[1] = new SqlParameter("@quant", SqlDbType.Int);
            par[1].Value = quant;
            Dt = dal.Read_Data("check_quantity", par);

            if (Dt.Rows.Count > 0)
                return true;

            return false;
        }


        public DataTable GET_BELLS(string word)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@WORD", SqlDbType.VarChar,50);
            par[0].Value = word;
            Dt = dal.Read_Data("SEARCH_BELLS", par);

            return Dt;
        }


        public void  Delete_Bell (int id_order)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();

            dal.open_Connection();

            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@id_order", SqlDbType.Int);
            par[0].Value = id_order;
            dal.ExecuteCommand("delete_bell", par);
            dal.Close_Connection();
        }


        public DataTable GET_Details_return(int id)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@id_order", SqlDbType.Int);
            par[0].Value = id;
            Dt = dal.Read_Data("GET_Details_Order_return", par);

            return Dt;
        }

        public DataTable Return_Quantity(string ID, int quant,int order_id)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[3];
            par[0] = new SqlParameter("@product_id", SqlDbType.NChar, 10);
            par[0].Value = ID;
            par[1] = new SqlParameter("@quantity", SqlDbType.Int);
            par[1].Value = quant;
            par[2] = new SqlParameter("@id_order", SqlDbType.Int);
            par[2].Value = order_id;
            Dt = dal.Read_Data("return_product", par);

            return Dt;
        }
    }
}
