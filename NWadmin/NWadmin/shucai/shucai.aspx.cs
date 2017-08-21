using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shucai
{
    public partial class shucai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShuCai admin = new Admin.ShuCai();
            string size = "1";
            DataSet ds = new DataSet();
            try
            {
                //这里可以用1来代替int.Parse(Request["index"])来具体查询某一条
                ds = admin.selectshucai(int.Parse(Request["index"]), ref size);
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