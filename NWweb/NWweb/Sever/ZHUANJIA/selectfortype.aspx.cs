using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWweb.Sever.ZHUANJIA
{
    public partial class selectfortype : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ZhuanJia admin = new Admin.ZhuanJia();
            string size = "1";
          //  string responce = "";
            DataSet ds = new DataSet();
            try
            {
                //size代表当前的页数
                ds = admin.selectfortype(int.Parse(Request["index"]), Request["fangxiang"], ref size);
               // int dangqian = int.Parse(Request["dangqian"]);
                Response.Write(JsonTool.DataTableToJson(size ,ds.Tables[0]));
            }
            catch (Exception ex)
            {
                //Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
               Response.Write( string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }
        }
    }
}