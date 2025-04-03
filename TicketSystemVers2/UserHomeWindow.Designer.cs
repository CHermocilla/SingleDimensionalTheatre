
namespace TicketSystemVers2
{
    partial class UserHomeWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomeWindow));
            panel1 = new Panel();
            signoutbtn = new Button();
            moviesbtn = new Button();
            cancelticketbtn = new Button();
            bookticketbtn = new Button();
            homebtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            featured1 = new PictureBox();
            featured2 = new PictureBox();
            featured3 = new PictureBox();
            featured4 = new PictureBox();
            usernametext = new Label();
            ((System.ComponentModel.ISupportInitialize)featured1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)featured2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)featured3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)featured4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Location = new Point(6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 1);
            panel1.TabIndex = 0;
            // 
            // signoutbtn
            // 
            signoutbtn.BackColor = Color.FromArgb(73, 5, 102);
            signoutbtn.FlatAppearance.BorderSize = 0;
            signoutbtn.FlatStyle = FlatStyle.Flat;
            signoutbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            signoutbtn.ForeColor = Color.Transparent;
            signoutbtn.Location = new Point(1027, 8);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(142, 50);
            signoutbtn.TabIndex = 8;
            signoutbtn.Text = "Sign Out";
            signoutbtn.UseVisualStyleBackColor = false;
            signoutbtn.Click += signoutbtn_Click;
            // 
            // moviesbtn
            // 
            moviesbtn.BackColor = Color.FromArgb(73, 5, 102);
            moviesbtn.FlatAppearance.BorderSize = 0;
            moviesbtn.FlatStyle = FlatStyle.Flat;
            moviesbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            moviesbtn.ForeColor = Color.Transparent;
            moviesbtn.Location = new Point(415, 8);
            moviesbtn.Name = "moviesbtn";
            moviesbtn.Size = new Size(142, 50);
            moviesbtn.TabIndex = 7;
            moviesbtn.Text = "Movies";
            moviesbtn.UseVisualStyleBackColor = false;
            moviesbtn.Click += moviesbtn_Click;
            // 
            // cancelticketbtn
            // 
            cancelticketbtn.BackColor = Color.FromArgb(73, 5, 102);
            cancelticketbtn.FlatAppearance.BorderSize = 0;
            cancelticketbtn.FlatStyle = FlatStyle.Flat;
            cancelticketbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            cancelticketbtn.ForeColor = Color.Transparent;
            cancelticketbtn.Location = new Point(820, 11);
            cancelticketbtn.Name = "cancelticketbtn";
            cancelticketbtn.Size = new Size(153, 47);
            cancelticketbtn.TabIndex = 6;
            cancelticketbtn.Text = "Cancel Ticket";
            cancelticketbtn.UseVisualStyleBackColor = false;
            cancelticketbtn.Click += cancelticketbtn_Click;
            // 
            // bookticketbtn
            // 
            bookticketbtn.BackColor = Color.FromArgb(73, 5, 102);
            bookticketbtn.FlatAppearance.BorderSize = 0;
            bookticketbtn.FlatStyle = FlatStyle.Flat;
            bookticketbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            bookticketbtn.ForeColor = Color.Transparent;
            bookticketbtn.Location = new Point(599, 11);
            bookticketbtn.Name = "bookticketbtn";
            bookticketbtn.Size = new Size(161, 47);
            bookticketbtn.TabIndex = 4;
            bookticketbtn.Text = "Book Tickets";
            bookticketbtn.UseVisualStyleBackColor = false;
            bookticketbtn.Click += bookticketbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.FromArgb(86, 7, 126);
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Franklin Gothic Heavy", 12F);
            homebtn.ForeColor = Color.Transparent;
            homebtn.Location = new Point(221, 7);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(142, 50);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // featured1
            // 
            featured1.BackgroundImageLayout = ImageLayout.Stretch;
            featured1.ErrorImage = Properties.Resources.ErrorBG;
            featured1.InitialImage = (Image)resources.GetObject("featured1.InitialImage");
            featured1.Location = new Point(80, 248);
            featured1.Name = "featured1";
            featured1.Size = new Size(263, 332);
            featured1.SizeMode = PictureBoxSizeMode.StretchImage;
            featured1.TabIndex = 9;
            featured1.TabStop = false;
            // 
            // featured2
            // 
            featured2.BackgroundImageLayout = ImageLayout.Stretch;
            featured2.ErrorImage = Properties.Resources.ErrorBG;
            featured2.InitialImage = (Image)resources.GetObject("featured2.InitialImage");
            featured2.Location = new Point(403, 248);
            featured2.Name = "featured2";
            featured2.Size = new Size(266, 332);
            featured2.SizeMode = PictureBoxSizeMode.StretchImage;
            featured2.TabIndex = 12;
            featured2.TabStop = false;
            // 
            // featured3
            // 
            featured3.BackgroundImageLayout = ImageLayout.Stretch;
            featured3.ErrorImage = Properties.Resources.ErrorBG;
            featured3.InitialImage = (Image)resources.GetObject("featured3.InitialImage");
            featured3.Location = new Point(718, 248);
            featured3.Name = "featured3";
            featured3.Size = new Size(257, 332);
            featured3.SizeMode = PictureBoxSizeMode.StretchImage;
            featured3.TabIndex = 15;
            featured3.TabStop = false;
            // 
            // featured4
            // 
            featured4.BackgroundImageLayout = ImageLayout.Stretch;
            featured4.ErrorImage = Properties.Resources.ErrorBG;
            featured4.InitialImage = (Image)resources.GetObject("featured4.InitialImage");
            featured4.Location = new Point(1044, 248);
            featured4.Name = "featured4";
            featured4.Size = new Size(260, 332);
            featured4.SizeMode = PictureBoxSizeMode.StretchImage;
            featured4.TabIndex = 18;
            featured4.TabStop = false;
            // 
            // usernametext
            // 
            usernametext.AutoSize = true;
            usernametext.BackColor = Color.Transparent;
            usernametext.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernametext.ForeColor = Color.Transparent;
            usernametext.Location = new Point(1274, 24);
            usernametext.Name = "usernametext";
            usernametext.Size = new Size(0, 23);
            usernametext.TabIndex = 21;
            // 
            // UserHomeWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 853);
            Controls.Add(usernametext);
            Controls.Add(featured4);
            Controls.Add(featured3);
            Controls.Add(featured2);
            Controls.Add(featured1);
            Controls.Add(signoutbtn);
            Controls.Add(moviesbtn);
            Controls.Add(cancelticketbtn);
            Controls.Add(panel1);
            Controls.Add(bookticketbtn);
            Controls.Add(homebtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "UserHomeWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Single Dimensional Theatre | Homepage";
            TopMost = true;
            Load += UserHomeWindow_Load_1;
            ((System.ComponentModel.ISupportInitialize)featured1).EndInit();
            ((System.ComponentModel.ISupportInitialize)featured2).EndInit();
            ((System.ComponentModel.ISupportInitialize)featured3).EndInit();
            ((System.ComponentModel.ISupportInitialize)featured4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button homebtn;
        private Button bookticketbtn;
        private Button cancelticketbtn;
        private Button signoutbtn;
        private Button moviesbtn;
        private System.Windows.Forms.Timer timer1;
        private PictureBox featured1;
        private PictureBox featured2;
        private PictureBox featured3;
        private PictureBox featured4;
        private Label usernametext;
    }
}
