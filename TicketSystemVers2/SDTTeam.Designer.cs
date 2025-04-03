namespace TicketSystemVers2
{
    partial class SDTTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SDTTeam));
            button2 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(301, 508);
            button2.Name = "button2";
            button2.Size = new Size(256, 33);
            button2.TabIndex = 1;
            button2.Text = "Return";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SDTTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 553);
            Controls.Add(button2);
            Name = "SDTTeam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SDTTeam";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
    }
}