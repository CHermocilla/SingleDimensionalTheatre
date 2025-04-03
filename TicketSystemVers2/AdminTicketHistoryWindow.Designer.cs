namespace TicketSystemVers2
{
    partial class AdminTicketHistoryWindow
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
            AddMoviesBtn = new Button();
            signoutbtn = new Button();
            CurrentMoviesRunningBtn = new Button();
            homebtn = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            AdminCancelTixbx = new TextBox();
            button1 = new Button();
            label2 = new Label();
            UserIDTxbx = new TextBox();
            userchckbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // AddMoviesBtn
            // 
            AddMoviesBtn.BackColor = Color.FromArgb(73, 5, 102);
            AddMoviesBtn.FlatAppearance.BorderSize = 0;
            AddMoviesBtn.FlatStyle = FlatStyle.Flat;
            AddMoviesBtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            AddMoviesBtn.ForeColor = Color.White;
            AddMoviesBtn.Location = new Point(519, 7);
            AddMoviesBtn.Name = "AddMoviesBtn";
            AddMoviesBtn.Size = new Size(278, 55);
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
            signoutbtn.Location = new Point(1070, 7);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(142, 55);
            signoutbtn.TabIndex = 8;
            signoutbtn.Text = "Sign Out";
            signoutbtn.UseVisualStyleBackColor = false;
            signoutbtn.Click += signoutbtn_Click;
            // 
            // CurrentMoviesRunningBtn
            // 
            CurrentMoviesRunningBtn.BackColor = Color.FromArgb(73, 5, 102);
            CurrentMoviesRunningBtn.FlatAppearance.BorderSize = 0;
            CurrentMoviesRunningBtn.FlatStyle = FlatStyle.Flat;
            CurrentMoviesRunningBtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            CurrentMoviesRunningBtn.ForeColor = Color.White;
            CurrentMoviesRunningBtn.Location = new Point(856, 9);
            CurrentMoviesRunningBtn.Name = "CurrentMoviesRunningBtn";
            CurrentMoviesRunningBtn.Size = new Size(142, 55);
            CurrentMoviesRunningBtn.TabIndex = 7;
            CurrentMoviesRunningBtn.Text = "Ticket History";
            CurrentMoviesRunningBtn.UseVisualStyleBackColor = false;
            CurrentMoviesRunningBtn.Click += CurrentMoviesRunningBtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.FromArgb(73, 5, 102);
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Franklin Gothic Heavy", 10.2F);
            homebtn.ForeColor = Color.White;
            homebtn.Location = new Point(330, 7);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(142, 55);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(715, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(622, 545);
            dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(54, 310);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(600, 545);
            dataGridView2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(721, 181);
            label1.Name = "label1";
            label1.Size = new Size(573, 36);
            label1.TabIndex = 11;
            label1.Text = "Insert the ID of the existing booking you want to cancel:";
            // 
            // AdminCancelTixbx
            // 
            AdminCancelTixbx.Location = new Point(795, 247);
            AdminCancelTixbx.Name = "AdminCancelTixbx";
            AdminCancelTixbx.Size = new Size(203, 27);
            AdminCancelTixbx.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(1047, 237);
            button1.Name = "button1";
            button1.Size = new Size(168, 48);
            button1.TabIndex = 13;
            button1.Text = "Cancel Ticket";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(97, 181);
            label2.Name = "label2";
            label2.Size = new Size(515, 36);
            label2.TabIndex = 15;
            label2.Text = "Insert the User ID you want to check bookings for:";
            // 
            // UserIDTxbx
            // 
            UserIDTxbx.Location = new Point(145, 247);
            UserIDTxbx.Name = "UserIDTxbx";
            UserIDTxbx.Size = new Size(203, 27);
            UserIDTxbx.TabIndex = 16;
            // 
            // userchckbtn
            // 
            userchckbtn.BackColor = Color.Maroon;
            userchckbtn.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userchckbtn.ForeColor = Color.Transparent;
            userchckbtn.Location = new Point(397, 237);
            userchckbtn.Name = "userchckbtn";
            userchckbtn.Size = new Size(168, 48);
            userchckbtn.TabIndex = 17;
            userchckbtn.Text = "Check";
            userchckbtn.UseVisualStyleBackColor = false;
            userchckbtn.Click += userchckbtn_Click;
            // 
            // AdminTicketHistoryWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = Properties.Resources.AdminTicketHistory_Vers1;
            ClientSize = new Size(1400, 900);
            Controls.Add(userchckbtn);
            Controls.Add(UserIDTxbx);
            Controls.Add(label2);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(AdminCancelTixbx);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(AddMoviesBtn);
            Controls.Add(signoutbtn);
            Controls.Add(homebtn);
            Controls.Add(CurrentMoviesRunningBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminTicketHistoryWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Single Dimensional Theatre | Ticket History";
            Load += AdminTicketHistoryWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button AddMoviesBtn;
        private Button signoutbtn;
        private Button CurrentMoviesRunningBtn;
        private Button homebtn;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private TextBox AdminCancelTixbx;
        private Button button1;
        private Label label2;
        private TextBox UserIDTxbx;
        private Button userchckbtn;
    }
}