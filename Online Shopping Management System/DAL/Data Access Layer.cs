using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Online_Shopping_Management_System.DAL
{
    class Data_Access_Layer
    {
        public
        SqlConnection sqlconnection;

        // This IS Constructor That Intialaize Connection between,
        // database and the program.
        public Data_Access_Layer()
        {
            if (Properties.Settings.Default.Mode == "SQL")
                sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.Server + "; Database="
                    + Properties.Settings.Default.Database + "; Integrated Security = false ; User ID="+Properties.Settings.Default.UserName
                    +"Password="+Properties.Settings.Default.Password+"");
            
            else
                sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.Server + "; Database=" +
                    Properties.Settings.Default.Database + "; Integrated Security = true");

        }
        //Method to Open Connection; 
        public void open_Connection()
        {
            if (sqlconnection.State == ConnectionState.Closed)
                sqlconnection.Open();

        }

        //Method to Close Connection
        public void Close_Connection()
        {
            if (sqlconnection.State == ConnectionState.Open)
                sqlconnection.Close();

        }

        //Method to Read Data From Database
        public DataTable Read_Data(String Stored_Procedure, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Procedure;
            cmd.Connection = sqlconnection;
            if (parameter != null)
            {
                for (int i = 0; i < parameter.Length; i++)
                {
                    cmd.Parameters.Add(parameter[i]);
                }
            }

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable Dt = new DataTable();
            DA.Fill(Dt);
            return Dt;
        }

        


        //Methode To Update - Insert - Delete Data from Database
        public void ExecuteCommand (String Stored_Procedure, SqlParameter[] parameter)
        {
            SqlCommand cmd= new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Stored_Procedure;
            cmd.Connection = sqlconnection;

            if (parameter != null)
            {
                cmd.Parameters.AddRange(parameter);
            }

            cmd.ExecuteNonQuery();
        }
    }
}
