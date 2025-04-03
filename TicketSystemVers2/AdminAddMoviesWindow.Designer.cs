namespace TicketSystemVers2
{
    partial class AdminAddMoviesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddMoviesWindow));
            AddMoviesBtn = new Button();
            signoutbtn = new Button();
            TicketHistoryBtn = new Button();
            homebtn = new Button();
            movietitletxtbx = new TextBox();
            moviegenretxtbx = new TextBox();
            moviecasttxtbx = new TextBox();
            moviedirectorstxtbx = new TextBox();
            addmoviebtn = new Button();
            moviedatepicker = new DateTimePicker();
            movieposterurltxtbx = new TextBox();
            moviedescriptxtbx = new TextBox();
            deletemoviebtn = new Button();
            deletemovietxtbx = new TextBox();
            dataGridView1 = new DataGridView();
            movieratingcmbx = new ComboBox();
            movietheatrecmbx = new ComboBox();
            movietimepicker = new ComboBox();
            moviepricetxtbx = new TextBox();
            label1 = new Label();
            movieidtxtbx = new TextBox();
            displaycmbx = new ComboBox();
            updposterurl = new TextBox();
            updatefeaturedbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddMoviesBtn
            // 
            AddMoviesBtn.BackColor = Color.FromArgb(73, 5, 102);
            AddMoviesBtn.FlatAppearance.BorderSize = 0;
            AddMoviesBtn.FlatStyle = FlatStyle.Flat;
            AddMoviesBtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            AddMoviesBtn.ForeColor = Color.White;
            AddMoviesBtn.Location = new Point(486, 2);
            AddMoviesBtn.Name = "AddMoviesBtn";
            AddMoviesBtn.Size = new Size(266, 55);
            AddMoviesBtn.TabIndex = 9;
            AddMoviesBtn.Text = "Add and Delete Movies";
            AddMoviesBtn.UseVisualStyleBackColor = false;
            AddMoviesBtn.Click += AddMoviesBtn_Click;
            // 
            // signoutbtn
            // 
            signoutbtn.BackColor = Color.FromArgb(73, 5, 102);
            signoutbtn.FlatAppearance.BorderSize = 0;
            signoutbtn.FlatStyle = FlatStyle.Flat;
            signoutbtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            signoutbtn.ForeColor = Color.White;
            signoutbtn.Location = new Point(1041, 2);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(142, 55);
            signoutbtn.TabIndex = 8;
            signoutbtn.Text = "Sign Out";
            signoutbtn.UseVisualStyleBackColor = false;
            signoutbtn.Click += signoutbtn_Click;
            // 
            // TicketHistoryBtn
            // 
            TicketHistoryBtn.BackColor = Color.FromArgb(73, 5, 102);
            TicketHistoryBtn.FlatAppearance.BorderSize = 0;
            TicketHistoryBtn.FlatStyle = FlatStyle.Flat;
            TicketHistoryBtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            TicketHistoryBtn.ForeColor = Color.White;
            TicketHistoryBtn.Location = new Point(824, 2);
            TicketHistoryBtn.Name = "TicketHistoryBtn";
            TicketHistoryBtn.Size = new Size(142, 55);
            TicketHistoryBtn.TabIndex = 7;
            TicketHistoryBtn.Text = "Ticket History";
            TicketHistoryBtn.UseVisualStyleBackColor = false;
            TicketHistoryBtn.Click += CurrentMoviesRunningBtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.FromArgb(73, 5, 102);
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            homebtn.ForeColor = Color.White;
            homebtn.Location = new Point(317, 2);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(142, 55);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // movietitletxtbx
            // 
            movietitletxtbx.Location = new Point(221, 153);
            movietitletxtbx.Name = "movietitletxtbx";
            movietitletxtbx.Size = new Size(440, 27);
            movietitletxtbx.TabIndex = 7;
            // 
            // moviegenretxtbx
            // 
            moviegenretxtbx.Location = new Point(221, 196);
            moviegenretxtbx.Name = "moviegenretxtbx";
            moviegenretxtbx.Size = new Size(440, 27);
            moviegenretxtbx.TabIndex = 8;
            // 
            // moviecasttxtbx
            // 
            moviecasttxtbx.Location = new Point(221, 333);
            moviecasttxtbx.Name = "moviecasttxtbx";
            moviecasttxtbx.Size = new Size(440, 27);
            moviecasttxtbx.TabIndex = 9;
            // 
            // moviedirectorstxtbx
            // 
            moviedirectorstxtbx.Location = new Point(221, 288);
            moviedirectorstxtbx.Name = "moviedirectorstxtbx";
            moviedirectorstxtbx.Size = new Size(440, 27);
            moviedirectorstxtbx.TabIndex = 10;
            // 
            // addmoviebtn
            // 
            addmoviebtn.BackColor = Color.Maroon;
            addmoviebtn.FlatStyle = FlatStyle.Popup;
            addmoviebtn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addmoviebtn.ForeColor = Color.WhiteSmoke;
            addmoviebtn.Location = new Point(53, 797);
            addmoviebtn.Name = "addmoviebtn";
            addmoviebtn.Size = new Size(597, 29);
            addmoviebtn.TabIndex = 12;
            addmoviebtn.Text = "ADD MOVIE";
            addmoviebtn.UseVisualStyleBackColor = false;
            addmoviebtn.Click += addmoviebtn_Click;
            // 
            // moviedatepicker
            // 
            moviedatepicker.Location = new Point(286, 477);
            moviedatepicker.Name = "moviedatepicker";
            moviedatepicker.Size = new Size(375, 27);
            moviedatepicker.TabIndex = 13;
            // 
            // movieposterurltxtbx
            // 
            movieposterurltxtbx.Location = new Point(286, 570);
            movieposterurltxtbx.Name = "movieposterurltxtbx";
            movieposterurltxtbx.Size = new Size(375, 27);
            movieposterurltxtbx.TabIndex = 14;
            // 
            // moviedescriptxtbx
            // 
            moviedescriptxtbx.Location = new Point(53, 660);
            moviedescriptxtbx.Multiline = true;
            moviedescriptxtbx.Name = "moviedescriptxtbx";
            moviedescriptxtbx.Size = new Size(597, 123);
            moviedescriptxtbx.TabIndex = 16;
            // 
            // deletemoviebtn
            // 
            deletemoviebtn.FlatStyle = FlatStyle.Popup;
            deletemoviebtn.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletemoviebtn.ForeColor = Color.WhiteSmoke;
            deletemoviebtn.Location = new Point(1046, 476);
            deletemoviebtn.Name = "deletemoviebtn";
            deletemoviebtn.Size = new Size(233, 34);
            deletemoviebtn.TabIndex = 19;
            deletemoviebtn.Text = "DELETE MOVIE";
            deletemoviebtn.UseVisualStyleBackColor = true;
            deletemoviebtn.Click += deletemoviebtn_Click;
            // 
            // deletemovietxtbx
            // 
            deletemovietxtbx.Location = new Point(769, 477);
            deletemovietxtbx.Name = "deletemovietxtbx";
            deletemovietxtbx.Size = new Size(233, 27);
            deletemovietxtbx.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(719, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(623, 272);
            dataGridView1.TabIndex = 22;
            // 
            // movieratingcmbx
            // 
            movieratingcmbx.FormattingEnabled = true;
            movieratingcmbx.Items.AddRange(new object[] { "RATED G", "RATED PG ", "RATED PG - 13", "RATED R", "RATED NC-17" });
            movieratingcmbx.Location = new Point(221, 240);
            movieratingcmbx.Name = "movieratingcmbx";
            movieratingcmbx.Size = new Size(440, 28);
            movieratingcmbx.TabIndex = 23;
            // 
            // movietheatrecmbx
            // 
            movietheatrecmbx.FormattingEnabled = true;
            movietheatrecmbx.Items.AddRange(new object[] { "Milky Way Cinema" });
            movietheatrecmbx.Location = new Point(221, 426);
            movietheatrecmbx.Name = "movietheatrecmbx";
            movietheatrecmbx.Size = new Size(440, 28);
            movietheatrecmbx.TabIndex = 24;
            // 
            // movietimepicker
            // 
            movietimepicker.FormattingEnabled = true;
            movietimepicker.Items.AddRange(new object[] { "12:00 PM", "02:00 PM", "04:00 PM", "06:00 PM", "08:00 PM" });
            movietimepicker.Location = new Point(286, 524);
            movietimepicker.Name = "movietimepicker";
            movietimepicker.Size = new Size(375, 28);
            movietimepicker.TabIndex = 25;
            // 
            // moviepricetxtbx
            // 
            moviepricetxtbx.Location = new Point(221, 380);
            moviepricetxtbx.Name = "moviepricetxtbx";
            moviepricetxtbx.Size = new Size(440, 27);
            moviepricetxtbx.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Franklin Gothic Heavy", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(763, 436);
            label1.Name = "label1";
            label1.Size = new Size(516, 29);
            label1.TabIndex = 27;
            label1.Text = "Enter the movie ID of what you want to delete:";
            // 
            // movieidtxtbx
            // 
            movieidtxtbx.Location = new Point(12, 12);
            movieidtxtbx.Name = "movieidtxtbx";
            movieidtxtbx.Size = new Size(141, 27);
            movieidtxtbx.TabIndex = 28;
            movieidtxtbx.Visible = false;
            // 
            // displaycmbx
            // 
            displaycmbx.FormattingEnabled = true;
            displaycmbx.Items.AddRange(new object[] { "Display 1", "Display 2", "Display 3", "Display 4" });
            displaycmbx.Location = new Point(724, 628);
            displaycmbx.Name = "displaycmbx";
            displaycmbx.Size = new Size(605, 28);
            displaycmbx.TabIndex = 29;
            displaycmbx.SelectedIndexChanged += displaycmbx_SelectedIndexChanged;
            // 
            // updposterurl
            // 
            updposterurl.Location = new Point(724, 720);
            updposterurl.Name = "updposterurl";
            updposterurl.Size = new Size(605, 27);
            updposterurl.TabIndex = 30;
            // 
            // updatefeaturedbtn
            // 
            updatefeaturedbtn.FlatStyle = FlatStyle.Popup;
            updatefeaturedbtn.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updatefeaturedbtn.ForeColor = Color.WhiteSmoke;
            updatefeaturedbtn.Location = new Point(841, 777);
            updatefeaturedbtn.Name = "updatefeaturedbtn";
            updatefeaturedbtn.Size = new Size(388, 34);
            updatefeaturedbtn.TabIndex = 32;
            updatefeaturedbtn.Text = "UPDATE FEATURED MOVIES";
            updatefeaturedbtn.UseVisualStyleBackColor = true;
            updatefeaturedbtn.Click += updatefeaturedbtn_Click;
            // 
            // AdminAddMoviesWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 853);
            Controls.Add(updatefeaturedbtn);
            Controls.Add(updposterurl);
            Controls.Add(displaycmbx);
            Controls.Add(movieidtxtbx);
            Controls.Add(label1);
            Controls.Add(moviepricetxtbx);
            Controls.Add(movietimepicker);
            Controls.Add(signoutbtn);
            Controls.Add(AddMoviesBtn);
            Controls.Add(movietheatrecmbx);
            Controls.Add(movieratingcmbx);
            Controls.Add(TicketHistoryBtn);
            Controls.Add(dataGridView1);
            Controls.Add(deletemovietxtbx);
            Controls.Add(homebtn);
            Controls.Add(deletemoviebtn);
            Controls.Add(moviedescriptxtbx);
            Controls.Add(movieposterurltxtbx);
            Controls.Add(moviedatepicker);
            Controls.Add(addmoviebtn);
            Controls.Add(moviedirectorstxtbx);
            Controls.Add(moviecasttxtbx);
            Controls.Add(moviegenretxtbx);
            Controls.Add(movietitletxtbx);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminAddMoviesWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SDT | Admin | Add & Delete Movies";
            Load += AdminAddMoviesWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddMoviesBtn;
        private Button signoutbtn;
        private Button TicketHistoryBtn;
        private Button homebtn;
        private TextBox movietitletxtbx;
        private TextBox moviegenretxtbx;
        private TextBox moviecasttxtbx;
        private TextBox moviedirectorstxtbx;
        private Button addmoviebtn;
        private DateTimePicker moviedatepicker;
        private TextBox movieposterurltxtbx;
        private TextBox moviedescriptxtbx;
        private Button deletemoviebtn;
        private TextBox deletemovietxtbx;
        private DataGridView dataGridView1;
        private ComboBox movieratingcmbx;
        private ComboBox movietheatrecmbx;
        private ComboBox movietimepicker;
        private TextBox moviepricetxtbx;
        private Label label1;
        private TextBox movieidtxtbx;
        private ComboBox displaycmbx;
        private TextBox updposterurl;
        private Button updatefeaturedbtn;
    }
}