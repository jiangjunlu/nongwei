using System;
using System.Collections.Generic;
using Microsoft.JScript;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.dcwj
{
    public partial class insertdcwj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJ admin = new Admin.DCWJ();
            try
            {
                admin.insertdcwj(Request["title"], Microsoft.JScript.GlobalObject.unescape(Request["describe"]), Request["result"], System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                //HttpPostedFile file = Request.Files["file"];
                //file.SaveAs(Server.MapPath("../uploadimg/" + file.FileName));

                // ad.insertyaowen( Request["title"], Request["keyword"],
                //   Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                //   "../uploadimg/" + file.FileName, "123",
                //   "../uploadimg/" + file.FileName);
            }
            catch
            {
                admin.insertdcwj(Request["title"],  Microsoft.JScript.GlobalObject.unescape(Request["describe"]), Request["result"], System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                //ad.insertyaowen(Request["title"], Request["keyword"],
                //    Request["type"],Microsoft.JScript.GlobalObject.unescape( Request["content"]), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                //    " ", "123",
                //   "123" + "");
            }
        }
    }
}