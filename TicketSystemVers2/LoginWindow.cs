using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.X509Certificates;

namespace TicketSystemVers2
{
    public partial class LoginWindow : Form
    {

        MySqlConnection connect = new MySqlConnection("datasource = localhost; port=3306;username=root;password=root;database=movieticketingsystem");



        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void xbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerbtn1_Click(object sender, EventArgs e)
        {
            RegistrationWindow rw = new RegistrationWindow();
            Visible = false;
            rw.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text == "" || passwordbox.Text == "")
            {
                MessageBox.Show("Please fill all the blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();


                        String selectData = "SELECT UNIQUE_ID, Role FROM users WHERE username = @username AND password = @password";
                        using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", usernamebox.Text);
                            cmd.Parameters.AddWithValue("@password", passwordbox.Text);
                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count == 1)
                            {

                                currentUser.UserSession.CurrentUserId = Convert.ToInt32(table.Rows[0]["UNIQUE_ID"]);

                                switch (table.Rows[0]["Role"] as string)
                                {
                                    case "Admin":
                                        {
                                            MessageBox.Show("Admin login successful.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            this.Hide();
                                            AdminHomeWindow ah = new AdminHomeWindow();
                                            ah.Show();
                                            break;
                                        }

                                    case "User":
                                        {
                                            MessageBox.Show("User login successful.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            int currentUserId = Convert.ToInt32(table.Rows[0]["UNIQUE_ID"]);

                                            this.Hide();
                                            UserHomeWindow uhw = new UserHomeWindow();
                                            uhw.Show();
                                            break;
                                        }

                                    default:
                                        {
                                            break;
                                        }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting to database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void SDTInfobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SDTTeam sdt = new SDTTeam();
            sdt.Show();
        }
    }
}
