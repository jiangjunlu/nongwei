using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dl.ServerClick += new EventHandler(login);
            zc.ServerClick += new EventHandler(zhuce);
        }
        protected void login(object sender, EventArgs e)
        {


            Admin.Login ad = new Admin.Login();
            HttpCookie cookie = new HttpCookie("zh");
            HttpCookie cookie2 = new HttpCookie("type");
            Response.Write(ad.login(zh.Value.ToString(), mm.Value.ToString()));
            if (ad.login(zh.Value.ToString(), mm.Value.ToString()) != "0")
            {
                cookie.Values.Add("", zh.Value.ToString());
                cookie2.Values.Add("", ad.getType(zh.Value.ToString()));
                Response.SetCookie(cookie);
                Response.AppendCookie(cookie2);
                Response.Redirect("index.html");
            }
            else
            {
                Response.Write("<script>alert('账号或密码错误')</script>");
            }

        }
        protected void zhuce(object sender, EventArgs e)
        {
            Response.Redirect("zhuce.aspx");
        }
    }
}