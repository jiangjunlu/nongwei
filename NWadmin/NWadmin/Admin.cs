using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using Oracle.DataAccess.Client;

namespace NWadmin
{
    public class Admin
    {
        public class ChanPin
        {
            public void deletechanpin(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_id", OracleDbType.Int32 )
                };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "chanpin.deletechanpin");
            }
            public DataSet searchchanpin(int index, int flag, ref string size, string accord)
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
                DataSet ds = db.RunSelectTable(p, "chanpin.searchchanpin");////暂时未提交
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchchanpin2(int index, int flag, ref string size, string accord)
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
                DataSet ds = db.RunSelectTable(p, "chanpin.searchchanpin2");//暂时未提交
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectchanpin(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_index", OracleDbType.Int32),
                    new OracleParameter("p_size", OracleDbType.Int32),//size是string类型，为什么会用int32??? 不过能用就好
                    new OracleParameter("mycur", OracleDbType.RefCursor)
                };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "chanpin.selectchanpin");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectforchangechanpin(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "chanpin.selectforchangechanpin");
            }
            public void updatechanpin(string chanpinid, string title, string pinzhong, double jiashoujia, double dianshoujia, string tongbi, string huanbi, string bodong, string updata_time,string admin)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_pinzhong",OracleDbType.Varchar2),
                new OracleParameter("p_jiashoujia",OracleDbType.Double),
                new OracleParameter("p_dianshoujia",OracleDbType.Double),
                new OracleParameter("p_tongbi",OracleDbType.Varchar2),
                new OracleParameter("p_huanbi",OracleDbType.Varchar2),
                new OracleParameter("p_bodong",OracleDbType.Varchar2),
                new OracleParameter("p_time",OracleDbType.Varchar2),
                new OracleParameter("p_admin",OracleDbType.Varchar2)
                
            };
                p[0].Value = chanpinid;
                p[1].Value = title;
                p[2].Value = pinzhong;
                p[3].Value = jiashoujia;
                p[4].Value = dianshoujia;
                p[5].Value = tongbi;
                p[6].Value = huanbi;
                p[7].Value = bodong;
                p[8].Value = updata_time;
                p[9].Value = admin;
                db.RunInsertOrUpdateOrSelectString(p, "chanpin.updatechanpin");
            }
            public void insertchanpin(string title, string pinzhong, double jiashoujia, double dianshoujia, string tongbi, string huanbi, string bodong, string updata_time, string admin)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_pinzhong",OracleDbType.Varchar2),
                new OracleParameter("p_jiashoujia",OracleDbType.Double),
                new OracleParameter("p_dianshoujia",OracleDbType.Double),
                new OracleParameter("p_tongbi",OracleDbType.Varchar2),
                new OracleParameter("p_huanbi",OracleDbType.Varchar2),
                new OracleParameter("p_bodong",OracleDbType.Varchar2),
                new OracleParameter("p_time",OracleDbType.Varchar2),
                new OracleParameter("p_admin",OracleDbType.Varchar2)
                
            };
                p[0].Value = title;
                p[1].Value = pinzhong;
                p[2].Value = jiashoujia;
                p[3].Value = dianshoujia;
                p[4].Value = tongbi;
                p[5].Value = huanbi;
                p[6].Value = bodong;
                p[7].Value = updata_time;
                p[8].Value = admin;
                db.RunInsertOrUpdateOrSelectString(p, "chanpin.insertchanpin");
            }
        }
        public class GongQiu
        {
            public void insertgongqiu(string title, string type, string name, string phone,string content,string time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_title", OracleDbType.Varchar2),
                    new OracleParameter("p_type", OracleDbType.Varchar2),
                    new OracleParameter("p_name", OracleDbType.Varchar2),
                    new OracleParameter("p_phone",OracleDbType.Varchar2),
                    new OracleParameter("p_content", OracleDbType.Clob),
                    new OracleParameter("p_time", OracleDbType.Varchar2)
                };
                p[0].Value = title;
                p[1].Value = type;
                p[2].Value = name;
                p[3].Value = phone;
                p[4].Value = content;
                p[5].Value = time;
                db.RunInsertOrUpdateOrSelectString(p, "gongqiu.insertgongqiu");
            }
            public void updategongqiu(int id, string title, string type, string name, string phone,string content,string time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_id", OracleDbType.Int32),
                    new OracleParameter("p_title", OracleDbType.Varchar2),
                    new OracleParameter("p_type", OracleDbType.Varchar2),
                    new OracleParameter("p_name", OracleDbType.Varchar2),
                    new OracleParameter("p_phone",OracleDbType.Varchar2),
                    new OracleParameter("p_content", OracleDbType.Clob),
                    new OracleParameter("p_time",OracleDbType.Varchar2)
                };
                p[0].Value = id;
                p[1].Value = title;
                p[2].Value = type;
                p[3].Value = name;
                p[4].Value = phone;
                p[5].Value = content;
                p[6].Value = time;
                db.RunInsertOrUpdateOrSelectString(p, "gongqiu.updategongqiu");
            }
            public DataSet selectforchangegongqiu(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "gongqiu.selectforchangegongqiu");
            }
            public void deletegongqiu(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "gongqiu.deletegongqiu");
            }

            public DataSet searchshh(int index, int sh, ref int size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_index",OracleDbType.Int32),
                    new OracleParameter("p_shh",OracleDbType.Int32),
                    new OracleParameter("p_size",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)

                };
                p[0].Value = (index - 1) * 8 + 1;
                p[1].Value = sh;
                p[2].Direction = ParameterDirection.Output;
                p[3].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "gongqiu.searchshh");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = q;
                return ds;
            }

            public DataSet searchgq(int index, int gq, ref int size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_index",OracleDbType.Int32),
                    new OracleParameter("p_gq",OracleDbType.Int32),
                    new OracleParameter("p_size",OracleDbType.Int32),                                                              
                    new OracleParameter("mycur",OracleDbType.RefCursor)

                };
                p[0].Value = (index - 1) * 8 + 1;
                p[1].Value = gq;
                p[2].Direction = ParameterDirection.Output;
                p[3].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "gongqiu.searchgq");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = q;
                return ds;
            }

            public DataSet searchgqshh(int index, int gq, int shh, ref int size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_index",OracleDbType.Int32),
                    new OracleParameter("p_gq",OracleDbType.Int32),
                    new OracleParameter("p_shh",OracleDbType.Int32),
                    new OracleParameter("p_size",OracleDbType.Int32),                                                              
                    new OracleParameter("mycur",OracleDbType.RefCursor)

                };
                p[0].Value = (index - 1) * 8 + 1;
                p[1].Value = gq;
                p[2].Value = shh;
                p[3].Direction = ParameterDirection.Output;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "gongqiu.searchgqshh");
                int q = int.Parse(p[3].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = q;
                return ds;
            }
            /// <summary>
            /// 选择供求信息
            /// </summary>
            /// <param name="type"></param>
            /// <param name="state"></param>
            /// <returns></returns>
            ///           

            public DataSet selectgongqiu(int index, ref int size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_index",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "Gongqiu.selectgongqiu");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = q;
                return ds;
            }
            /// <summary>
            /// 审核
            /// </summary>
            /// <param name="id"></param>
            public void examine(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                db.RunInsertOrUpdateOrSelectString(p, "sannong.examine");
            }
        }
        public class QiXiang
        {
            public DataSet selectqixiang(int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_index", OracleDbType.Int32),
                    new OracleParameter("p_size", OracleDbType.Int32),//size是string类型，为什么会用int32??? 不过能用就好
                    new OracleParameter("mycur", OracleDbType.RefCursor)
                };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Direction = ParameterDirection.Output;
                p[2].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "nongyeqixiang.selectqixiang");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void insertqixiang(string title, string kaishiriqi, int youxiaoqi, string content, string faburiqi)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_title", OracleDbType.Varchar2),
                    new OracleParameter("p_kaishiriqi", OracleDbType.Varchar2),
                    new OracleParameter("p_youxiaoqi", OracleDbType.Int32),
                    new OracleParameter("p_content", OracleDbType.Clob),
                    new OracleParameter("p_faburiqi", OracleDbType.Varchar2),
                };
                p[0].Value = title;
                p[1].Value = kaishiriqi;
                p[2].Value = youxiaoqi;
                p[3].Value = content;
                p[4].Value = faburiqi;
                db.RunInsertOrUpdateOrSelectString(p, "nongyeqixiang.insertqixiang");
            }
            public void deleteqixiang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_id", OracleDbType.Int32 )
                };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "nongyeqixiang.deleteqixiang");
            }
            public DataSet selectforchangeqixiang(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "nongyeqixiang.selectforchangeqixiang");
            }
            public void updateqixiang(int id, string title, string kaishiriqi, int youxiaoqi, string content, string update_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_id", OracleDbType.Int32),
                    new OracleParameter("p_title", OracleDbType.Varchar2),
                    new OracleParameter("p_kaishiriqi", OracleDbType.Varchar2),
                    new OracleParameter("p_youxiaoqi", OracleDbType.Int32),
                    new OracleParameter("p_content", OracleDbType.Clob),
                    new OracleParameter("p_faburiqi", OracleDbType.Varchar2),
                };
                p[0].Value = id;
                p[1].Value = title;
                p[2].Value = kaishiriqi;
                p[3].Value = youxiaoqi;
                p[4].Value = content;
                p[5].Value = update_time;
                db.RunInsertOrUpdateOrSelectString(p, "nongyeqixiang.updateqixiang");
            }
            public DataSet lookqixiang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                //2016/1/21-22:02 暂时没有向存储过程中写入，明天早晨去写
                return db.RunSelectTable(p, "nongyeqixiang.lookqixiang");
            }
            public DataSet searchqixiang(int index, int flag, ref string size, string accord)
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
                DataSet ds = db.RunSelectTable(p, "nongyeqixiang.searchqixiang");////暂时未提交
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            
        }
        public class DCWJXuanXiang
        {
            public DataSet selecttitle(int index, ref string sizes)
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
                DataSet ds = db.RunSelectTable(p, "dcwj.selectdcwjxx_by_id");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                sizes = (q.ToString());
                return ds;
            }
            public DataSet selectdcwjxuanxiang(int index,int titleid, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_index",OracleDbType.Int32),
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("p_size",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = titleid;
                p[2].Direction = ParameterDirection.Output;
                p[3].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "dcwjxuanxiang.selectdcwjxuanxiang");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchdcwjxuanxiang(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "dcwjxuanxiang.searchdcwjxuanxiang");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet getTitle(int titleid)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("titleid",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = titleid;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "dcwjxuanxiang.selectforchangetitle");
            }

            public DataSet searchdcwjxuanxiang2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "dcwjxuanxiang.searchdcwjxuanxiang2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void deletedcwjxuanxiang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "dcwjxuanxiang.deletedcwjxuanxiang");
            }
            public DataSet lookdcwjxuanxiang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "dcwjxuanxiang.lookdcwjxuanxiang");
            }
            public DataSet selectforchangedcwjxuanxiang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "dcwjxuanxiang.selectforchangedcwjxuanxiang");
            }
            public void updatedcwjxuanxiang(int dcwjxuanxiangid, string content,string updata_time, int quanzhong)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
                new OracleParameter("p_quanzhong",OracleDbType.Int32)
                
            };
                p[0].Value = dcwjxuanxiangid;
                p[1].Value = content;
                p[2].Value = updata_time;
                p[3].Value = quanzhong;
                db.RunInsertOrUpdateOrSelectString(p, "dcwjxuanxiang.updatedcwjxuanxiang");
            }
            public void insertdcwjxuanxiang(string content, string updata_time, int quanzhong, int wid)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
                new OracleParameter("p_quanzhong",OracleDbType.Int32),
                new OracleParameter("p_dcwj_id",OracleDbType.Int32)
            };
                p[0].Value = content;
                p[1].Value = updata_time;
                p[2].Value = quanzhong;
                p[3].Value = wid; 
                db.RunInsertOrUpdateOrSelectString(p, "dcwjxuanxiang.insertdcwjxuanxiang");

            }
        }
        public class LiangShi
        {
            public DataSet selectliangshi(int index, ref string size)
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
            public DataSet searchliangshi(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "liangshi.search_liangshi");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchliangshi2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "liangshi.search_liangshi2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void deleteliangshi(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "liangshi.delete_liangshi");
            }
            public DataSet lookliangshi(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "liangshi.look_liangshi");
            }
            public DataSet selectforchangeliangshi(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "liangshi.select_change_liangshi");
            }
            public void updateliangshi(string liangshiid, string type, string title, string keyword, string content, /*string file,*/ string updata_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Varchar2),
                    new OracleParameter("p_leixing",OracleDbType.Varchar2),
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("p_keyword",OracleDbType.Varchar2),
                    new OracleParameter("p_content",OracleDbType.Clob),
                    //new OracleParameter("p_file",OracleDbType.Varchar2),
                    new OracleParameter("p_update_time",OracleDbType.Varchar2)
                
                };
                p[0].Value = liangshiid;
                p[1].Value = type;
                p[2].Value = title;
                p[3].Value = keyword;
                p[4].Value = content;
                //p[5].Value = file;
                p[5].Value = updata_time;
                db.RunInsertOrUpdateOrSelectString(p, "liangshi.update_liangshi");
            }
            public void insertliangshi(string type, string title, string keyword, string content, string updata_time, string zh/*, string file*/)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                 new OracleParameter("p_leixing",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_upload_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2),
               
                //new OracleParameter("p_file",OracleDbType.Varchar2)
               // new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = type;
                p[1].Value = title;
                p[2].Value = keyword;
                p[3].Value = content;
                p[4].Value = updata_time;
                p[5].Value = zh;
                //p[6].Value = file;
                db.RunInsertOrUpdateOrSelectString(p, "liangshi.insert_liangshi");

            }
        }
        public class ShuCai
        {
            //该函数接受一个int类型索引值和一个参数size
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
                //一个页面显示八条信息
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;

                size = (q.ToString());
                return ds;
            }
            public DataSet searchshucai(string accord, int flag, int index, ref string size)
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
                DataSet ds = db.RunSelectTable(p, "shucai.searchshucai");
                //一页八条数据
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());

                return ds;
            }
            public DataSet searchshucai2(string accord, int flag, int index, ref string size)
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
                //对p的数据进行填充
                p[0].Value = ((index - 1) * 8 + 1);
                p[1].Value = flag;
                p[2].Direction = ParameterDirection.Output;
                p[3].Value = accord;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "shucai.searchshucai2");

                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void deleteshucai(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id", OracleDbType.Int32)
                };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "shucai.deleteshucai");
            }
            public DataSet lookshucai(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id", OracleDbType.Int32),
                    new OracleParameter("mycur", OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "shucai.lookshucai");
            }
            public DataSet selectforchangeshucai(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "shucai.selectforchangeshucai");
            }
            public void updateshucai(int shucaiid, string title, string type, string content, string keyword, string updata_time, string author)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_type", OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
              //  new OracleParameter("p_path", OracleDbType.Varchar2)
            };
                p[0].Value = shucaiid;
                p[1].Value = title;
                p[2].Value = type;
                p[3].Value = keyword;
                p[4].Value = content;
                p[5].Value = updata_time;
                //   p[6].Value = path;
                db.RunInsertOrUpdateOrSelectString(p, "shucai.updateshucai");
            }
            public void insertshucai(string title, string type, string keyword, string content, string updata_time, string zh)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_updata_time",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2),
                //new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = type;
                p[2].Value = keyword;
                p[3].Value = content;
                p[4].Value = updata_time;
                p[5].Value = zh;
                // p[6].Value = path;
                db.RunInsertOrUpdateOrSelectString(p, "shucai.insertshucai");
            }
        }
        public class Login
        {
            public string login(string zh, string mm)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_zh",OracleDbType.Varchar2),
                new OracleParameter("p_mm",OracleDbType.Varchar2),
                new OracleParameter("p_flag",OracleDbType.Int32)
            };
                p[0].Value = zh;
                p[1].Value = mm;
                p[2].Direction = ParameterDirection.Output;
                db.RunInsertOrUpdateOrSelectString(p, "Login.login");
                return p[2].Value.ToString();
            }
            public string getType(string zh)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_zh",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Int32)
            };
                p[0].Value = zh;
                p[1].Direction = ParameterDirection.Output;
                db.RunInsertOrUpdateOrSelectString(p, "Login.get_type");
                return p[1].Value.ToString();
            }
           
        }
        public class ZiXun
        {
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
            public DataSet searchzixun(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "zixun.searchzixun");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchzixun2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "zixun.searchzixun2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void deletezixun(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "zixun.deletezixun");
            }
            public DataSet lookzixun(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "zixun.lookzixun");
            }
            public DataSet selectforchangezixun(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "zixun.selectforchangezixun");
            }
            public void updatezixun(string zixunid, string title, string keyword, string type, string content, string updata_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2)
                
            };
                p[0].Value = zixunid;
                p[1].Value = title;
                p[2].Value = type;
                p[3].Value = content;
                p[4].Value = keyword;
                p[5].Value = updata_time;
                db.RunInsertOrUpdateOrSelectString(p, "zixun.updatezixun");
            }
            public void insertzixun(string title, string keyword, string type, string content, string updata_time, string zh)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                //new OracleParameter("p_upload_time",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2)
               // new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = type;
                p[2].Value = keyword;
                p[3].Value = content;
                p[4].Value = updata_time;
                p[5].Value = zh;
                db.RunInsertOrUpdateOrSelectString(p, "zixun.insertzixun");

            }
        }
        public class ZhuanJia
        {

            public DataSet selectzhuanjia(int index, ref string size)
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
            public DataSet searchzhuanjia(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "zhuanjia.searchzhuanjia");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchzhuanjia2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "zhuanjia.searchzhuanjia2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet lookzhuanjia(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "zhuanjia.lookzhuanjia");
            }
            public void deletezhuanjia(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "zhuanjia.deletezhuanjia");
            }
            public DataSet selectforchangezhuanjia(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "zhuanjia.selectforchangezhuanjia");
            }
            public void updatezhuanjia(string zixunid, string title, string keyword, string content, string updata_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2)
                
            };
                p[0].Value = zixunid;
                p[1].Value = title;
                p[2].Value = content;
                p[3].Value = keyword;
                p[4].Value = updata_time;
                db.RunInsertOrUpdateOrSelectString(p, "zhuanjia.updatezhuanjia");
            }
            public void insertzhuanjia(string title, string keyword, string content, string updata_time, string zh)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                //new OracleParameter("p_type",OracleDbType.Int32),
                new OracleParameter("p_content",OracleDbType.Clob),
                //new OracleParameter("p_upload_time",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2)
               // new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = keyword;
                p[2].Value = content;
                p[3].Value = updata_time;
                p[4].Value = zh;
                db.RunInsertOrUpdateOrSelectString(p, "zhuanjia.insertzhuanjia");

            }
        }
        public class JiaGe
        {
            public DataSet selectjiage(int index, ref string size)
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
                DataSet ds = db.RunSelectTable(p, "jiage.selectjiage");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchjiage(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "jiage.searchjiage");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchjiage2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "jiage.searchjiage2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet lookjiage(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "jiage.lookjiage");
            }
            public void deletejiage(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "jiage.deletejiage");
            }
            public DataSet selectforchangejiage(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "jiage.selectforchangejiage");
            }
            public void updatejiage(string jiageid, string title, string keyword, string content, string updata_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2)
                
            };
                p[0].Value = jiageid;
                p[1].Value = title;
                p[2].Value = content;
                p[3].Value = keyword;
                p[4].Value = updata_time;
                db.RunInsertOrUpdateOrSelectString(p, "jiage.updatejiage");
            }
            public void insertjiage(string title, string keyword, string content, string updata_time, string zh)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                //new OracleParameter("p_type",OracleDbType.Int32),
                new OracleParameter("p_content",OracleDbType.Clob),
                //new OracleParameter("p_upload_time",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2)
               // new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = keyword;
                p[2].Value = content;
                p[3].Value = updata_time;
                p[4].Value = zh;
                db.RunInsertOrUpdateOrSelectString(p, "jiage.insertjiage");

            }  
        }
        public class ShiChang
        {
            public DataSet selectshichang(int index, ref string size)
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
                DataSet ds = db.RunSelectTable(p, "shichang.selectshichang");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchshichang(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "shichang.searchshichang");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchshichang2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "shichang.searchshichang2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet lookshichang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "shichang.lookshichang");
            }
            public void deleteshichang(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "shichang.deleteshichang");
            }
            public DataSet selectforchangeshichang(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "shichang.selectforchangeshichang");
            }
            public void updateshichang(string jianceid, string title, string keyword, string content, string updata_time,string type)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2)
                
            };
                p[0].Value = jianceid;
                p[1].Value = title;
                p[2].Value = content;
                p[3].Value = keyword;
                p[4].Value = updata_time;
                p[5].Value = type;
                db.RunInsertOrUpdateOrSelectString(p, "jiance.updatejiance");
            }
            public void insertshichang(string title, string keyword, string content, string updata_time, string zh,string type)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                //new OracleParameter("p_type",OracleDbType.Int32),
                new OracleParameter("p_content",OracleDbType.Clob),
                //new OracleParameter("p_upload_time",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2),
               // new OracleParameter("p_img",OracleDbType.Varchar2)
               new OracleParameter("p_type",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = keyword;
                p[2].Value = content;
                p[3].Value = updata_time;
                p[4].Value = zh;
                p[5].Value = type;
                db.RunInsertOrUpdateOrSelectString(p, "shichang.insertshichang");

            }  
        }
        public class JianCe
        {
            public DataSet selectjiance(int index, ref string size)
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
            public DataSet searchjiance(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "jiance.searchjiance");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchjiance2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "jiance.searchjiance2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void deletejiance(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "jiance.deletejiance");
            }
            public DataSet lookjiance(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "jiance.lookjiance");
            }
            public DataSet selectforchangejiance(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "jiance.selectchangejiance");
            }
            public void updatejiance(string jianceid, string type, string title, string keyword, string content,/* string file,*/ string updata_time,string zhouqi)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Varchar2),
                    new OracleParameter("p_leixing",OracleDbType.Varchar2),
                    new OracleParameter("p_title",OracleDbType.Varchar2),
                    new OracleParameter("p_keyword",OracleDbType.Varchar2),
                    new OracleParameter("p_content",OracleDbType.Clob),
                    //new OracleParameter("p_file",OracleDbType.Varchar2),
                    new OracleParameter("p_update_time",OracleDbType.Varchar2),
                    new OracleParameter("p_zhouqi",OracleDbType.Varchar2)

                };
                p[0].Value = jianceid;
                p[1].Value = type;
                p[2].Value = title;
                p[3].Value = keyword;
                p[4].Value = content;
                //p[5].Value = file;
                p[5].Value = updata_time;
                p[6].Value = zhouqi;
                db.RunInsertOrUpdateOrSelectString(p, "jiance.updatejiance");
            }
            public void insertjiance(string type, string title, string keyword, string content, string updata_time, string zh, /*string file,*/string zhouqi)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                 new OracleParameter("p_leixing",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_upload_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2),

                //new OracleParameter("p_file",OracleDbType.Varchar2),
               // new OracleParameter("p_img",OracleDbType.Varchar2)
               new OracleParameter("p_zhouqi",OracleDbType.Varchar2)
            };
                p[0].Value = type;
                p[1].Value = title;
                p[2].Value = keyword;
                p[3].Value = content;
                p[4].Value = updata_time;
                p[5].Value = zh;
                //p[6].Value = file;
                p[6].Value = zhouqi;
                db.RunInsertOrUpdateOrSelectString(p, "jiance.insertjiance");

            }
        }
        public class NongZi
        {
            public DataSet selectforchangenongzi(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "nongzi.selectforchangenongzi");
            }
            public DataSet searchnongzi(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "nongzi.searchnongzi");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchnongzi2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "nongzi.searchnongzi2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet looknongzi(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "nongzi.looknongzi");
            }
            public void deletenongzi(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "nongzi.deletenongzi");
            }
            public void insertnongzi(string title, string keyword, string content, string updata_time, string zh, string type)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                //new OracleParameter("p_upload_time",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2)
               // new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = keyword;
                p[2].Value = content;
                p[3].Value = updata_time;
                p[4].Value = zh;
                p[5].Value = type;
                db.RunInsertOrUpdateOrSelectString(p, "nongzi.insertnongzi");

            }
            public void updatenongzi(string nongziid, string title, string keyword, string content, string updata_time, string type)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2)

            };
                p[0].Value = nongziid;
                p[1].Value = title;
                p[2].Value = content;
                p[3].Value = keyword;
                p[4].Value = updata_time;
                p[5].Value = type;
                db.RunInsertOrUpdateOrSelectString(p, "nongzi.updatenongzi");
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
        }
        public class DCWJ
        {
            public DataSet selectdcwj(int index, ref string size)
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
                DataSet ds = db.RunSelectTable(p, "dcwj.selectdcwj");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public void insertdcwj(string title, string describe, string result, string update_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                //new OracleParameter("p_keyword",OracleDbType.Varchar2),
                //new OracleParameter("p_type",OracleDbType.Int32),
                new OracleParameter("p_describe",OracleDbType.Clob),
                new OracleParameter("p_result",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
               // new OracleParameter("p_link",OracleDbType.Varchar2),
                //new OracleParameter("p_zh",OracleDbType.Varchar2)
               // new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = describe;
                p[2].Value = result;
                p[3].Value = update_time;
                db.RunInsertOrUpdateOrSelectString(p, "dcwj.insertdcwj");

            }
            public DataSet lookdcwj(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "dcwj.lookdcwj");
            }
            public void updatedcwj(string dcwjid, string title, string describe, string result, string update_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_describe",OracleDbType.Clob),
                new OracleParameter("p_result",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2)

            };
                p[0].Value = dcwjid;
                p[1].Value = title;
                p[2].Value = describe;
                p[3].Value = result;
                p[4].Value = update_time;
                db.RunInsertOrUpdateOrSelectString(p, "dcwj.updatedcwj");
            }
            public void deletedcwj(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter(" p_id",OracleDbType.Int32)
            };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "dcwj.deletedcwj");
            }
            public DataSet searchdcwj(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "dcwj.searchdcwj");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectforchangedcwj(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "dcwj.selectforchangedcwj");
            }
        }
        public class FenXi
        {
            public DataSet selectfenxi(int index, ref string size)
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
            public void deletefenxi(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id", OracleDbType.Int32)
                };
                p[0].Value = id;
                db.RunInsertOrUpdateOrSelectString(p, "fenxiyujing.deletefenxi");
            }
            public DataSet lookfenxi(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "fenxiyujing.lookfenxi");
            }
            public void insertfenxi(string title,string type, string keyword, string content, string update_time, string zh)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                
                new OracleParameter("p_content",OracleDbType.Clob),
                //new OracleParameter("p_upload_time",OracleDbType.Varchar2),
                new OracleParameter("p_update_time",OracleDbType.Varchar2),
                //new OracleParameter("p_link",OracleDbType.Varchar2),
                new OracleParameter("p_zh",OracleDbType.Varchar2),
                //new OracleParameter("p_img",OracleDbType.Varchar2)
            };
                p[0].Value = title;
                p[1].Value = type;
                p[2].Value = keyword;
                p[3].Value = content;
                p[4].Value = update_time;
                p[5].Value = zh;
                db.RunInsertOrUpdateOrSelectString(p, "fenxiyujing.insertfenxi");
            }
            public DataSet selectforchangefenxi(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "fenxiyujing.selectforchangefenxi");
            }
            public void updatefenxi(string fenxiid, string title, string type,string keyword, string content, string updata_time)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                
                new OracleParameter("p_update_time",OracleDbType.Varchar2)
                
            };
                p[0].Value = fenxiid;
                p[1].Value = title;
                p[2].Value = type;
                p[3].Value = keyword;
                p[4].Value = content;

                p[5].Value = updata_time;
                db.RunInsertOrUpdateOrSelectString(p, "fenxiyujing.updatefenxi");
            }
            public DataSet searchfenxi(string accord, int flag, int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_accord", OracleDbType.Varchar2),
                    new OracleParameter("p_flag", OracleDbType.Int32),
                    new OracleParameter("p_index", OracleDbType.Int32),
                    new OracleParameter("p_size", OracleDbType.Int32),
                    new OracleParameter("mycur", OracleDbType.RefCursor)
                };
                p[0].Value = accord;
                p[1].Value = flag;
                p[2].Value = ((index - 1) * 8 + 1);
                p[3].Direction = ParameterDirection.Output;
                p[4].Direction = ParameterDirection.Output;

                DataSet ds = db.RunSelectTable(p, "fenxiyujing.searchfenxi");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchfenxi2(string accord, int flag, int index, ref string size)
            {
                DbClass db = new DbClass();
                OracleParameter[] p = 
                {
                    new OracleParameter("p_accord", OracleDbType.Varchar2),
                    new OracleParameter("p_flag", OracleDbType.Int32),
                    new OracleParameter("p_index", OracleDbType.Int32),
                    new OracleParameter("p_size", OracleDbType.Int32),
                    new OracleParameter("mycur", OracleDbType.RefCursor)
                };
                p[0].Value = accord;
                p[1].Value = flag;
                p[2].Value = ((index - 1) * 8 + 1);
                p[3].Direction = ParameterDirection.Output;
                p[4].Direction = ParameterDirection.Output;
                DataSet ds = db.RunSelectTable(p, "fenxiyujing.searchfenxi2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
        }
        public class User
        {
            public string checkname(string name)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_zh",OracleDbType.Varchar2),
                new OracleParameter("p_flag",OracleDbType.Int32)
            };
                p[0].Value = name;
                p[1].Direction = ParameterDirection.Output;
                db.RunInsertOrUpdateOrSelectString(p, "user_s.checkname");
                return p[1].Value.ToString();
            }
            public void insertuser(string name, string password, string realname, string phone,string time )
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_name",OracleDbType.Varchar2),
                new OracleParameter("p_password",OracleDbType.Varchar2),
                new OracleParameter("p_realname",OracleDbType.Varchar2),
                 new OracleParameter("p_phone",OracleDbType.Varchar2),
                new OracleParameter("p_time",OracleDbType.Varchar2)
            };
                p[0].Value = name;
                p[1].Value = password;
                p[2].Value = realname;
                p[3].Value = phone;
                p[4].Value = time;
                db.RunInsertOrUpdateOrSelectString(p, "user_s.insertuser");
            }  
            public DataSet selectuser(int index,ref string size)
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
                DataSet ds = db.RunSelectTable(p, "user_s.selectuser");
                int q = int.Parse(p[1].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;

            }
            public DataSet searchuser(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "user_s.searchuser");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet searchuser2(string accord, int flag, int index, ref string size)//flag=0表示type检索 1表示keyword检索
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
                DataSet ds = db.RunSelectTable(p, "user_s.searchuser2");
                int q = int.Parse(p[2].Value.ToString());
                if (q % 8 != 0)
                    q = (q / 8) + 1;
                else
                    q = q / 8;
                size = (q.ToString());
                return ds;
            }
            public DataSet selectforchangeuser(string id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Int32),
                new OracleParameter("mycur",OracleDbType.RefCursor)
            };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;
                return db.RunSelectTable(p, "user_s.selectforchangeuser");
            }
            public void updateuser(string userid, string name, string time, string content,string type,string realname,string phone)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
            {
                new OracleParameter("p_id",OracleDbType.Varchar2),
                new OracleParameter("p_title",OracleDbType.Varchar2),
                new OracleParameter("p_content",OracleDbType.Clob),
                new OracleParameter("p_keyword",OracleDbType.Varchar2),
                new OracleParameter("p_type",OracleDbType.Varchar2),
                new OracleParameter("p_realname",OracleDbType.Varchar2),
                new OracleParameter("p_phone",OracleDbType.Varchar2)
            };
                p[0].Value = userid;
                p[1].Value = name;
                p[2].Value = content;
                p[3].Value = time;
                p[4].Value = type;
                p[5].Value = realname;
                p[6].Value = phone;
                db.RunInsertOrUpdateOrSelectString(p, "user_s.updateuser");
            }
            public DataSet lookuser(int id)
            {
                DbClass db = new DbClass();
                OracleParameter[] p =
                {
                    new OracleParameter("p_id",OracleDbType.Int32),
                    new OracleParameter("mycur",OracleDbType.RefCursor)
                };
                p[0].Value = id;
                p[1].Direction = ParameterDirection.Output;

                return db.RunSelectTable(p, "user_s.lookuser");
            }

        }

    }
}