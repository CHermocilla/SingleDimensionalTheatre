namespace TicketSystemVers2
{
    partial class LoadingScreen
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
            components = new System.ComponentModel.Container();
            loadingbar = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // loadingbar
            // 
            loadingbar.BackColor = Color.DarkGray;
            loadingbar.ForeColor = Color.LightGray;
            loadingbar.Location = new Point(446, 391);
            loadingbar.Name = "loadingbar";
            loadingbar.Size = new Size(450, 21);
            loadingbar.Style = ProgressBarStyle.Continuous;
            loadingbar.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Single_Dimensional_Theatre__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1200, 650);
            Controls.Add(loadingbar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingScreen";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar loadingbar;
        private System.Windows.Forms.Timer timer1;
    }
}