using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.shucai
{
    public partial class deleteshucai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.ShuCai ad = new Admin.ShuCai();
            try
            {
                ad.deleteshucai(int.Parse(Request["id"]));
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}