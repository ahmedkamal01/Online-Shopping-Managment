using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Online_Shopping_Management_System.BL
{
    class Product
    {
        public DataTable Get_Categories ()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
          Dt= dal.Read_Data("Get_Categories", null);
            
            return Dt;
        }

        public void Add_products (string prod_id,string name_prod,int quant,string price,int id_cat,byte[] img )
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();

            SqlParameter[] paramter = new SqlParameter[6];
            paramter[0] = new SqlParameter("@prod_ID", SqlDbType.NChar, 10);
            paramter[0].Value = prod_id;
            paramter[1] = new SqlParameter("@Name_prod", SqlDbType.VarChar, 50);
            paramter[1].Value = name_prod;
            paramter[2] = new SqlParameter("@quantity", SqlDbType.Int);
            paramter[2].Value = quant;
            paramter[3] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            paramter[3].Value = price;
            paramter[4] = new SqlParameter("@image", SqlDbType.Image);
            paramter[4].Value = img;
            paramter[5] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            paramter[5].Value = id_cat; ;
            
                dal.ExecuteCommand("store_Product", paramter);
                dal.Close_Connection();
                
            
            
            
        }

        public bool Find_ID (string ID)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par= new SqlParameter [1];
            par[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            par[0].Value = ID;
           Dt= dal.Read_Data("Find_ID", par);

            if (Dt.Rows.Count > 0)
                return false;

            return true;
        }

        public DataTable Get_allprdcts()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = dal.Read_Data("select_all_prdcts", null);
            return Dt;
        }

        public DataTable Search(string word)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@word", SqlDbType.VarChar, 50);
            par[0].Value = word;
            Dt = dal.Read_Data("Search",par);
            return Dt;
        }

        public DataTable Delete (string ID)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ID", SqlDbType.NChar, 50);
            par[0].Value = ID;
            Dt = dal.Read_Data("mydel", par);
            return Dt;
        }

        public DataTable get_image(string ID)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ID", SqlDbType.NChar, 10);
            par[0].Value = ID;
            Dt = dal.Read_Data("get_my_imag", par);
            dal.Close_Connection();
            return Dt;
        }


        public void update_products(string prod_id, string name_prod, int quant, string price, int id_cat, byte[] img)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();

            SqlParameter[] paramter = new SqlParameter[6];
            paramter[0] = new SqlParameter("@ID", SqlDbType.NChar, 50);
            paramter[0].Value = prod_id;
            paramter[1] = new SqlParameter("@Name_prod", SqlDbType.NVarChar, 50);
            paramter[1].Value = name_prod;
            paramter[2] = new SqlParameter("@quantity", SqlDbType.NChar, 10);
            paramter[2].Value = quant;
            paramter[3] = new SqlParameter("@image", SqlDbType.Image);
            paramter[3].Value = img;
            paramter[4] = new SqlParameter("@ID_Cat", SqlDbType.Int);
            paramter[4].Value = id_cat; ;
            paramter[5] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            paramter[5].Value = price;
           
           

            dal.ExecuteCommand("update_product", paramter);
            dal.Close_Connection();




        }
    }
}
