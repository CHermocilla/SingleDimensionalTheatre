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
using static System.Net.Mime.MediaTypeNames;

namespace TicketSystemVers2
{
    public partial class RegistrationWindow : Form
    {
        MySqlConnection connect = new MySqlConnection("datasource = localhost; port=3306;username=root;password=root;database=movieticketingsystem");

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void xbtn_Click(object sender, EventArgs e)
        {
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (namebox.Text == "" || emailbox.Text == "" || usernamebox1.Text == "" || passwordbox1.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM users WHERE username = '"
                            + usernamebox1.Text.Trim() + "'";   // users is the table name

                        using (MySqlCommand checkUser = new MySqlCommand(checkUsername, connect))
                        {
                            MySqlDataAdapter adapter = new MySqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(usernamebox1.Text + " already exists.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            else if (passwordbox1.Text.Length <= 8)
                            {
                                MessageBox.Show("The password length should be greater than or equal to 8 characters. Includes numbers and letters.");
                            }

                            else
                            {
                                string insertData = "INSERT INTO users (unique_ID, name, email, username, password, role) " +
                                    "VALUES(@unique_ID, @name, @email, @username, @password, 'User')";

                                using (MySqlCommand cmd = new MySqlCommand(insertData, connect))
                                {
                                    string custnum1 = "";
                                    System.Random rand = new System.Random((int)System.DateTime.Now.Ticks);
                                    int random = rand.Next(1, 1000000);
                                    custnum1 = random.ToString();
                                    //custnum1 = custnum1;

                                    cmd.Parameters.AddWithValue("@unique_ID", custnum1);
                                    cmd.Parameters.AddWithValue("@name", namebox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@email", emailbox.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", usernamebox1.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", passwordbox1.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Go back to login

                                    LoginWindow lw = new LoginWindow();
                                    lw.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error connecting to database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}

