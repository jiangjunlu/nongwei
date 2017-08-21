using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using Oracle.DataAccess.Client;


namespace NWweb
{
    public class Admin
    {
        public class DCWJ {
            public void updateContent(string title,string selected)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("title",OracleDbType.Varchar2),
                    new OracleParameter("selected",OracleDbType.Clob)
                };
                p[0].Value = title;
                p[1].Value = selected;
                db.RunInsertOrUpdateOrSelectString(p, "dcwjxuanxiang.updatecontent");
            }
            public DataSet selectwenjuan()
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "dcwjxuanxiang.webselect");
                return ds;
            }
        }
        public class GongQiu
        {
            public DataSet selectgongqiu(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "gongqiu.webselectgongqiu");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void additems(string type, string title, string content, string xingming, string dianhua, string time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_xingming",OracleDbType.Varchar2),
                 new OracleParameter("p_dianhua",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2)
                
            };
                p[0].Value = type;
                p[1].Value = title;
                p[2].Value = content;
                p[3].Value = xingming;
                p[4].Value = dianhua;
                p[5].Value = time;
                db.RunInsertOrUpdateOrSelectString(p, "Gongqiu.addgongqiu");
            }
           public DataSet lookgongqiu(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
               DataSet ds=db.RunSelectTable(p, "gongqiu.weblookgongqiu");
               return ds;
            }
               
        }
        public class All
        {
            public DataSet selectReport()
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                 new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.selectReport");
                return ds;
            }

            public DataSet select_jgzs()
            {//查询农产品价格走势
                DbClass db = new DbClass();
                string sql = "select * from NONGCHANPIN_JIAGE  order by ADDRESS,PINZHONG,TIME desc";
                DataSet ds=db.Query(sql);
                return ds;
            }
            public DataSet select_gq()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.select_gq");
                return ds;
            }
            public DataSet selecttab()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.selecttab");
                return ds;
            }
            public DataSet select_all()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.select_all");
                return ds;
            }
            public DataSet select_fx()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.select_fx");//仅仅查询了分析预警题目
                return ds;
            }
            public DataSet select_ls()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.select_ls");
                return ds;
            }
            public DataSet select_sc()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.select_sc");
                return ds;
            }
            public DataSet select_nz()
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                { 
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "timu.select_nz");
                return ds;
            }
        }
        public class ZiXun
        {
            public DataSet search(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("p_accord",OracleDbType.Varchar2),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "zixun.search");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectzixun(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "zixun.selectzixun");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet lookzixun(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "zixun.weblookzixun");
            }
        }
        public class LiangShi
        {
            public DataSet search(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("p_accord",OracleDbType.Varchar2),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "liangshi.search");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet select_liangshi(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "liangshi.select_liangshi");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet look_liangshi(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "liangshi.weblookliangshi");
            }
        }
        public class ShuCai
        {
            public DataSet search(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("p_accord",OracleDbType.Varchar2),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "shucai.search");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectshucai(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "shucai.selectshucai");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet lookshucai(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "shucai.weblookshucai");
            }
        }
        public class NongZi
        {
            public DataSet search(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("p_accord",OracleDbType.Varchar2),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "nongzi.search");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectnongzi(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "nongzi.selectnongzi");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet looknongzi(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "nongzi.weblooknongzi");
            }
        }
        public class ZhuanJia
        {
            public DataSet select(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "zhuanjia.selectzhuanjia");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet look(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "zhuanjia.weblookzhuanjia");
            }
            public DataSet selectfortype(int index, string fang, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title", OracleDbType.Varchar2),
                    new OracleParameter("p_size", OracleDbType.Int32),
                    new OracleParameter("p_index", OracleDbType.Int32),
                    new OracleParameter("mycur", OracleDbType.RefCursor)
                };
                p[0].Value = fang;
                p[1].Direction = ParameterDirection.Output;
                p[2].Value = ((index - 1) * 8 + 1);
                p[3].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "zhuanjia.selectfortype");

                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
        }
        public class FenXi
        {
            public DataSet search(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("p_accord",OracleDbType.Varchar2),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "fenxiyujing.search");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet select(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "fenxiyujing.selectfenxi");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet look(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "fenxiyujing.weblookfenxi");
            }
        }
        public class JianCe
        {
            public DataSet search(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_flag",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("p_accord",OracleDbType.Varchar2),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "jiance.search");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet select(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "jiance.selectjiance");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet look(string title)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = title;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "jiance.weblookjiance");
            }
        }
    }
}