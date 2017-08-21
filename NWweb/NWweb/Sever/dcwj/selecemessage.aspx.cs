using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWweb.Sever.dcwj
{
    public partial class selecemessage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string size ="1";
            DataSet ds = new DataSet();
            Admin.DCWJ admin = new Admin.DCWJ();
            try
            {
                ds= admin.selectwenjuan();  
                Response.Write(JsonTool.DataTableToJson(size, ds.Tables[0]));
            } 
            catch (Exception ex)
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
            }

        }
    }
}