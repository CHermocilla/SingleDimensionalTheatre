namespace TicketSystemVers2
{
    partial class UserCancelTicketWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCancelTicketWindow));
            signoutbtn = new Button();
            moviesbtn = new Button();
            cancelticketbtn = new Button();
            bookticketbtn = new Button();
            homebtn = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            canceltxtbx = new TextBox();
            CancelTktBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // signoutbtn
            // 
            signoutbtn.BackColor = Color.FromArgb(73, 5, 102);
            signoutbtn.FlatAppearance.BorderSize = 0;
            signoutbtn.FlatStyle = FlatStyle.Flat;
            signoutbtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signoutbtn.ForeColor = Color.White;
            signoutbtn.Location = new Point(1092, 2);
            signoutbtn.Name = "signoutbtn";
            signoutbtn.Size = new Size(142, 55);
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
            moviesbtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moviesbtn.ForeColor = Color.White;
            moviesbtn.Location = new Point(476, 2);
            moviesbtn.Name = "moviesbtn";
            moviesbtn.Size = new Size(142, 55);
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
            cancelticketbtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelticketbtn.ForeColor = Color.White;
            cancelticketbtn.Location = new Point(886, 2);
            cancelticketbtn.Name = "cancelticketbtn";
            cancelticketbtn.Size = new Size(142, 55);
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
            bookticketbtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookticketbtn.ForeColor = Color.White;
            bookticketbtn.Location = new Point(665, 2);
            bookticketbtn.Name = "bookticketbtn";
            bookticketbtn.Size = new Size(161, 55);
            bookticketbtn.TabIndex = 4;
            bookticketbtn.Text = "Book Tickets";
            bookticketbtn.UseVisualStyleBackColor = false;
            bookticketbtn.Click += bookticketbtn_Click;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.FromArgb(73, 5, 102);
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homebtn.ForeColor = Color.White;
            homebtn.Location = new Point(300, 2);
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
            dataGridView1.Location = new Point(64, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1284, 521);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(167, 743);
            label1.Name = "label1";
            label1.Size = new Size(598, 38);
            label1.TabIndex = 10;
            label1.Text = "Input the booking ID of the movie you want to cancel:";
            // 
            // canceltxtbx
            // 
            canceltxtbx.Location = new Point(819, 753);
            canceltxtbx.Name = "canceltxtbx";
            canceltxtbx.Size = new Size(160, 27);
            canceltxtbx.TabIndex = 11;
            // 
            // CancelTktBtn
            // 
            CancelTktBtn.BackColor = Color.Maroon;
            CancelTktBtn.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelTktBtn.ForeColor = Color.Transparent;
            CancelTktBtn.Location = new Point(1020, 742);
            CancelTktBtn.Name = "CancelTktBtn";
            CancelTktBtn.Size = new Size(166, 48);
            CancelTktBtn.TabIndex = 12;
            CancelTktBtn.Text = "Cancel Ticket";
            CancelTktBtn.UseVisualStyleBackColor = false;
            CancelTktBtn.Click += CancelTktBtn_Click;
            // 
            // UserCancelTicketWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1400, 900);
            Controls.Add(CancelTktBtn);
            Controls.Add(canceltxtbx);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(signoutbtn);
            Controls.Add(moviesbtn);
            Controls.Add(homebtn);
            Controls.Add(cancelticketbtn);
            Controls.Add(bookticketbtn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UserCancelTicketWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Single Dimensional Theatre | Booking History";
            Load += UserCancelTicketWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signoutbtn;
        private Button moviesbtn;
        private Button cancelticketbtn;
        private Button bookticketbtn;
        private Button homebtn;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox canceltxtbx;
        private Button CancelTktBtn;
    }
}