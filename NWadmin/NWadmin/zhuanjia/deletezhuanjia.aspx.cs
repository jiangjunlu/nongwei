using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.zhuanjia
{
    public partial class deletezhuanjia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ZhuanJia ad = new Admin.ZhuanJia();
            try
            {
                ad.deletezhuanjia(int.Parse(Request["id"]));
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}