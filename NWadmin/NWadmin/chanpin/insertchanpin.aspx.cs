using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.chanpin
{
    public partial class insertchanpin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ChanPin admin = new Admin.ChanPin();
            try
            {
                admin.insertchanpin(Request["title"], Request["pinzhong"], double.Parse(Request["jiashoujia"]), double.Parse(Request["dianshoujia"]), Request["tongbi"], Request["huanbi"], Request["bodong"],
                 System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
            }
            catch
            {
                admin.insertchanpin(Request["title"], Request["pinzhong"], double.Parse(Request["jiashoujia"]), double.Parse(Request["dianshoujia"]), Request["tongbi"], Request["huanbi"], Request["bodong"],
                 System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
            }
        }
    }
}