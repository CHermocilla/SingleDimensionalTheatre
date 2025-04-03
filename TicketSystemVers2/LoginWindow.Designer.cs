namespace TicketSystemVers2
{
    partial class LoginWindow
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
            loginbtn = new Button();
            SDTInfobtn = new Label();
            usernamebox = new TextBox();
            registerbtn = new Label();
            passwordbox = new TextBox();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.None;
            loginbtn.BackColor = Color.FromArgb(0, 74, 173);
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.WhiteSmoke;
            loginbtn.Location = new Point(476, 302);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(303, 35);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Sign In";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // SDTInfobtn
            // 
            SDTInfobtn.AutoSize = true;
            SDTInfobtn.BackColor = Color.Transparent;
            SDTInfobtn.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SDTInfobtn.ForeColor = Color.DodgerBlue;
            SDTInfobtn.Location = new Point(626, 439);
            SDTInfobtn.Name = "SDTInfobtn";
            SDTInfobtn.Size = new Size(43, 21);
            SDTInfobtn.TabIndex = 7;
            SDTInfobtn.Text = "here";
            SDTInfobtn.Click += SDTInfobtn_Click;
            // 
            // usernamebox
            // 
            usernamebox.BackColor = Color.FromArgb(0, 74, 173);
            usernamebox.BorderStyle = BorderStyle.None;
            usernamebox.ForeColor = Color.WhiteSmoke;
            usernamebox.Location = new Point(477, 161);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(305, 20);
            usernamebox.TabIndex = 0;
            // 
            // registerbtn
            // 
            registerbtn.AutoSize = true;
            registerbtn.BackColor = Color.Transparent;
            registerbtn.Cursor = Cursors.Hand;
            registerbtn.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerbtn.ForeColor = Color.DodgerBlue;
            registerbtn.Location = new Point(647, 367);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(47, 21);
            registerbtn.TabIndex = 5;
            registerbtn.Text = "here.";
            registerbtn.Click += registerbtn1_Click;
            // 
            // passwordbox
            // 
            passwordbox.BackColor = Color.FromArgb(0, 74, 173);
            passwordbox.BorderStyle = BorderStyle.None;
            passwordbox.ForeColor = Color.WhiteSmoke;
            passwordbox.Location = new Point(479, 236);
            passwordbox.Name = "passwordbox";
            passwordbox.PasswordChar = '*';
            passwordbox.Size = new Size(303, 20);
            passwordbox.TabIndex = 1;
            passwordbox.UseSystemPasswordChar = true;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SDT_RevisedLoginWindow;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 500);
            Controls.Add(SDTInfobtn);
            Controls.Add(registerbtn);
            Controls.Add(usernamebox);
            Controls.Add(loginbtn);
            Controls.Add(passwordbox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LoginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SDT | Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginbtn;
        private Label SDTInfobtn;
        private TextBox usernamebox;
        private Label registerbtn;
        private TextBox passwordbox;
    }
}