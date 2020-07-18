using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Online_Shopping_Management_System.BL
{
    class Manger : Person
    {
        //=============================================
        //                data members 
        string user;
        string fullname;
        string state;
        string password;
        //=============================================
        //             Defult Constructor

        public Manger ()
        {

        }
        //=============================================
        //          Set data members values 

        public string SET_USER
        {
            set
            {
                user = value;
            }
            get
            {
                return user;
            }
        }

       override public void SET_FIRST_LAST (string f, string l)
        {
            First = f;
            Last = l;
        }
        public string SET_FullName
        {
            set
            {
                fullname = First + " "+Last;
            }

            get
            {
                return fullname;
            }
        }

        public string SET_STATE
        {
            set
            {
                state = value;
            }
            get
            {
                return state;
            }
        }

        public string SET_PASSWORD
        {
            set
            {
                password = value;
            }
            get
            {
                return password;
            }
        }

        //==========================================================
        // member functions 

        public void Add_User()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();

            SqlParameter[] paramter = new SqlParameter[4];
            paramter[0] = new SqlParameter("@user_id", SqlDbType.NVarChar, 50);
            paramter[0].Value = user;
            paramter[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            paramter[1].Value = password;
            paramter[2] = new SqlParameter("@state", SqlDbType.NChar, 10);
            paramter[2].Value = state;
            paramter[3] = new SqlParameter("@Fullname", SqlDbType.VarChar, 50);
            paramter[3].Value = fullname;

            dal.ExecuteCommand("ADD_USER", paramter);
            dal.Close_Connection();

        }

        public void Edit_User()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();

            SqlParameter[] paramter = new SqlParameter[4];
            paramter[0] = new SqlParameter("@user_id", SqlDbType.NVarChar, 50);
            paramter[0].Value = user;
            paramter[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            paramter[1].Value = password;
            paramter[2] = new SqlParameter("@state", SqlDbType.NChar, 10);
            paramter[2].Value = state;
            paramter[3] = new SqlParameter("@Fullname", SqlDbType.VarChar, 50);
            paramter[3].Value = fullname;

            dal.ExecuteCommand("edit_User", paramter);
            dal.Close_Connection();

        }

        public void Delete_User()
        {
            DAL.Data_Access_Layer dal = new DAL.Data_Access_Layer();
            dal.open_Connection();
            BL.Product prd = new BL.Product();

            SqlParameter[] paramter = new SqlParameter[1];
            paramter[0] = new SqlParameter("@user_id", SqlDbType.NVarChar, 50);
            paramter[0].Value = user;


            dal.ExecuteCommand("delete_User", paramter);
            dal.Close_Connection();

        }

    }
}
