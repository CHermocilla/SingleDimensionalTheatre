namespace TicketSystemVers2
{
    partial class AdminHomeWindow
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
            TicketHistoryBtn = new Button();
            homebtn = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            TAdmins = new Label();
            label2 = new Label();
            panel2 = new Panel();
            TUsers = new Label();
            label3 = new Label();
            panel3 = new Panel();
            TodayR = new Label();
            label4 = new Label();
            panel4 = new Panel();
            TotalR = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // AddMoviesBtn
            // 
            AddMoviesBtn.BackColor = Color.FromArgb(73, 5, 102);
            AddMoviesBtn.FlatAppearance.BorderSize = 0;
            AddMoviesBtn.FlatStyle = FlatStyle.Flat;
            AddMoviesBtn.Font = new Font("Franklin Gothic Heavy", 12F);
            AddMoviesBtn.ForeColor = Color.WhiteSmoke;
            AddMoviesBtn.Location = new Point(504, 4);
            AddMoviesBtn.Name = "AddMoviesBtn";
            AddMoviesBtn.Size = new Size(245, 55);
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
            signoutbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            signoutbtn.ForeColor = Color.WhiteSmoke;
            signoutbtn.Location = new Point(997, 4);
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
            TicketHistoryBtn.Font = new Font("Franklin Gothic Heavy", 12F);
            TicketHistoryBtn.ForeColor = Color.WhiteSmoke;
            TicketHistoryBtn.Location = new Point(799, 4);
            TicketHistoryBtn.Name = "TicketHistoryBtn";
            TicketHistoryBtn.Size = new Size(153, 55);
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
            homebtn.Font = new Font("Franklin Gothic Heavy", 12F);
            homebtn.ForeColor = Color.WhiteSmoke;
            homebtn.Location = new Point(325, 4);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(142, 55);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.movie_theater_1400;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(57, 453);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1303, 404);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 15, 102);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(TAdmins);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(57, 179);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 244);
            panel1.TabIndex = 11;
            // 
            // TAdmins
            // 
            TAdmins.AutoSize = true;
            TAdmins.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TAdmins.ForeColor = Color.Transparent;
            TAdmins.Location = new Point(117, 148);
            TAdmins.Name = "TAdmins";
            TAdmins.Size = new Size(29, 36);
            TAdmins.TabIndex = 1;
            TAdmins.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(30, 13);
            label2.Name = "label2";
            label2.Size = new Size(221, 36);
            label2.TabIndex = 0;
            label2.Text = "Total No. of Admins:";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(41, 15, 102);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TUsers);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(392, 179);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 244);
            panel2.TabIndex = 12;
            // 
            // TUsers
            // 
            TUsers.AutoSize = true;
            TUsers.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TUsers.ForeColor = Color.Transparent;
            TUsers.Location = new Point(134, 148);
            TUsers.Name = "TUsers";
            TUsers.Size = new Size(29, 36);
            TUsers.TabIndex = 2;
            TUsers.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(51, 13);
            label3.Name = "label3";
            label3.Size = new Size(201, 36);
            label3.TabIndex = 1;
            label3.Text = "Total No. of Users:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(41, 15, 102);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TodayR);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(732, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(294, 244);
            panel3.TabIndex = 14;
            // 
            // TodayR
            // 
            TodayR.AutoSize = true;
            TodayR.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TodayR.ForeColor = Color.Transparent;
            TodayR.Location = new Point(22, 147);
            TodayR.Name = "TodayR";
            TodayR.Size = new Size(29, 36);
            TodayR.TabIndex = 4;
            TodayR.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(43, 13);
            label4.Name = "label4";
            label4.Size = new Size(195, 36);
            label4.TabIndex = 2;
            label4.Text = "Today's Revenue:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(41, 15, 102);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(TotalR);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(1060, 179);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 244);
            panel4.TabIndex = 13;
            // 
            // TotalR
            // 
            TotalR.AutoSize = true;
            TotalR.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalR.ForeColor = Color.Transparent;
            TotalR.Location = new Point(25, 146);
            TotalR.Name = "TotalR";
            TotalR.Size = new Size(29, 36);
            TotalR.TabIndex = 5;
            TotalR.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(76, 13);
            label5.Name = "label5";
            label5.Size = new Size(165, 36);
            label5.TabIndex = 3;
            label5.Text = "Total Revenue:";
            label5.Click += label5_Click;
            // 
            // AdminHomeWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = Properties.Resources.AdminHomeWindow_Vers1;
            ClientSize = new Size(1400, 900);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(AddMoviesBtn);
            Controls.Add(signoutbtn);
            Controls.Add(homebtn);
            Controls.Add(TicketHistoryBtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminHomeWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin | Home";
            Load += AdminHomeWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button signoutbtn;
        private Button TicketHistoryBtn;
        private Button homebtn;
        private Button AddMoviesBtn;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label TAdmins;
        private Label TUsers;
        private Label TodayR;
        private Label TotalR;
    }
}