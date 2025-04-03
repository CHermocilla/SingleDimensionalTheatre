namespace TicketSystemVers2
{
    partial class RegistrationWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationWindow));
            namebox = new TextBox();
            emailbox = new TextBox();
            passwordbox1 = new TextBox();
            usernamebox1 = new TextBox();
            registerbtn = new Button();
            xbtn = new Button();
            loginbtn = new Label();
            SuspendLayout();
            // 
            // namebox
            // 
            namebox.BackColor = Color.FromArgb(0, 74, 173);
            namebox.BorderStyle = BorderStyle.None;
            namebox.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namebox.ForeColor = Color.WhiteSmoke;
            namebox.Location = new Point(50, 126);
            namebox.Name = "namebox";
            namebox.Size = new Size(313, 23);
            namebox.TabIndex = 1;
            // 
            // emailbox
            // 
            emailbox.BackColor = Color.FromArgb(0, 74, 173);
            emailbox.BorderStyle = BorderStyle.None;
            emailbox.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.ForeColor = Color.WhiteSmoke;
            emailbox.Location = new Point(52, 180);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(313, 23);
            emailbox.TabIndex = 2;
            // 
            // passwordbox1
            // 
            passwordbox1.BackColor = Color.FromArgb(0, 74, 173);
            passwordbox1.BorderStyle = BorderStyle.None;
            passwordbox1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordbox1.ForeColor = Color.WhiteSmoke;
            passwordbox1.Location = new Point(43, 282);
            passwordbox1.Name = "passwordbox1";
            passwordbox1.PasswordChar = '*';
            passwordbox1.Size = new Size(311, 23);
            passwordbox1.TabIndex = 4;
            passwordbox1.UseSystemPasswordChar = true;
            // 
            // usernamebox1
            // 
            usernamebox1.BackColor = Color.FromArgb(0, 74, 173);
            usernamebox1.BorderStyle = BorderStyle.None;
            usernamebox1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamebox1.ForeColor = Color.WhiteSmoke;
            usernamebox1.Location = new Point(54, 229);
            usernamebox1.Name = "usernamebox1";
            usernamebox1.Size = new Size(309, 23);
            usernamebox1.TabIndex = 3;
            // 
            // registerbtn
            // 
            registerbtn.Anchor = AnchorStyles.None;
            registerbtn.BackColor = Color.FromArgb(0, 74, 173);
            registerbtn.Cursor = Cursors.Hand;
            registerbtn.FlatAppearance.BorderSize = 0;
            registerbtn.FlatStyle = FlatStyle.Flat;
            registerbtn.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerbtn.ForeColor = Color.WhiteSmoke;
            registerbtn.Location = new Point(32, 374);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(333, 34);
            registerbtn.TabIndex = 5;
            registerbtn.Text = "Sign Up";
            registerbtn.UseVisualStyleBackColor = false;
            registerbtn.Click += registerbtn_Click;
            // 
            // xbtn
            // 
            xbtn.Anchor = AnchorStyles.None;
            xbtn.BackColor = Color.FromArgb(64, 0, 0);
            xbtn.FlatAppearance.BorderSize = 0;
            xbtn.FlatStyle = FlatStyle.Flat;
            xbtn.Font = new Font("Bauhaus 93", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xbtn.ForeColor = Color.WhiteSmoke;
            xbtn.Location = new Point(650, -101);
            xbtn.Name = "xbtn";
            xbtn.Size = new Size(50, 50);
            xbtn.TabIndex = 6;
            xbtn.Text = "X";
            xbtn.UseVisualStyleBackColor = false;
            xbtn.Click += xbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.AutoSize = true;
            loginbtn.BackColor = Color.Transparent;
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.DodgerBlue;
            loginbtn.Location = new Point(278, 417);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(44, 23);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "here";
            loginbtn.Click += label1_Click;
            // 
            // RegistrationWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 500);
            Controls.Add(loginbtn);
            Controls.Add(xbtn);
            Controls.Add(registerbtn);
            Controls.Add(passwordbox1);
            Controls.Add(usernamebox1);
            Controls.Add(emailbox);
            Controls.Add(namebox);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "RegistrationWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SDT | Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox namebox;
        private TextBox emailbox;
        private TextBox passwordbox1;
        private TextBox usernamebox1;
        private Button registerbtn;
        private Button xbtn;
        private Label loginbtn;
    }
}