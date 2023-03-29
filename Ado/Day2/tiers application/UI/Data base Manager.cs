using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Reflection.Metadata;
using System.Configuration;
using System.Reflection;

namespace UI
{
    public class Data_base_Manager
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Data_base_Manager()
        {
            conn=new SqlConnection();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["pubs"].ConnectionString;
            cmd= new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection= conn;
            adapter= new SqlDataAdapter(cmd);
            dt=new DataTable();
        }

        public int executeNonQuery(string sp)
        {
            try
            {
                if(conn.State!= ConnectionState.Open)
                conn.Open();
               cmd.Parameters.Clear();
               cmd.CommandText= sp;
               return cmd.ExecuteNonQuery();
            }
            catch 
            { 
                return-1;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public int executeNonQuery(string sp,Dictionary<string,object> dic)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                cmd.Parameters.Clear();
                cmd.CommandText = sp;

                foreach (var i in dic)
                    cmd.Parameters.Add(new SqlParameter(i.Key, i.Value));

                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return -1;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public object excuteScalar (string sp) 
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = sp;
                return cmd.ExecuteScalar();
            }
            catch
            {
                return new();
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }

        public object excuteScalar(string sp, Dictionary<string, object> dic)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                cmd.Parameters.Clear();
                cmd.CommandText = sp;

                foreach (var i in dic)
                    cmd.Parameters.Add(new SqlParameter(i.Key, i.Value));

                return cmd.ExecuteScalar();
            }
            catch
            {
                return new();
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }
        }



        public DataTable excuteDatatTable(string sp) 
        { 
            try
            {
                cmd.Parameters.Clear();
                dt.Clear();
                cmd.CommandText= sp;

                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return new();
            }
        }

        public DataTable excuteDatatTable(string sp, Dictionary<string, object> dic)
        {
            try
            {
                cmd.Parameters.Clear();
                dt.Clear();

                foreach (var i in dic)
                    cmd.Parameters.Add(new SqlParameter(i.Key, i.Value));

                cmd.CommandText = sp;
                adapter.Fill(dt);
                return dt;
            }
            catch
            {
                return new();
            }
        }
    }
}