
namespace VideoStore
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.textGenreName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGenreDetails = new System.Windows.Forms.DataGridView();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.dgvCustomerGrid = new System.Windows.Forms.DataGridView();
            this.comboGenre = new System.Windows.Forms.ComboBox();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.numericRating = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.textReleaseYear = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMovieTitle = new System.Windows.Forms.TextBox();
            this.dgvMovieGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOut = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.dgvRentGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.labelRent = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.comboMovie = new System.Windows.Forms.ComboBox();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenreDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1290, 694);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteGenre);
            this.tabPage1.Controls.Add(this.btnUpdateGenre);
            this.tabPage1.Controls.Add(this.btnAddGenre);
            this.tabPage1.Controls.Add(this.textGenreName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvGenreDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1095, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genre Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textAddress);
            this.tabPage2.Controls.Add(this.btnDeleteCustomer);
            this.tabPage2.Controls.Add(this.btnUpdateCustomer);
            this.tabPage2.Controls.Add(this.btnAddCustomer);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textPhoneNo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textLastName);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textFirstName);
            this.tabPage2.Controls.Add(this.dgvCustomerGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1212, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboGenre);
            this.tabPage3.Controls.Add(this.btnDeleteMovie);
            this.tabPage3.Controls.Add(this.btnUpdateMovie);
            this.tabPage3.Controls.Add(this.btnAddMovie);
            this.tabPage3.Controls.Add(this.numericRating);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textReleaseYear);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textMovieTitle);
            this.tabPage3.Controls.Add(this.dgvMovieGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1212, 665);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movie Details";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.dgvRentGrid);
            this.tabPage4.Controls.Add(this.btnDelete);
            this.tabPage4.Controls.Add(this.btnReturn);
            this.tabPage4.Controls.Add(this.labelRent);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnIssue);
            this.tabPage4.Controls.Add(this.labelDate);
            this.tabPage4.Controls.Add(this.dtpDate);
            this.tabPage4.Controls.Add(this.comboMovie);
            this.tabPage4.Controls.Add(this.comboCustomer);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1282, 665);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Movie Rent Details";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenre.Location = new System.Drawing.Point(688, 436);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(321, 54);
            this.btnDeleteGenre.TabIndex = 31;
            this.btnDeleteGenre.Text = "Delete Genre Details";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenre.Location = new System.Drawing.Point(327, 436);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(342, 54);
            this.btnUpdateGenre.TabIndex = 30;
            this.btnUpdateGenre.Text = "Update Genre Details";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.Location = new System.Drawing.Point(33, 436);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(260, 54);
            this.btnAddGenre.TabIndex = 29;
            this.btnAddGenre.Text = "Add New Genre";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // textGenreName
            // 
            this.textGenreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGenreName.Location = new System.Drawing.Point(393, 358);
            this.textGenreName.Name = "textGenreName";
            this.textGenreName.Size = new System.Drawing.Size(498, 30);
            this.textGenreName.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Genre Name:";
            // 
            // dgvGenreDetails
            // 
            this.dgvGenreDetails.AllowUserToAddRows = false;
            this.dgvGenreDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvGenreDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenreDetails.Location = new System.Drawing.Point(33, 18);
            this.dgvGenreDetails.Name = "dgvGenreDetails";
            this.dgvGenreDetails.RowHeadersWidth = 51;
            this.dgvGenreDetails.RowTemplate.Height = 24;
            this.dgvGenreDetails.Size = new System.Drawing.Size(976, 300);
            this.dgvGenreDetails.TabIndex = 26;
            this.dgvGenreDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGenreDetails_CellClick);
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(694, 206);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(421, 109);
            this.textAddress.TabIndex = 37;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(694, 542);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(421, 41);
            this.btnDeleteCustomer.TabIndex = 36;
            this.btnDeleteCustomer.Text = "Delete Customer Details";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.Location = new System.Drawing.Point(694, 482);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(421, 42);
            this.btnUpdateCustomer.TabIndex = 35;
            this.btnUpdateCustomer.Text = "Update Customer Details";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(694, 422);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(421, 40);
            this.btnAddCustomer.TabIndex = 34;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(689, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Enter Phone No:";
            // 
            // textPhoneNo
            // 
            this.textPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhoneNo.Location = new System.Drawing.Point(694, 374);
            this.textPhoneNo.Name = "textPhoneNo";
            this.textPhoneNo.Size = new System.Drawing.Size(421, 30);
            this.textPhoneNo.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Enter Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Enter Last Name:";
            // 
            // textLastName
            // 
            this.textLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLastName.Location = new System.Drawing.Point(694, 125);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(421, 30);
            this.textLastName.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(689, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Enter First Name:";
            // 
            // textFirstName
            // 
            this.textFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFirstName.Location = new System.Drawing.Point(694, 44);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(421, 30);
            this.textFirstName.TabIndex = 27;
            // 
            // dgvCustomerGrid
            // 
            this.dgvCustomerGrid.AllowUserToAddRows = false;
            this.dgvCustomerGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerGrid.Location = new System.Drawing.Point(6, 23);
            this.dgvCustomerGrid.Name = "dgvCustomerGrid";
            this.dgvCustomerGrid.RowHeadersWidth = 51;
            this.dgvCustomerGrid.RowTemplate.Height = 24;
            this.dgvCustomerGrid.Size = new System.Drawing.Size(657, 583);
            this.dgvCustomerGrid.TabIndex = 26;
            this.dgvCustomerGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerGrid_CellClick);
            // 
            // comboGenre
            // 
            this.comboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGenre.FormattingEnabled = true;
            this.comboGenre.Location = new System.Drawing.Point(870, 169);
            this.comboGenre.Name = "comboGenre";
            this.comboGenre.Size = new System.Drawing.Size(304, 33);
            this.comboGenre.TabIndex = 25;
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(870, 580);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(304, 54);
            this.btnDeleteMovie.TabIndex = 24;
            this.btnDeleteMovie.Text = "Delete Movie Details";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(870, 503);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(304, 54);
            this.btnUpdateMovie.TabIndex = 23;
            this.btnUpdateMovie.Text = "Update Movie Details";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(870, 429);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(304, 54);
            this.btnAddMovie.TabIndex = 22;
            this.btnAddMovie.Text = "Add New Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // numericRating
            // 
            this.numericRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRating.Location = new System.Drawing.Point(870, 277);
            this.numericRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericRating.Name = "numericRating";
            this.numericRating.Size = new System.Drawing.Size(304, 30);
            this.numericRating.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(865, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enter Movie Release Year:";
            // 
            // textReleaseYear
            // 
            this.textReleaseYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textReleaseYear.Location = new System.Drawing.Point(870, 376);
            this.textReleaseYear.Name = "textReleaseYear";
            this.textReleaseYear.Size = new System.Drawing.Size(304, 30);
            this.textReleaseYear.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(865, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Enter Movie Rating:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(865, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Enter Genre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(865, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Enter Movie Title:";
            // 
            // textMovieTitle
            // 
            this.textMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMovieTitle.Location = new System.Drawing.Point(870, 66);
            this.textMovieTitle.Name = "textMovieTitle";
            this.textMovieTitle.Size = new System.Drawing.Size(304, 30);
            this.textMovieTitle.TabIndex = 15;
            // 
            // dgvMovieGrid
            // 
            this.dgvMovieGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieGrid.Location = new System.Drawing.Point(16, 36);
            this.dgvMovieGrid.Name = "dgvMovieGrid";
            this.dgvMovieGrid.RowHeadersWidth = 51;
            this.dgvMovieGrid.RowTemplate.Height = 24;
            this.dgvMovieGrid.Size = new System.Drawing.Size(816, 604);
            this.dgvMovieGrid.TabIndex = 14;
            this.dgvMovieGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovieGrid_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOut);
            this.groupBox1.Controls.Add(this.radioAll);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 163);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // radioOut
            // 
            this.radioOut.AutoSize = true;
            this.radioOut.Location = new System.Drawing.Point(17, 104);
            this.radioOut.Name = "radioOut";
            this.radioOut.Size = new System.Drawing.Size(142, 29);
            this.radioOut.TabIndex = 1;
            this.radioOut.TabStop = true;
            this.radioOut.Text = "Out Rented";
            this.radioOut.UseVisualStyleBackColor = true;
            this.radioOut.CheckedChanged += new System.EventHandler(this.radio_checked);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(17, 48);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(132, 29);
            this.radioAll.TabIndex = 0;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Rented";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radio_checked);
            // 
            // dgvRentGrid
            // 
            this.dgvRentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentGrid.Location = new System.Drawing.Point(16, 15);
            this.dgvRentGrid.Name = "dgvRentGrid";
            this.dgvRentGrid.RowHeadersWidth = 51;
            this.dgvRentGrid.RowTemplate.Height = 24;
            this.dgvRentGrid.Size = new System.Drawing.Size(1254, 418);
            this.dgvRentGrid.TabIndex = 27;
            this.dgvRentGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentGrid_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(964, 593);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(305, 44);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(611, 593);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(266, 44);
            this.btnReturn.TabIndex = 38;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // labelRent
            // 
            this.labelRent.AutoSize = true;
            this.labelRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRent.Location = new System.Drawing.Point(1051, 541);
            this.labelRent.Name = "labelRent";
            this.labelRent.Size = new System.Drawing.Size(63, 25);
            this.labelRent.TabIndex = 37;
            this.labelRent.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(803, 541);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 25);
            this.label10.TabIndex = 36;
            this.label10.Text = "Movie Rental Cost $";
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(242, 593);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(304, 44);
            this.btnIssue.TabIndex = 35;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(792, 439);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(203, 25);
            this.labelDate.TabIndex = 34;
            this.labelDate.Text = "Choose Issue Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(797, 477);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(473, 30);
            this.dtpDate.TabIndex = 33;
            // 
            // comboMovie
            // 
            this.comboMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMovie.FormattingEnabled = true;
            this.comboMovie.Location = new System.Drawing.Point(396, 538);
            this.comboMovie.Name = "comboMovie";
            this.comboMovie.Size = new System.Drawing.Size(359, 33);
            this.comboMovie.TabIndex = 32;
            this.comboMovie.SelectedIndexChanged += new System.EventHandler(this.comboMovie_SelectedIndexChanged);
            // 
            // comboCustomer
            // 
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(396, 474);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(359, 33);
            this.comboCustomer.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(179, 541);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 25);
            this.label11.TabIndex = 30;
            this.label11.Text = "Choose Movie :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(172, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Choose Customer :";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 718);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenreDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.TextBox textGenreName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGenreDetails;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPhoneNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.DataGridView dgvCustomerGrid;
        private System.Windows.Forms.ComboBox comboGenre;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.NumericUpDown numericRating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textReleaseYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMovieTitle;
        private System.Windows.Forms.DataGridView dgvMovieGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOut;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.DataGridView dgvRentGrid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label labelRent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox comboMovie;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

