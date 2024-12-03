using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    internal class Dataprovider
    {
        private string connectionString = "Data Source=DESKTOP-HM13SQP\\SQLEXPRESS;Initial Catalog=QLSVDemo;Integrated Security=True;Encrypt=False";

        public DataTable executeQuery(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(sql,sqlConnection))
                {

                    if (sqlParameters != null)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;
        }
        public int executeNonQuery(string sql, SqlParameter[] sqlParameters = null)
        {
            int row = -1;
                SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {

                    if (sqlParameters != null)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    row = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
            return row;
        }
        public object ExecuteScalar(string sql, SqlParameter[] sqlParameters)
        {
                SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {

                    if (sqlParameters != null)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                     return cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlConnection.Close(); }
            return null;
        }

    }
}
