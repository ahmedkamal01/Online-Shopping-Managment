using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Online_Shopping_Management_System.BL
{
    class LOGIN
    {
        //Method to check authentication
        public DataTable authentication_login (string UserName , string password)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            SqlParameter [] para = new SqlParameter [2];
            para[0] = new SqlParameter("@ID", SqlDbType.NVarChar,50);
            para[0].Value = UserName;

            para[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            para[1].Value = password;

            

            DataTable Dt = new DataTable();
           Dt= dal.Read_Data("Loging_info", para);
            dal.Close_Connection();
            return Dt;
        }


        public DataTable Search_Users(string word)
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            DataTable Dt = new DataTable();
            SqlParameter[] par = new SqlParameter[1];
            par[0]= new SqlParameter("@word", SqlDbType.VarChar, 50);
            par[0].Value = word;
            Dt = dal.Read_Data("Search_Users", par);
            dal.Close_Connection();
            return Dt;
        }
    }
}
