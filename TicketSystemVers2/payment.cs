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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Processing.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Payment Accepted. Redirecting.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }

        private void gcash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to 3rd Party Payment Method.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Payment Accepted. Redirecting.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void maya_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Redirecting to 3rd Party Payment Method.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Payment Accepted. Redirecting.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
