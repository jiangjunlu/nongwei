using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.zhuanjia
{
    public partial class insertzhuanjia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ZhuanJia admin = new Admin.ZhuanJia();
            try
            {
                admin.insertzhuanjia(Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));

                // ad.insertyaowen( Request["title"], Request["keyword"],
                //   Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                //   "../uploadimg/" + file.FileName, "123",
                //   "../uploadimg/" + file.FileName);
            }
            catch
            {
                admin.insertzhuanjia(Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"]);
                //ad.insertyaowen(Request["title"], Request["keyword"],
                //    Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                //    " ", "123",
                //   "123" + "");
            }
        }
    }
}