namespace TicketSystemVers2
{
    partial class UserMoviesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMoviesWindow));
            movieidlbl = new Label();
            moviedescriplbl = new Label();
            movietitlelbl = new Label();
            moviegenrelbl = new Label();
            moviecastlbl = new Label();
            moviedirectorslbl = new Label();
            movieposterimg = new PictureBox();
            selectmoviecmbx = new ComboBox();
            homebtn = new Button();
            bookticketbtn = new Button();
            cancelticketbtn = new Button();
            moviesbtn = new Button();
            signoutbtn = new Button();
            movieratinglbl = new Label();
            moviepricelbl = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)movieposterimg).BeginInit();
            SuspendLayout();
            // 
            // movieidlbl
            // 
            movieidlbl.BackColor = Color.Transparent;
            movieidlbl.Font = new Font("Franklin Gothic Medium", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieidlbl.ForeColor = Color.WhiteSmoke;
            movieidlbl.Location = new Point(35, 116);
            movieidlbl.Name = "movieidlbl";
            movieidlbl.Size = new Size(537, 55);
            movieidlbl.TabIndex = 12;
            // 
            // moviedescriplbl
            // 
            moviedescriplbl.AutoEllipsis = true;
            moviedescriplbl.BackColor = Color.Transparent;
            moviedescriplbl.Font = new Font("Franklin Gothic Demi Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moviedescriplbl.ForeColor = Color.White;
            moviedescriplbl.Location = new Point(322, 628);
            moviedescriplbl.Name = "moviedescriplbl";
            moviedescriplbl.Size = new Size(610, 198);
            moviedescriplbl.TabIndex = 18;
            // 
            // movietitlelbl
            // 
            movietitlelbl.BackColor = Color.Transparent;
            movietitlelbl.Font = new Font("Franklin Gothic Demi Cond", 16.2F);
            movietitlelbl.ForeColor = Color.White;
            movietitlelbl.Location = new Point(321, 202);
            movietitlelbl.Name = "movietitlelbl";
            movietitlelbl.Size = new Size(610, 44);
            movietitlelbl.TabIndex = 19;
            // 
            // moviegenrelbl
            // 
            moviegenrelbl.BackColor = Color.Transparent;
            moviegenrelbl.Font = new Font("Franklin Gothic Demi Cond", 16.2F);
            moviegenrelbl.ForeColor = Color.White;
            moviegenrelbl.Location = new Point(321, 346);
            moviegenrelbl.Name = "moviegenrelbl";
            moviegenrelbl.Size = new Size(610, 40);
            moviegenrelbl.TabIndex = 20;
            // 
            // moviecastlbl
            // 
            moviecastlbl.BackColor = Color.Transparent;
            moviecastlbl.Font = new Font("Franklin Gothic Demi Cond", 16.2F);
            moviecastlbl.ForeColor = Color.White;
            moviecastlbl.Location = new Point(321, 492);
            moviecastlbl.Name = "moviecastlbl";
            moviecastlbl.Size = new Size(610, 44);
            moviecastlbl.TabIndex = 21;
            // 
            // moviedirectorslbl
            // 
            moviedirectorslbl.BackColor = Color.Transparent;
            moviedirectorslbl.Font = new Font("Franklin Gothic Demi Cond", 16.2F);
            moviedirectorslbl.ForeColor = Color.White;
            moviedirectorslbl.Location = new Point(321, 422);
            moviedirectorslbl.Name = "moviedirectorslbl";
            moviedirectorslbl.Size = new Size(610, 44);
            moviedirectorslbl.TabIndex = 22;
            moviedirectorslbl.Click += moviedirectorslbl_Click;
            // 
            // movieposterimg
            // 
            movieposterimg.BackColor = Color.Silver;
            movieposterimg.BackgroundImageLayout = ImageLayout.Stretch;
            movieposterimg.ErrorImage = Properties.Resources.ErrorBG;
            movieposterimg.InitialImage = Properties.Resources.Add_a_heading;
            movieposterimg.Location = new Point(975, 208);
            movieposterimg.Name = "movieposterimg";
            movieposterimg.Size = new Size(316, 399);
            movieposterimg.SizeMode = PictureBoxSizeMode.StretchImage;
            movieposterimg.TabIndex = 24;
            movieposterimg.TabStop = false;
            // 
            // selectmoviecmbx
            // 
            selectmoviecmbx.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectmoviecmbx.FormattingEnabled = true;
            selectmoviecmbx.Location = new Point(75, 97);
            selectmoviecmbx.Name = "selectmoviecmbx";
            selectmoviecmbx.Size = new Size(1279, 33);
            selectmoviecmbx.TabIndex = 25;
            selectmoviecmbx.SelectedIndexChanged += selectmoviecmbx_SelectedIndexChanged;
            selectmoviecmbx.SelectionChangeCommitted += selectmoviecmbx_SelectionChangeCommitted;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.FromArgb(73, 5, 102);
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Franklin Gothic Heavy", 12F);
            homebtn.ForeColor = Color.WhiteSmoke;
            homebtn.Location = new Point(309, 8);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(142, 44);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // bookticketbtn
            // 
            bookticketbtn.BackColor = Color.FromArgb(73, 5, 102);
            bookticketbtn.FlatAppearance.BorderSize = 0;
            bookticketbtn.FlatStyle = FlatStyle.Flat;
            bookticketbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            bookticketbtn.ForeColor = Color.WhiteSmoke;
            bookticketbtn.Location = new Point(671, 11);
            bookticketbtn.Name = "bookticketbtn";
            bookticketbtn.Size = new Size(161, 41);
            bookticketbtn.TabIndex = 4;
            bookticketbtn.Text = "Book Tickets";
            bookticketbtn.UseVisualStyleBackColor = false;
            bookticketbtn.Click += bookticketbtn_Click;
            // 
            // cancelticketbtn
            // 
            cancelticketbtn.BackColor = Color.FromArgb(73, 5, 102);
            cancelticketbtn.FlatAppearance.BorderSize = 0;
            cancelticketbtn.FlatStyle = FlatStyle.Flat;
            cancelticketbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            cancelticketbtn.ForeColor = Color.WhiteSmoke;
            cancelticketbtn.Location = new Point(886, 9);
            cancelticketbtn.Name = "cancelticketbtn";
            cancelticketbtn.Size = new Size(158, 44);
            cancelticketbtn.TabIndex = 6;
            cancelticketbtn.Text = "Cancel Ticket";
            cancelticketbtn.UseVisualStyleBackColor = false;
            cancelticketbtn.Click += cancelticketbtn_Click;
            // 
            // moviesbtn
            // 
            moviesbtn.BackColor = Color.FromArgb(86, 7, 126);
            moviesbtn.FlatAppearance.BorderSize = 0;
            moviesbtn.FlatStyle = FlatStyle.Flat;
            moviesbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            moviesbtn.ForeColor = Color.WhiteSmoke;
            moviesbtn.Location = new Point(485, 8);
            moviesbtn.Name = "moviesbtn";
            moviesbtn.Size = new Size(142, 44);
            moviesbtn.TabIndex = 7;
            moviesbtn.Text = "Movies";
            moviesbtn.UseVisualStyleBackColor = false;
            moviesbtn.Click += moviesbtn_Click;
            // 
            // signoutbtn
            // 
            signoutbtn.BackColor = Color.FromArgb(73, 5, 102);
            signoutbtn.FlatAppearance.BorderSize = 0;
            signoutbtn.FlatStyle = FlatStyle.Flat;
            signoutbtn.Font = new Font("Franklin Gothic Heavy", 12F);
            signoutbtn.ForeColor = Color.WhiteSmoke;
            signoutbtn.Location = new Point(1087, 11);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(142, 44);
            signoutbtn.TabIndex = 8;
            signoutbtn.Text = "Sign Out";
            signoutbtn.UseVisualStyleBackColor = false;
            signoutbtn.Click += signoutbtn_Click;
            // 
            // movieratinglbl
            // 
            movieratinglbl.BackColor = Color.Transparent;
            movieratinglbl.Font = new Font("Franklin Gothic Demi Cond", 16.2F);
            movieratinglbl.ForeColor = Color.White;
            movieratinglbl.Location = new Point(321, 269);
            movieratinglbl.Name = "movieratinglbl";
            movieratinglbl.Size = new Size(610, 44);
            movieratinglbl.TabIndex = 26;
            // 
            // moviepricelbl
            // 
            moviepricelbl.BackColor = Color.Transparent;
            moviepricelbl.Font = new Font("Franklin Gothic Demi Cond", 16.2F);
            moviepricelbl.ForeColor = Color.White;
            moviepricelbl.Location = new Point(321, 564);
            moviepricelbl.Name = "moviepricelbl";
            moviepricelbl.Size = new Size(610, 44);
            moviepricelbl.TabIndex = 27;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(73, 5, 102);
            button1.Font = new Font("Franklin Gothic Heavy", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(998, 763);
            button1.Name = "button1";
            button1.Size = new Size(302, 44);
            button1.TabIndex = 28;
            button1.Text = "Book Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserMoviesWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 853);
            Controls.Add(button1);
            Controls.Add(moviepricelbl);
            Controls.Add(movieratinglbl);
            Controls.Add(signoutbtn);
            Controls.Add(moviesbtn);
            Controls.Add(selectmoviecmbx);
            Controls.Add(cancelticketbtn);
            Controls.Add(movieposterimg);
            Controls.Add(bookticketbtn);
            Controls.Add(moviedirectorslbl);
            Controls.Add(homebtn);
            Controls.Add(moviecastlbl);
            Controls.Add(moviegenrelbl);
            Controls.Add(movietitlelbl);
            Controls.Add(moviedescriplbl);
            Controls.Add(movieidlbl);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserMoviesWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Single Dimensional Theatre | Movie Details";
            Load += UserMoviesWindow_Load;
            ((System.ComponentModel.ISupportInitialize)movieposterimg).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label movieidlbl;
        private Label moviedescriplbl;
        private Label movietitlelbl;
        private Label moviegenrelbl;
        private Label moviecastlbl;
        private Label moviedirectorslbl;
        private PictureBox movieposterimg;
        private ComboBox selectmoviecmbx;
        private Button homebtn;
        private Button bookticketbtn;
        private Button cancelticketbtn;
        private Button moviesbtn;
        private Button signoutbtn;
        private Label movieratinglbl;
        private Label moviepricelbl;
        private Button button1;
    }
}