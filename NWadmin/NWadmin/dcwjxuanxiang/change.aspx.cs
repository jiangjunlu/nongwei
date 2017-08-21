using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwjxuanxiang
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJXuanXiang ad = new Admin.DCWJXuanXiang();
            ad.updatedcwjxuanxiang(int.Parse(Request["dcwjxuanxiangid"]),Microsoft.JScript.GlobalObject.unescape(Request["content"]),System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),int.Parse(Request["quanzhong"]));
           
        }
    }
}