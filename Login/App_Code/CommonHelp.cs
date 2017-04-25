using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



public class CommonHelp
{
    public CommonHelp()
    {
         
    }

    public static string ConnectionString { get { return System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString; } }

    
 
    
    public static DataSet GetDataSetBySql(string sql) {
        
        using (SqlConnection conn = new SqlConnection(ConnectionString)) { 
                 DataSet ds = new DataSet();
                try
                {
                    conn.Open();
                    SqlDataAdapter command = new SqlDataAdapter(sql, conn);
                    command.Fill(ds, "ds");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
        }
    }

    public static string getIP()
    {
        System.Web.HttpRequest request = System.Web.HttpContext.Current.Request;
        string result = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
        if (string.IsNullOrEmpty(result)) { result = request.ServerVariables["REMOTE_ADDR"]; }
        if (string.IsNullOrEmpty(result)) { result = request.UserHostAddress; }
        if (string.IsNullOrEmpty(result)) { result = "0.0.0.0"; }
        return result;
    }
}

