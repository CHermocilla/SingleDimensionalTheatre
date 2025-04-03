namespace TicketSystemVers2
{
    partial class payment
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
            cardnumber = new TextBox();
            cardname1 = new TextBox();
            expmonth = new TextBox();
            expyear = new TextBox();
            cardcvv = new TextBox();
            button1 = new Button();
            gcash = new Label();
            maya = new Label();
            SuspendLayout();
            // 
            // cardnumber
            // 
            cardnumber.Location = new Point(60, 160);
            cardnumber.Name = "cardnumber";
            cardnumber.Size = new Size(310, 27);
            cardnumber.TabIndex = 0;
            // 
            // cardname1
            // 
            cardname1.Location = new Point(60, 233);
            cardname1.Name = "cardname1";
            cardname1.Size = new Size(310, 27);
            cardname1.TabIndex = 1;
            // 
            // expmonth
            // 
            expmonth.Location = new Point(60, 294);
            expmonth.Name = "expmonth";
            expmonth.Size = new Size(53, 27);
            expmonth.TabIndex = 2;
            // 
            // expyear
            // 
            expyear.Location = new Point(143, 294);
            expyear.Name = "expyear";
            expyear.Size = new Size(65, 27);
            expyear.TabIndex = 3;
            // 
            // cardcvv
            // 
            cardcvv.Location = new Point(284, 293);
            cardcvv.Name = "cardcvv";
            cardcvv.Size = new Size(86, 27);
            cardcvv.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(60, 406);
            button1.Name = "button1";
            button1.Size = new Size(310, 29);
            button1.TabIndex = 5;
            button1.Text = "Pay Now";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gcash
            // 
            gcash.BackColor = Color.Transparent;
            gcash.Location = new Point(469, 163);
            gcash.Name = "gcash";
            gcash.Size = new Size(161, 171);
            gcash.TabIndex = 7;
            gcash.Click += gcash_Click;
            // 
            // maya
            // 
            maya.BackColor = Color.Transparent;
            maya.Location = new Point(655, 160);
            maya.Name = "maya";
            maya.Size = new Size(173, 171);
            maya.TabIndex = 8;
            maya.Click += maya_Click;
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Copy_of_Copy_of_welcome_Back___6_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 503);
            Controls.Add(maya);
            Controls.Add(gcash);
            Controls.Add(button1);
            Controls.Add(cardcvv);
            Controls.Add(expyear);
            Controls.Add(expmonth);
            Controls.Add(cardname1);
            Controls.Add(cardnumber);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cardnumber;
        private TextBox cardname1;
        private TextBox expmonth;
        private TextBox expyear;
        private TextBox cardcvv;
        private Button button1;
        private Label gcash;
        private Label maya;
    }
}