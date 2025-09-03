using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using quizz.Models;

namespace quizz.Data
{
   

    public static class Db
    {
        private static string _conn = @"Data Source=localhost\sqlexpress;Initial Catalog=quizz;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
       


        // Voeg dit toe:
        public static string ConnectionString
        {
            get { return _conn; }
        }

        public static DataTable ExecuteSelect(string sql, params SqlParameter[] pars)
        {
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (pars != null) cmd.Parameters.AddRange(pars);
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] pars)
        {
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (pars != null) cmd.Parameters.AddRange(pars);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string sql, params SqlParameter[] pars)
        {
            using (var conn = new SqlConnection(_conn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                if (pars != null) cmd.Parameters.AddRange(pars);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }
    }
}
