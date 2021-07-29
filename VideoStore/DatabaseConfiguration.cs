using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public abstract class DatabaseConfiguration
    {
        protected string DBString = @"Data Source=.\SQLEXPRESS;Initial Catalog=videostore;Integrated Security=True;";

        public DatabaseConfiguration()
        {
            if (!CheckDB())
            {
                GenerateDB();
            }
        }


        private bool CheckDB()
        {
            SqlConnection con = new SqlConnection(DBString);
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void GenerateDB()
        {
            SqlConnection cn;
            SqlCommand cm;
            try
            {
                string script = null;
                script = VideoStore.Properties.Resources.backup;
                string[] ScriptSplitter = script.Split(new string[] { "GO" }, StringSplitOptions.None);
                using (cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True"))
                {
                    cn.Open();
                    foreach (string str in ScriptSplitter)
                    {
                        using (cm = cn.CreateCommand())
                        {
                            cm.CommandText = str;
                            cm.ExecuteNonQuery();
                        }
                    }
                }
                cn.Close();
            }
            catch(Exception ex)
            {

            }

        }
    }
}
