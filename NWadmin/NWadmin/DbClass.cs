using System;
using System.Collections.Generic;
using System.Web;
using Oracle.DataAccess.Client;
using System.Data;
using System.IO;

using System.Text;
namespace NWadmin
{
    public class DbClass
    {
        OracleConnection con;
        public DbClass()
        {
            string connstring =
       "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=123.56.199.85) (PORT=1521))" +
      ")(CONNECT_DATA=(SID=nongwei)));Persist Security Info=True;User Id=scott; Password=nongwei";
            con = new OracleConnection(connstring);
            con.Open();
        }
        public void RunInsertOrUpdateOrSelectString(OracleParameter[] pars, string procedurename)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedurename;
            for (int i = 0; i < pars.Length; i++)
            {
                cmd.Parameters.Add(pars[i]);
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataSet RunSelectTable(OracleParameter[] pars, string procedurename)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procedurename;
            for (int i = 0; i < pars.Length; i++)
            {
                cmd.Parameters.Add(pars[i]);
            }
            DataSet ds = new DataSet();
            OracleDataAdapter adapter = new OracleDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            con.Close();
            return ds;
        }
    }
    }
