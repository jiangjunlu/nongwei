using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwjxuanxiang
{
    public partial class dcwjxuanxiang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJXuanXiang admin = new Admin.DCWJXuanXiang();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                ds = admin.selectdcwjxuanxiang(int.Parse(Request["index"]),int.Parse(Request["titleid"]) ,ref size);
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]).ToString());
            }
            catch (Exception ex)
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }
        }
    }
}