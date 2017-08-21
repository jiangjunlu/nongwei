using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Data;
using Microsoft.JScript;

namespace NWadmin
{
    public class JsonTool
    {
        public static string stringtoJson(string flag)
        {
            StringBuilder strbody = new StringBuilder();
            strbody.Append("");
            return "";
        }
        public static string DataTableToJson(string code, DataTable dt)
        {
            
            StringBuilder Json = new StringBuilder();
            
            Json.Append("{\"" + "body" + "\":[");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Json.Append("{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Json.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":\"" + Microsoft.JScript.GlobalObject.escape(dt.Rows[i][j].ToString()) + "\"");
                        if (j < dt.Columns.Count - 1)
                        {
                            Json.Append(",");
                        }
                    }
                    Json.Append("}");
                    if (i < dt.Rows.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("],\"code\":\"" + code + "\"}");
            return Json.ToString();
        }
    }
}