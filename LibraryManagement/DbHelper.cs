using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public static class MemberID
    {
        public static int memberId { get; set; }
        public static string memberName { get; set; }
    }
    public class Result
    {
        public bool HasError {  get; set; }
        public string Message {  get; set; }
        public DataTable Data { get; set; }
    }
    internal class DbHelper
    {
       public static SqlConnection conn = new SqlConnection("Data Source=LAPTOP-V3VO6V5Q\\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True;TrustServerCertificate=True;");
        public static Result GetResult(string query)
        {
            var result = new Result();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                result.Data = ds.Tables[0];
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message;
            }
            finally
            {
               conn.Close();
            }
            return result; 
        }
        public static Result ExecuteNonResultQuery(string query)
        {
            var result = new Result();
           try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                result.HasError = true;
                result.Message = ex.Message; 
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
