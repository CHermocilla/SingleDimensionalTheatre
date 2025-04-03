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
    public partial class AdminCurrentMoviesRunningWindow : Form
    {
        public AdminCurrentMoviesRunningWindow()
        {
            InitializeComponent();
        }
       private void homebtn_Click(object sender, EventArgs e)
        {
            AdminHomeWindow ahw = new AdminHomeWindow();
            ahw.Show();
            this.Close();
        }

        private void CurrentMoviesRunningBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
        }

        private void AddMoviesBtn_Click(object sender, EventArgs e)
        {
            AdminAddMoviesWindow aamw = new AdminAddMoviesWindow();
            aamw.Show();
            this.Close();
        }

        private void CheckBookTicketBtn_Click(object sender, EventArgs e)
        {
            AdminTicketHistoryWindow acbtw = new AdminTicketHistoryWindow();
            acbtw.Show();
            this.Close();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to sign out?", "Single Dimensional Theatre", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                LoginWindow lw = new LoginWindow();
                lw.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                AdminHomeWindow ahw = new AdminHomeWindow();
                ahw.Show();
                this.Hide();
            }
        }

 
    }

}
