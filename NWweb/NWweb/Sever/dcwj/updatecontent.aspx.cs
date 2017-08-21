using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWweb.Sever.dcwj
{
    public partial class updatecontent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.DCWJ admin = new Admin.DCWJ();
            admin.updateContent(Request["title"],Request["xuanxiang"]);
        }
    }
}