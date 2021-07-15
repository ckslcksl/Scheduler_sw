using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Util
{
    public static class MpInputCSVUtil
    {

        public static DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(strFilePath))
            {
                string[] headers = sr.ReadLine().Split(',');

                foreach (string header in headers)
                {
                    switch (header)
                    {
                        case "BUCKET":
                            dt.Columns.Add(header, typeof(int)).DefaultValue = 0;
                            break;
                        case "DEMAND":
                            if (strFilePath.IndexOf("PSI") >= 0)
                            {
                                dt.Columns.Add(header, typeof(double)).DefaultValue = 0;
                            }
                            else
                            {
                                dt.Columns.Add(header, typeof(String));
                            }
                            break;
                        case "PRODUCTION":
                            dt.Columns.Add(header, typeof(double)).DefaultValue = 0;
                            break;
                        case "SUPPLY":
                            dt.Columns.Add(header, typeof(double)).DefaultValue = 0;
                            break;
                        case "INVENTORY":
                            dt.Columns.Add(header, typeof(double)).DefaultValue = 0;
                            break;
                        case "INIT_INVENTORY":
                            dt.Columns.Add(header, typeof(double)).DefaultValue = 0;
                            break;
                        default:
                            if (header.EndsWith("DATE"))
                            {
                                dt.Columns.Add(header, typeof(DateTime)).DefaultValue = null;
                            }
                            else if (header.EndsWith("SIZE"))
                            {
                                dt.Columns.Add(header, typeof(int)).DefaultValue = 0;
                            }
                            else if (header.EndsWith("_F"))
                            {
                                dt.Columns.Add(header, typeof(double)).DefaultValue = 0;
                            }
                            else
                            {
                                dt.Columns.Add(header, typeof(String)).DefaultValue = "" ;
                            }
                            break;

                    }

                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        try
                        {
                            switch (dt.Columns[i].DataType.Name)
                            {
                                case "String":
                                    dr[i] = rows[i];
                                    break;
                                case "Int32":
                                    dr[i] = rows[i] == "" ? "0" : rows[i];
                                    break;
                                case "Int64":
                                    dr[i] = rows[i] == "" ? "0" : rows[i];
                                    break;
                                case "Double":
                                    dr[i] = rows[i] == "" ? "0" : rows[i];
                                    break;
                                case "DateTime":
                                    dr[i] = rows[i] == "" ? "2099-12-31" : rows[i];
                                    break;
                                default:
                                    dr[i] = rows[i];
                                    break;
                            }

                        }
                        catch (Exception) { }
                    }
                    dt.Rows.Add(dr);
                }

            }


            return dt;
        }



        public static void ConvertDataTableToCsv(string strFilePath, DataTable dtDataTable)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers    
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(","))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }


    }
}
