using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NWweb.Sever.ZHUANJIA
{
    public partial class selectmessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ZhuanJia admin = new Admin.ZhuanJia();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                string title = Request["title"];
                ds = admin.look(title);
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
            }
            catch (Exception ex)
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }
        }
    }
}