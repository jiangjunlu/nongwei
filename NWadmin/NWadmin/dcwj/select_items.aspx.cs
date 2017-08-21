using System;
using System.Collections.Generic;
using System.Data;
using Oracle.DataAccess;
using Oracle.DataAccess.Client;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwj
{
    public partial class select_items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request["id"];
            string flag = Request["flag"];

            DbClass db = new DbClass();
            OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_result",OracleDbType.Int32)
            };
            p[0].Value = id;
            p[1].Value = flag;
            p[2].Direction = ParameterDirection.Output;
            db.RunInsertOrUpdateOrSelectString(p, "dcwj.updatezhuangtai");
            Response.Write(p[2].Value);
        }
    }
}