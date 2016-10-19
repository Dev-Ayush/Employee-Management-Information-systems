using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace EMP_MIS
{
   class db_connection
    {
        SqlCeConnection con;
        SqlCeCommand cmd;
        SqlCeDataAdapter da;
        DataSet ds;
       public db_connection()
        {
            con = new SqlCeConnection(@"Data Source=emp_mis.sdf");
            con.Open();
        }

        public void iud(string query)
        {
            cmd = new SqlCeCommand(query, con);
           
            cmd.ExecuteNonQuery();
        }

        public DataSet rs(string query)
        {
            cmd = new SqlCeCommand(query, con);
            da = new SqlCeDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds,"tab1");
            return ds;
        }

        ~db_connection()
        {
            con.Close();
        }
    }
}
