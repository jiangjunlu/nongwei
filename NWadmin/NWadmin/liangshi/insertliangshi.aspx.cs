using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.liangshi
{
    public partial class insertliangshi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.LiangShi admin = new Admin.LiangShi();
            try
            {
                //admin.insertliangshi(Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["author"], Request["type"]);
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));
                admin.insertliangshi(Request["type"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["zh"]/*, "../uploadimg/" + file.FileName*/);
                //ad.insertyaowen(Request["title"], Request["keyword"],
                //  Request["type"], Microsoft.JScript.GlobalObject.unescape(Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                //  "../uploadimg/" + file.FileName, "123",
                //  "../uploadimg/" + file.FileName);
            }
            catch
            {
                admin.insertliangshi(Request["type"], Request["title"], Request["keyword"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Request["zh"]/*,Request["oldpath"]*/);
                //ad.insertyaowen(Request["title"], Request["keyword"],
                //    Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                //    " ", "123",
                //   "123" + "");
            }
        }
    }
}