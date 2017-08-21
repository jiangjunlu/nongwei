using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.chanpin
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ChanPin ad = new Admin.ChanPin();
            try
            {
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                // "../uploadimg/" + file.FileName, "../uploadimg/" + file.FileName
                ad.updatechanpin(Request["chanpinid"], Request["title"], Request["pinzhong"], double.Parse(Request["jiashoujia"]), double.Parse(Request["dianshoujia"]),Request["tongbi"],Request["huanbi"],Request["bodong"],
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
            }
            catch
            {
                ad.updatechanpin(Request["chanpinid"], Request["title"], Request["pinzhong"], double.Parse(Request["jiashoujia"]), double.Parse(Request["dianshoujia"]), Request["tongbi"], Request["huanbi"], Request["bodong"],
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);

            }
        }
    }
}