using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class DataOperation : DatabaseConfiguration
    {
        private SqlConnection conn;

        public DataOperation()
        {
            conn = new SqlConnection(DBString);
            conn.Open();
        }

        // Function to check Current Connection State
        public bool CheckState()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        // Function to close the Opened Connection
        public void CloseConnection()
        {
            if (CheckState())
            {
                conn.Close();
                conn.Dispose();
            }
        }

        // Function to Save Genre Details
        public bool AddNewGenreDetails(string genre_name)
        {
            try
            {
                string query = "insert into genres(genre_name) values(@genre_name)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@genre_name", genre_name));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Update Genre Details
        public bool UpdateGenreDetails(int genre_id, string genre_name)
        {
            try
            {
                string query = "update genres set genre_name=@genre_name where genre_id = @genre_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@genre_name", genre_name));
                cmd.Parameters.Add(new SqlParameter("@genre_id", genre_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Delete Genre Details
        public bool DeleteGenreDetails(int genre_id)
        {
            try
            {
                string query = "delete from genres where genre_id = @genre_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@genre_id", genre_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Get All Genre Details
        public DataSet GetAllGenresDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from genres";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        // Function to Get Genre Details in Form of Data Table
        public DataTable GetGenresDataTable()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from genres ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Genre" };
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
        
        // Function to Save Movie Details
        public bool AddNewMovieDetails(string title, float rating, int release_year, int genre_id, float rental_cost)
        {
            try
            {
                string query = "insert into movies(title,rating,release_year,genre_id,rental_cost) values(@title,@rating,@release_year,@genre_id,@rental_cost)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@rating", rating));
                cmd.Parameters.Add(new SqlParameter("@release_year", release_year));
                cmd.Parameters.Add(new SqlParameter("@genre_id", genre_id));
                cmd.Parameters.Add(new SqlParameter("@rental_cost", rental_cost));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Update Movie Details
        public bool UpdateMovieDetails(int movie_id, string title, float rating, int release_year, int genre_id, float rental_cost)
        {
            try
            {
                string query = "update movies set title=@title,rating=@rating,release_year=@release_year,genre_id=@genre_id,rental_cost=@rental_cost where movie_id = @movie_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@title", title));
                cmd.Parameters.Add(new SqlParameter("@rating", rating));
                cmd.Parameters.Add(new SqlParameter("@release_year", release_year));
                cmd.Parameters.Add(new SqlParameter("@genre_id", genre_id));
                cmd.Parameters.Add(new SqlParameter("@rental_cost", rental_cost));
                cmd.Parameters.Add(new SqlParameter("@movie_id", movie_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Delete Movie Details
        public bool DeleteMovieDetails (int movie_id)
        {
            try
            {
                string query = "delete from movies where movie_id = @movie_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@movie_id", movie_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Get All Movie Details
        public DataSet GetAllMovieDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select movie_id,title,rating,rental_cost,release_year,copies,plot,genre_name from movies m join genres g ";
                query += " on m.genre_id = g.genre_id";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        // Function to Get Movie Genre ID using movie ID
        public int GetMovieGenreID(int movie_id)
        {
            int genre_id = 0;
            try
            {
                string query = "select genre_id from movies where movie_id = @movie_id";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@movie_id", movie_id));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                genre_id = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
            }
            return genre_id;
        }

        // // Function to Get Movie Rent Details using movie ID
        public float GetMovieRentDetails(int movie_id)
        {
            float rental_cost = 0;
            try
            {
                string query = "select rental_cost from movies where movie_id = @movie_id";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@movie_id", movie_id));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    rental_cost = float.Parse(reader[0].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
            }
            return rental_cost;
        }

        // Function to Add New Customer Details
        public bool AddNewCustomer(string first_name, string last_name, string address, string phone_no)
        {
            try
            {
                string query = "insert into customer(first_name,last_name,address,phone_no) values(@first_name,@last_name,@address,@phone_no)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@first_name", first_name));
                cmd.Parameters.Add(new SqlParameter("@last_name", last_name));
                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@phone_no", phone_no));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Update Customer Details
        public bool UpdateCustomerDetails(int cust_id, string first_name, string last_name, string address, string phone_no)
        {
            try
            {
                string query = "update customer set first_name=@first_name,last_name=@last_name,address=@address,phone_no=@phone_no  where cust_id = @cust_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@first_name", first_name));
                cmd.Parameters.Add(new SqlParameter("@last_name", last_name));
                cmd.Parameters.Add(new SqlParameter("@address", address));
                cmd.Parameters.Add(new SqlParameter("@phone_no", phone_no));
                cmd.Parameters.Add(new SqlParameter("@cust_id", cust_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Delete Customer Details
        public bool DeleteCustomerDetails (int cust_id)
        {
            try
            {
                string query = "delete from customer where cust_id = @cust_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@cust_id", cust_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Get All Customer Details in Form of Data Set
        public DataSet GetAllCustomerDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "select * from customer";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        // Function to Get All Customer Details in Form of Data table
        public DataTable ViewAllCustomerDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from viewAllCustomer ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Customer" };
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        // Function to Get All Movie Details in Form of Data table
        public DataTable ViewAllMovieDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "select * from viewAllMovie ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select Movie" };
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception ex)
            {
            }
            return dt;
        }

        // Function to Issue Movie To Customer
        public bool IssueMovieToCustomer(int movie_id, int cust_id, float rented_cost, DateTime date_rented)
        {
            try
            {
                string query = "insert into rented_movies(movie_id,cust_id,rented_cost,date_rented,date_returned) values(@movie_id,@cust_id,@rented_cost,@date_rented,null)";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@movie_id", movie_id));
                cmd.Parameters.Add(new SqlParameter("@cust_id", cust_id));
                cmd.Parameters.Add(new SqlParameter("@rented_cost", rented_cost));
                cmd.Parameters.Add(new SqlParameter("@date_rented", date_rented));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function to Get All Rented Movie Details
        public DataSet GetRentedMovieDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "procDisplayRentedMovies";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        // Function to Get All Rented Movie Details which are Currently Rented 
        public DataSet GetRentedOutMovieDetails()
        {
            DataSet ds = new DataSet();
            try
            {
                string query = "procDisplayRentedOutMovies";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
        
        // Function to Return Movie to Video Store
        public bool ReturnMovie(int rent_id, DateTime date_returned)
        {
            try
            {
                string query = "update rented_movies set date_returned = @date_returned where rent_id = @rent_id";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@date_returned", date_returned));
                cmd.Parameters.Add(new SqlParameter("@rent_id", rent_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Function Delete Rented Details
        public bool DeleteRentalDetails(int rent_id)
        {
            try
            {
                string query = "delete from rented_movies where rent_id = @rent_id ";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add(new SqlParameter("@rent_id", rent_id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
