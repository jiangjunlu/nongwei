using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NWadmin.gongqiu
{
    public partial class gongqiu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string gq = Request["gq"];
            string shh = Request["shh"];
            Admin.GongQiu ad = new Admin.GongQiu();
            int size = 0;
            DataSet ds;
            if (gq == "2" && shh == "2")
            {
                ds = ad.selectgongqiu(int.Parse(Request["index"]), ref size);
                Response.Write(JsonTool.DataTableToJson(size.ToString(), ds.Tables[0]));
            }
            else
            {
                if (shh == "2" && gq != "2")
                {
                    ds = ad.searchgq(int.Parse(Request["index"]), int.Parse(Request["gq"]), ref size);
                    Response.Write(JsonTool.DataTableToJson(size.ToString(), ds.Tables[0]));
                }
                else
                {
                    if (gq == "2" && shh != "2")
                    {
                        ds = ad.searchshh(int.Parse(Request["index"]), int.Parse(Request["shh"]), ref size);
                        Response.Write(JsonTool.DataTableToJson(size.ToString(), ds.Tables[0]));
                    }
                    else
                    {
                        ds = ad.searchgqshh(int.Parse(Request["index"]), int.Parse(Request["gq"]), int.Parse(Request["shh"]), ref size);
                        Response.Write(JsonTool.DataTableToJson(size.ToString(), ds.Tables[0]));
                    }
                }
            }

        }
    }
}
        
