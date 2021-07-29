using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStore
{
    public partial class MainForm : Form
    {
        private DataOperation operation;
        DataTable genreTable;
        int genre_id;
        DataTable customerTable;
        int cust_id;
        DataTable MovieTable;
        int movie_id;
        DataTable RentTable;
        int rent_id;
        public MainForm()
        {
            InitializeComponent();
            operation = new DataOperation();
            ShowGenreTab();
        }

        private void ShowGenreTab()
        {
            btnUpdateGenre.Enabled = false;
            btnDeleteGenre.Enabled = false;            
            genreTable = new DataTable();
            genreTable.Columns.Add("Genre ID");
            genreTable.Columns.Add("Genre Name");
            LoadGenreGrid();
        }

        private void LoadGenreGrid()
        {
            genreTable.Clear();
            DataSet dataset = operation.GetAllGenresDetails();
            if(dataset.Tables.Count>0)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    genreTable.Rows.Add(row["genre_id"], row["genre_name"]);
                }
            }
            dgvGenreDetails.DataSource = genreTable;
        }
        public void ShowCustomerTab()
        {
            btnUpdateCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;            
            customerTable = new DataTable();
            customerTable.Columns.Add("Customer ID");
            customerTable.Columns.Add("First Name");
            customerTable.Columns.Add("Last Name");
            customerTable.Columns.Add("Address");
            customerTable.Columns.Add("Phone No");
            LoadCustomerGrid();
        }

        private void LoadCustomerGrid()
        {
            customerTable.Clear();
            DataSet dataset = operation.GetAllCustomerDetails();
            if(dataset.Tables.Count > 0)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    customerTable.Rows.Add(row["cust_id"], row["first_name"], row["last_name"], row["address"], row["phone_no"]);
                }
            }            
            dgvCustomerGrid.DataSource = customerTable;
        }
        
        public void ShowMovieTab()
        {
            btnUpdateMovie.Enabled = false;
            btnDeleteMovie.Enabled = false;
            operation = new DataOperation();
            BindGenreCombo();
            MovieTable = new DataTable();
            MovieTable.Columns.Add("Movie ID");
            MovieTable.Columns.Add("Movie Title");
            MovieTable.Columns.Add("Genre");
            MovieTable.Columns.Add("Rating");
            MovieTable.Columns.Add("Rental Cost");
            MovieTable.Columns.Add("Release Year");
            LoadMovieGrid();
        }

        private void LoadMovieGrid()
        {
            MovieTable.Clear();
            DataSet dataset = operation.GetAllMovieDetails();
            if(dataset.Tables.Count>0)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    MovieTable.Rows.Add(row["movie_id"], row["title"], row["genre_name"], row["rating"], row["rental_cost"], row["release_year"]);
                }
            }
            dgvMovieGrid.DataSource = MovieTable;
        }

        public void BindGenreCombo()
        {
            DataTable tableGenre = operation.GetGenresDataTable();
            comboGenre.ValueMember = "genre_id";
            comboGenre.DisplayMember = "genre_name";
            comboGenre.DataSource = tableGenre;
        }
        public void ShowMovieRentTab()
        {
            RentTable = new DataTable();
            RentTable.Columns.Add("Rent ID");
            RentTable.Columns.Add("Customer Name");
            RentTable.Columns.Add("Address");
            RentTable.Columns.Add("Phone No");
            RentTable.Columns.Add("Movie Title");
            RentTable.Columns.Add("Rented Cost");
            RentTable.Columns.Add("Rented Date");
            RentTable.Columns.Add("Return Date");
            btnIssue.Enabled = true;
            btnReturn.Enabled = false;
            btnDelete.Enabled = false;
            BindComboBox();
            LoadRentGrid();
        }

        private void BindComboBox()
        {
            DataTable tableCustomer = operation.ViewAllCustomerDetails();
            comboCustomer.ValueMember = "cust_id";
            comboCustomer.DisplayMember = "name";
            comboCustomer.DataSource = tableCustomer;
            DataTable tableMovie = operation.ViewAllMovieDetails();
            comboMovie.ValueMember = "movie_id";
            comboMovie.DisplayMember = "title";
            comboMovie.DataSource = tableMovie;
        }
        private void LoadRentGrid()
        {
            RentTable.Clear();
            DataSet dataset = operation.GetRentedMovieDetails();
            if (radioOut.Checked)
            {
                dataset = operation.GetRentedOutMovieDetails();
            }
            if(dataset.Tables.Count>0)
            {
                foreach (DataRow row in dataset.Tables[0].Rows)
                {
                    RentTable.Rows.Add(row["rent_id"], row["name"], row["address"], row["phone_no"], row["title"], row["rented_cost"], row["date_rented"], row["date_returned"]);
                }
            }
            dgvRentGrid.DataSource = RentTable;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            operation.CloseConnection();
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Genre Tab
            if(tabControl1.SelectedIndex==0)
            {
                ShowGenreTab();
            }
            // Customer Tab
            else if (tabControl1.SelectedIndex == 1)
            {
                ShowCustomerTab();
            }
            // Movie Tab
            else if (tabControl1.SelectedIndex == 2)
            {
                ShowMovieTab();
            }
            // Movie Rent Tab
            else if (tabControl1.SelectedIndex == 3)
            {
                ShowMovieRentTab();
            }
        }

        private void dgvGenreDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                genre_id = int.Parse(dgvGenreDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                textGenreName.Text = dgvGenreDetails.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnAddGenre.Enabled = false;
                btnUpdateGenre.Enabled = true;
                btnDeleteGenre.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            string message = "";
            string genre_name = textGenreName.Text.Trim();

            if (Validator.CheckEmpty(genre_name))
            {
                message = "Please Enter Some Value in Genre Name";
            }
            else
            {
                if (operation.AddNewGenreDetails(genre_name))
                {
                    message = "New Genre Details are Saved in Database";
                    LoadGenreGrid();
                }
                else
                {
                    message = "There are some failure in Saving Genre Details in Database";
                }
            }
            MessageBox.Show(message);
        }

        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (genre_id != 0)
            {
                string message = "";
                string genre_name = textGenreName.Text.Trim();

                if (Validator.CheckEmpty(genre_name))
                {
                    message = "Please Enter Some Value in Genre Name";
                }
                else
                {
                    if (operation.UpdateGenreDetails(genre_id, genre_name))
                    {
                        message = "Genre Details are Updated in Database";
                        LoadGenreGrid();
                    }
                    else
                    {
                        message = "There are some failure in Updating Genre Details in Database";
                    }
                    btnAddGenre.Enabled = true;
                    btnUpdateGenre.Enabled = false;
                    btnDeleteGenre.Enabled = false;
                    textGenreName.Text = "";
                }
                MessageBox.Show(message);
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (genre_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Record From Database?", "Video Rental Software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (operation.DeleteGenreDetails(genre_id))
                    {
                        message = "Genre Details are Removed from Database";
                        genre_id = 0;
                        LoadGenreGrid();
                    }
                    else
                    {
                        message = "There are some failure in removing Genre Details in Database";
                    }
                    MessageBox.Show(message);
                }
                btnAddGenre.Enabled = true;
                btnDeleteGenre.Enabled = false;
                btnUpdateGenre.Enabled = false;
                textGenreName.Text = "";
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string message = "";
            bool all_valid = true;
            string first_name = textFirstName.Text.Trim();
            string last_name = textLastName.Text.Trim();
            string address = textAddress.Text.Trim();
            string phone_no = textPhoneNo.Text.Trim();

            if (Validator.CheckEmpty(first_name))
            {
                all_valid = false;
                message += "Please Enter Some Value in First Name\n\n";
            }

            if (Validator.CheckEmpty(last_name))
            {
                all_valid = false;
                message += "Please Enter Some Value in Last Name\n\n";
            }

            if (Validator.CheckEmpty(address))
            {
                all_valid = false;
                message += "Please Enter Some Value in Address\n\n";
            }

            if (Validator.CheckEmpty(phone_no))
            {
                all_valid = false;
                message += "Please Enter Some Value in Phone No\n\n";
            }
            else if (!Validator.CheckPhone(phone_no))
            {
                all_valid = false;
                message += "Phone No Only Contains Digit\n\n";

            }
            if (all_valid)
            {
                if (operation.AddNewCustomer(first_name, last_name, address, phone_no))
                {
                    message = "New Customer Details are Saved in Database";
                    LoadCustomerGrid();
                }
                else
                {
                    message = "There are some failure in Saving Customer Details in Database";
                }
            }
            MessageBox.Show(message);
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (cust_id != 0)
            {
                string message = "";
                bool all_valid = true;
                string first_name = textFirstName.Text.Trim();
                string last_name = textLastName.Text.Trim();
                string address = textAddress.Text.Trim();
                string phone_no = textPhoneNo.Text.Trim();

                if (Validator.CheckEmpty(first_name))
                {
                    all_valid = false;
                    message += "Please Enter Some Value in First Name\n\n";
                }

                if (Validator.CheckEmpty(last_name))
                {
                    all_valid = false;
                    message += "Please Enter Some Value in Last Name\n\n";
                }

                if (Validator.CheckEmpty(address))
                {
                    all_valid = false;
                    message += "Please Enter Some Value in Address\n\n";
                }

                if (Validator.CheckEmpty(phone_no))
                {
                    all_valid = false;
                    message += "Please Enter Some Value in Phone No\n\n";
                }
                else if (!Validator.CheckPhone(phone_no))
                {
                    all_valid = false;
                    message += "Phone No Only Contains Digit\n\n";

                }
                if (all_valid)
                {
                    if (operation.UpdateCustomerDetails(cust_id, first_name, last_name, address, phone_no))
                    {
                        message = "Customer Details are Updated in Database";
                        LoadCustomerGrid();
                    }
                    else
                    {
                        message = "There are some failure in Saving Customer Details in Database";
                    }
                    btnAddCustomer.Enabled = true;
                    btnUpdateCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;
                    textFirstName.Text = "";
                    textLastName.Text = "";
                    cust_id = 0;
                    textAddress.Text = "";
                    textPhoneNo.Text = "";
                }
                MessageBox.Show(message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (cust_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Record From Database?", "Video Rental Software", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (operation.DeleteCustomerDetails(cust_id))
                    {
                        message = "Customer Details are Removed from Database";
                        cust_id = 0;
                        LoadCustomerGrid();
                    }
                    else
                    {
                        message = "There are some failure in removing Customer Details in Database";
                    }
                    MessageBox.Show(message);
                }
            }
            
        }

        private void dgvCustomerGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cust_id = int.Parse(dgvCustomerGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                textFirstName.Text = dgvCustomerGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                textLastName.Text = dgvCustomerGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                textAddress.Text = dgvCustomerGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                textPhoneNo.Text = dgvCustomerGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                btnAddCustomer.Enabled = false;
                btnUpdateCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void dgvMovieGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                movie_id = int.Parse(dgvMovieGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                textMovieTitle.Text = dgvMovieGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                textReleaseYear.Text = dgvMovieGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
                numericRating.Value = int.Parse(dgvMovieGrid.Rows[e.RowIndex].Cells[3].Value.ToString());
                int genre_id = operation.GetMovieGenreID(movie_id);
                if (genre_id != 0)
                {
                    int selected_index = 0;
                    for (int index = 1; index < comboGenre.Items.Count; index++)
                    {
                        comboGenre.SelectedIndex = index;
                        int gid = int.Parse(comboGenre.SelectedValue.ToString());
                        if (genre_id == gid)
                        {
                            selected_index = index;
                            break;
                        }
                    }
                    comboGenre.SelectedIndex = selected_index;
                }
                btnAddMovie.Enabled = false;
                btnUpdateMovie.Enabled = true;
                btnDeleteMovie.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string message = "";
            bool all_valid = true;
            string title = textMovieTitle.Text.Trim();
            string year = textReleaseYear.Text.Trim();

            float rating = (float)numericRating.Value;
            if (Validator.CheckEmpty(title))
            {
                all_valid = false;
                message += "Please Enter Some Value in Title\n\n";
            }

            if (Validator.CheckEmpty(year))
            {
                all_valid = false;
                message += "Please Enter Some Value in Release Year\n\n";
            }
            else if (year.Length != 4)
            {
                all_valid = false;
                message += "Please Enter Four Digit in Release Year\n\n";
            }
            else if (!Validator.CheckNumber(year))
            {
                all_valid = false;
                message += "Please Enter Number in Release Year\n\n";
            }

            if (comboGenre.SelectedIndex == 0)
            {
                all_valid = false;
                message += "Please Choose Any Genre\n\n";
            }
            if (all_valid)
            {
                int release_year = int.Parse(year);
                float rental_cost = 5;
                int genre_id = int.Parse(comboGenre.SelectedValue.ToString());
                if (release_year < DateTime.Now.Year - 5)
                {
                    rental_cost = 2;
                }
                if (operation.AddNewMovieDetails(title, rating, release_year, genre_id, rental_cost))
                {
                    message = "New Movie Details are Saved in Database";
                    LoadMovieGrid();
                }
                else
                {
                    message = "There are some failure in saveing Movie Details in Database";
                }
            }
            MessageBox.Show(message);
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (movie_id != 0)
            {
                string message = "";
                bool all_valid = true;
                string title = textMovieTitle.Text.Trim();
                string year = textReleaseYear.Text.Trim();

                float rating = (float)numericRating.Value;
                if (Validator.CheckEmpty(title))
                {
                    all_valid = false;
                    message += "Please Enter Some Value in Title\n\n";
                }

                if (Validator.CheckEmpty(year))
                {
                    all_valid = false;
                    message += "Please Enter Some Value in Release Year\n\n";
                }
                else if (year.Length != 4)
                {
                    all_valid = false;
                    message += "Please Enter Four Digit in Release Year\n\n";
                }
                else if (!Validator.CheckNumber(year))
                {
                    all_valid = false;
                    message += "Please Enter Number in Release Year\n\n";
                }

                if (comboGenre.SelectedIndex == 0)
                {
                    all_valid = false;
                    message += "Please Enter Some Value in Genre\n\n";
                }
                if (all_valid)
                {
                    int release_year = int.Parse(year);
                    float rental_cost = 5;
                    if (release_year < DateTime.Now.Year - 5)
                    {
                        rental_cost = 2;
                    }
                    int genre_id = int.Parse(comboGenre.SelectedValue.ToString());
                    if (operation.UpdateMovieDetails(movie_id, title, rating, release_year, genre_id, rental_cost))
                    {
                        message = "Movie Details are Updated in Database";
                        LoadMovieGrid();
                    }
                    else
                    {
                        message = "There are some failure in saving Movie Details in Database";
                    }
                }
                MessageBox.Show(message);
                btnAddMovie.Enabled = true;
                btnUpdateMovie.Enabled = false;
                btnDeleteMovie.Enabled = false;
                movie_id = 0;
                textMovieTitle.Text = "";
                textReleaseYear.Text = "";
                numericRating.Value = 0;
                comboGenre.SelectedIndex = 0;
            }
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (movie_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Record From Database?", "Movie System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (operation.DeleteMovieDetails(movie_id))
                    {
                        message = "Movie Details are Removed from Database";
                        LoadMovieGrid();
                    }
                    else
                    {
                        message = "There are some failure in removing Movie Details in Database";
                    }
                    MessageBox.Show(message);
                    btnAddMovie.Enabled = true;
                    btnUpdateMovie.Enabled = false;
                    btnDeleteMovie.Enabled = false;
                    movie_id = 0;
                    textMovieTitle.Text = "";
                    textReleaseYear.Text = "";
                    numericRating.Value = 0;
                    comboGenre.SelectedIndex = 0;
                }
            }
        }

        private void dgvRentGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rent_id = int.Parse(dgvRentGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                btnReturn.Enabled = true;
                btnDelete.Enabled = true;
                btnIssue.Enabled = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            string message = "";
            bool all_valid = true;
            DateTime rented_date = dtpDate.Value;

            if (comboCustomer.SelectedIndex == 0)
            {
                all_valid = false;
                message += "Please Choose Any Customer\n\n";
            }

            if (comboMovie.SelectedIndex == 0)
            {
                all_valid = false;
                message += "Please Choose Any Movie\n\n";
            }

            if (all_valid)
            {
                float rental_cost = float.Parse(labelRent.Text.Trim());
                int movie_id = int.Parse(comboMovie.SelectedValue.ToString());
                int cust_id = int.Parse(comboCustomer.SelectedValue.ToString());
                if (operation.IssueMovieToCustomer(movie_id, cust_id, rental_cost, rented_date))
                {
                    message = "Movie is Issued and its Details are Saved in Database";
                    LoadRentGrid();
                }
                else
                {
                    message = "There are some failure in Issue the Movie to Customer";
                }
            }
            MessageBox.Show(message);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (rent_id != 0)
            {
                if (operation.ReturnMovie(rent_id, DateTime.Now))
                {
                    MessageBox.Show("Movie is Successfuly returned");
                    LoadRentGrid();
                }
                else
                {
                    MessageBox.Show(" There are some issued in Returning Movie");
                }
                rent_id = 0;
                btnReturn.Enabled = false;
                btnDelete.Enabled = false;
                btnIssue.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rent_id != 0)
            {
                DialogResult result = MessageBox.Show("Are You Sure To Remove Record From Database?", "Movie System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string message = "";
                    if (operation.DeleteRentalDetails(rent_id))
                    {
                        message = "Movie Rented Details are Removed from Database";
                        rent_id = 0;
                        LoadRentGrid();
                    }
                    else
                    {
                        message = "There are some failure in removing Movie Rented Details in Database";
                    }
                    MessageBox.Show(message);
                    btnReturn.Enabled = false;
                    btnDelete.Enabled = false;
                    btnIssue.Enabled = true;
                }
            }
        }

        private void comboMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMovie.SelectedIndex != 0)
            {
                labelRent.Text = operation.GetMovieRentDetails(int.Parse(comboMovie.SelectedValue.ToString())).ToString();
            }
            else
            {
                labelRent.Text = "None";
            }
        }

        private void radio_checked(object sender, EventArgs e)
        {
            LoadRentGrid();
        }
    }
}
