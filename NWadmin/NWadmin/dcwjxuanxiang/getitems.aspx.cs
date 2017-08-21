using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NWadmin.dcwjxuanxiang
{
    public partial class getitems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            OracleParameter[] p =
            {
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
            p[0].Direction = ParameterDirection.Output;
           DataSet ds= db.RunSelectTable(p, "dcwjxuanxiang.getitems");
            Response.Write(JsonTool.DataTableToJson("0",ds.Tables[0]));
        }
    }
}