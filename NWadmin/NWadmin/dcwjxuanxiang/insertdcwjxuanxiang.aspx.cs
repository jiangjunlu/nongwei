using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwjxuanxiang
{
    public partial class insertdcwjxuanxiang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJXuanXiang admin = new Admin.DCWJXuanXiang();
                admin.insertdcwjxuanxiang( Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                     System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), 
                    int.Parse(Request["quanzhong"]),int.Parse(Request["titleid"]));
        }
    }
}