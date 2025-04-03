using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystemVers2
{
    public partial class LoadingScreen : Form

    {

        
        public LoadingScreen()
        {
            InitializeComponent();
            loadingbar.ForeColor = Color.Maroon;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            loadingbar.Increment(2);
            if (loadingbar.Value == 100)
            {
                timer1.Enabled = false;
                LoginWindow loginWindow = new LoginWindow();
                loginWindow.Show();
                this.Hide();
            }
        }
    }
}
