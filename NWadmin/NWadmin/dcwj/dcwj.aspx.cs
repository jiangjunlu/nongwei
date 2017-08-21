using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwj
{
    public partial class dcwj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJ admin = new Admin.DCWJ();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                ds = admin.selectdcwj(int.Parse(Request["index"]), ref size);
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
            }
            catch (Exception ex)
            {

                //Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));

            }
        }
    }
}