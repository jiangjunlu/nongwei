using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.user
{
    public partial class user : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.User admin = new Admin.User();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                ds = admin.selectuser(int.Parse(Request["index"]), ref size);
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
            }
            catch (Exception ex)
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }
        }
    }
}