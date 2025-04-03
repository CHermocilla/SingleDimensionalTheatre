namespace TicketSystemVers2
{
    partial class AdminCurrentMoviesRunningWindow
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
            panel2 = new Panel();
            AddMoviesBtn = new Button();
            signoutbtn = new Button();
            CurrentMoviesRunningBtn = new Button();
            CheckBookTicketBtn = new Button();
            homebtn = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gold;
            panel2.Controls.Add(AddMoviesBtn);
            panel2.Controls.Add(signoutbtn);
            panel2.Controls.Add(CurrentMoviesRunningBtn);
            panel2.Controls.Add(CheckBookTicketBtn);
            panel2.Controls.Add(homebtn);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 68);
            panel2.TabIndex = 4;
            // 
            // AddMoviesBtn
            // 
            AddMoviesBtn.BackColor = Color.Gold;
            AddMoviesBtn.FlatAppearance.BorderSize = 0;
            AddMoviesBtn.FlatStyle = FlatStyle.Flat;
            AddMoviesBtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddMoviesBtn.Location = new Point(523, 7);
            AddMoviesBtn.Name = "AddMoviesBtn";
            AddMoviesBtn.Size = new Size(142, 55);
            AddMoviesBtn.TabIndex = 9;
            AddMoviesBtn.Text = "Add Movies";
            AddMoviesBtn.UseVisualStyleBackColor = false;
            AddMoviesBtn.Click += AddMoviesBtn_Click;
            // 
            // signoutbtn
            // 
            signoutbtn.BackColor = Color.Gold;
            signoutbtn.FlatAppearance.BorderSize = 0;
            signoutbtn.FlatStyle = FlatStyle.Flat;
            signoutbtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signoutbtn.Location = new Point(907, 7);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(142, 55);
            signoutbtn.TabIndex = 8;
            signoutbtn.Text = "Sign Out";
            signoutbtn.UseVisualStyleBackColor = false;
            signoutbtn.Click += signoutbtn_Click;
            // 
            // CurrentMoviesRunningBtn
            // 
            CurrentMoviesRunningBtn.BackColor = Color.Gold;
            CurrentMoviesRunningBtn.FlatAppearance.BorderSize = 0;
            CurrentMoviesRunningBtn.FlatStyle = FlatStyle.Flat;
            CurrentMoviesRunningBtn.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CurrentMoviesRunningBtn.Location = new Point(344, 6);
            CurrentMoviesRunningBtn.Name = "CurrentMoviesRunningBtn";
            CurrentMoviesRunningBtn.Size = new Size(142, 55);
            CurrentMoviesRunningBtn.TabIndex = 7;
            CurrentMoviesRunningBtn.Text = "Current Movies Running";
            CurrentMoviesRunningBtn.UseVisualStyleBackColor = false;
            CurrentMoviesRunningBtn.Click += CurrentMoviesRunningBtn_Click;
            // 
            // CheckBookTicketBtn
            // 
            CheckBookTicketBtn.BackColor = Color.Gold;
            CheckBookTicketBtn.FlatAppearance.BorderSize = 0;
            CheckBookTicketBtn.FlatStyle = FlatStyle.Flat;
            CheckBookTicketBtn.Font = new Font("Britannic Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckBookTicketBtn.Location = new Point(718, 8);
            CheckBookTicketBtn.Name = "CheckBookTicketBtn";
            CheckBookTicketBtn.Size = new Size(142, 55);
            CheckBookTicketBtn.TabIndex = 4;
            CheckBookTicketBtn.Text = "Check Booked Tickets";
            CheckBookTicketBtn.UseVisualStyleBackColor = false;
            CheckBookTicketBtn.Click += CheckBookTicketBtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.Gold;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homebtn.Location = new Point(167, 7);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(142, 55);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // AdminCurrentMoviesRunningWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1200, 800);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminCurrentMoviesRunningWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminCurrentMoviesRunningWindow";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button AddMoviesBtn;
        private Button signoutbtn;
        private Button CurrentMoviesRunningBtn;
        private Button CheckBookTicketBtn;
        private Button homebtn;
    }
}