using MySql.Data.MySqlClient;
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
    public partial class AdminHomeWindow : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter dataadapter = new MySqlDataAdapter();
        MySqlDataReader reader;

        public AdminHomeWindow()
        {
            InitializeComponent();
        }
        private void homebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
        }

        private void CurrentMoviesRunningBtn_Click(object sender, EventArgs e)
        {
            AdminTicketHistoryWindow athw = new AdminTicketHistoryWindow();
            athw.Show();
            this.Close();
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

        private void AdminHomeWindow_Load(object sender, EventArgs e)
        {
            displayTotalAdmins();
            displayTotalUsers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void displayTotalIncome()
        {

            //connect.Open();

            string selectData = "SELECT SUM(total_price) FROM totalrevenue";

            using (MySqlCommand cmd = new MySqlCommand(selectData, connection))
            {

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    TotalR.Text = "Php" + count.ToString("0.00");
                }

                reader.Close();
            }
        }


        public void displayTodaysIncome()
        {

            //connection.Open();

            string selectData = "SELECT sum(TOTAL_PRICE) FROM totalrevenue WHERE TOTALPRICE_BOOKINGDATE = @TOTALPRICE_BOOKINGDATE";

            using (MySqlCommand cmd = new MySqlCommand(selectData, connection))
            {
                DateTime today = DateTime.Today;
                string getToday = today.ToString("yyyy-MM-dd");

                cmd.Parameters.AddWithValue("@TOTALPRICE_BOOKINGDATE", getToday);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    object value = reader[0];

                    if (value != DBNull.Value)
                    {
                        float count = Convert.ToSingle(reader[0]);
                        TodayR.Text = "Php" + count.ToString("0.00");
                    }
                }

                reader.Close();
            }
        }
        public void displayTotalUsers()
        {
            //connection.Open();

            string selectData = "SELECT * FROM users WHERE role = @role";

            using (MySqlCommand cmd = new MySqlCommand(selectData, connection))
            {
                cmd.Parameters.AddWithValue("@role", "User");

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    TUsers.Text = count.ToString();
                }

                reader.Close();
            }
        }

        public void displayTotalAdmins()
        {
            connection.Open();

            string selectData = "SELECT * FROM users WHERE role = @role";

            using (MySqlCommand cmd = new MySqlCommand(selectData, connection))
            {
                cmd.Parameters.AddWithValue("@role", "Admin");

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = Convert.ToInt32(reader[0]);
                    TAdmins.Text = count.ToString();
                }

                reader.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


   