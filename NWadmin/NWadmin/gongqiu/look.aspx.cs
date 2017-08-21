using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace NWadmin.gongqiu
{
    public partial class look : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request["id"]); 
            DbClass db = new DbClass();
            OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
            p[0].Value = id;
            p[1].Direction = ParameterDirection.Output;
            DataSet ds = db.RunSelectTable(p, "gongqiu.look");
            string type = ds.Tables[0].Rows[0]["GONGQIU_XINXI_LEIXING"].ToString();
            string author = ds.Tables[0].Rows[0]["GONGQIU_XINXI_RENYUAN_XINGMING"].ToString();
            string states = ds.Tables[0].Rows[0]["STATE"].ToString();
            string zt = ds.Tables[0].Rows[0]["GONGQIU_XINXI_SHENHE_ZHUANGTAI"].ToString();
            string sp = ds.Tables[0].Rows[0]["GONGQIU_XINXI_SHANGPIN"].ToString();
            string body = ds.Tables[0].Rows[0]["GONGQIU_XINXI_MIAOSHU"].ToString();
            if (type == "0")
            {
                type = "供";
            }
            else
                type = "求";
            title.Text = type;
            goods.Text = sp;
            user.Text = author;
            content.Text = body;
            phone.Text = ds.Tables[0].Rows[0]["GONGQIU_XINXI_RENYUAN_DIANHUA"].ToString();
            if (zt == "0")
            {
                state.Text = "未审核";

            }
            else
            {
                if (states == "1")
                {
                    state.Text = "已通过";

                }
                else
                {
                    state.Text = "未通过";

                }
            }
            //string imageurl = "http://210.47.1.242:2311/Images/" + ds.Tables[0].Rows[0]["GONGQIU_XINXI_TUPIAN_LIANJIE"].ToString();

            //Image1.ImageUrl = imageurl;
            changestate.Text = "";
        }
        private bool UrlIsExist(String url)
        {
            System.Uri u = null;
            try
            {
                u = new Uri(url);
            }
            catch { return false; }
            bool isExist = false;
            System.Net.HttpWebRequest r = System.Net.HttpWebRequest.Create(u)
                                    as System.Net.HttpWebRequest;
            r.Method = "HEAD";
            try
            {
                System.Net.HttpWebResponse s = r.GetResponse() as System.Net.HttpWebResponse;
                if (s.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    isExist = true;
                }
            }
            catch (System.Net.WebException x)
            {
                try
                {
                    isExist = ((x.Response as System.Net.HttpWebResponse).StatusCode !=
                                System.Net.HttpStatusCode.NotFound);
                }
                catch { isExist = (x.Status == System.Net.WebExceptionStatus.Success); }
            }
            return isExist;
        }

        protected void QD_Click(object sender, EventArgs e)
        {
            DbClass db = new DbClass();
            OracleParameter[] p
                =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("p_state",OracleDbType.Int32)
                };
            p[0].Value = id;
            p[1].Value = changestate.SelectedIndex;
            db.RunInsertOrUpdateOrSelectString(p, "gongqiu.changestate");
            Response.Write("<script>location.replace('../gongqiuzhuanqu.html');</script>");
        }

    }
}