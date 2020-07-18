using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Online_Shopping_Management_System.BL
{
    class Customers :Person
    {
        // data members
        string first;
        string last;
        string phone;
        string emai;
        byte[] img;
        string stat;
        int id;
        //====================================================
        //Default Constructor 
        public Customers()
        { }
        //====================================================
        //SET Date members values
       override public void SET_FIRST_LAST(string f, string l)
        {
            First = f;
            Last = l;
        }

        public void SET_Values (string ph , string em,byte []im,string state) 
        {
            first = First;
            last = Last;
            phone = ph;
            emai = em;
            img = im;
            stat = state;
        }
        public void SET_ID (int ID)
        {
            id = ID;
        }
        //====================================================
        //member functions 
        public void  New_Cust ()
        {
            
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@first", SqlDbType.VarChar,50);
            param[0].Value = first;

            param[1] = new SqlParameter("@last", SqlDbType.VarChar, 50);
            param[1].Value = last;

            param[2] = new SqlParameter("@tele", SqlDbType.NChar, 20);
            param[2].Value = phone;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[3].Value = emai;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@state", SqlDbType.VarChar,50);
            param[5].Value = stat;


            dal.ExecuteCommand("new_customer", param);

            dal.Close_Connection();
        }
        
        public DataTable Get_Customers()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            Dt = dal.Read_Data("Get_All_Customers", null);

            return Dt;
        }
        
        public void edit_Cust()
        {

            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@first", SqlDbType.VarChar, 50);
            param[0].Value = first;

            param[1] = new SqlParameter("@last", SqlDbType.VarChar, 50);
            param[1].Value = last;

            param[2] = new SqlParameter("@tele", SqlDbType.NChar, 20);
            param[2].Value = phone;

            param[3] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[3].Value = emai;

            param[4] = new SqlParameter("@img", SqlDbType.Image);
            param[4].Value = img;

            param[5] = new SqlParameter("@state", SqlDbType.VarChar, 50);
            param[5].Value = stat;

            param[6] = new SqlParameter("@ID", SqlDbType.Int);
            param[6].Value = id;

            dal.ExecuteCommand("edit_customer", param);

            dal.Close_Connection();
        }

        public void delete_Cust ()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@ID", SqlDbType.Int);
            par[0].Value = id;
            dal.ExecuteCommand("delete_customer",par);
            dal.Close_Connection();
        }

        public DataTable Search_Customers(string word)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();

            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@word", SqlDbType.VarChar,50);
            par[0].Value = word;

            Dt = dal.Read_Data("Search_Customers",par);

            return Dt;
        }

        public DataTable find_cust ( )
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0] = new SqlParameter("@id", SqlDbType.Int);
            par[0].Value = id;
            Dt = dal.Read_Data("find_customer", par);

            return Dt;
        }
    }
}
