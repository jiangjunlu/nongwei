﻿using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.qixiang
{
    public partial class change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Admin.QiXiang admin = new Admin.QiXiang();
        
            try
            { 
                admin.updateqixiang(int.Parse(Request["qixiangid"]), Request["title"], Request["kaishiriqi"], int.Parse(Request["youxiaoqi"]), Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                   System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            }
            catch(Exception ex)
            {
                Response.Write(string.Format("alert(<script> alert('{0}')</script>)", ex.Message));
                //admin.updateqixiang(Request["qixiangid"], Request["title"], Request["kaishiriqi"], Request["youxiaoqi"], Microsoft.JScript.GlobalObject.unescape(Request["content"]),
                //    System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));

            }
        }
    }
}