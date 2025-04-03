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
    public partial class AdminTicketHistoryWindow : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");

        public AdminTicketHistoryWindow()
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
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
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

        private void AdminTicketHistoryWindow_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT `UNIQUE_ID`, `NAME`, `EMAIL` from users";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable userTable = new DataTable();
                    adapter.Fill(userTable);

                    // Bind the result to the DataGridView
                    dataGridView2.DataSource = userTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }



        }
        private void LoadAllBookings()
        {
            string query = "SELECT BOOKING_ID, MOVIE_TITLE, MOVIE_SHOWINGDATE, MOVIE_SHOWINGTIME, MOVIE_THEATRE FROM bookedtickets";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable bookingsTable = new DataTable();
                    adapter.Fill(bookingsTable);

                    // Bind the result to the DataGridView
                    dataGridView1.DataSource = bookingsTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Delete Booking ID: " + AdminCancelTixbx.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    // First, delete related records in bookingseats
                    string deleteSeatsQuery = "DELETE FROM bookingseats WHERE BOOKING_ID = @BOOKING_ID";

                    using (MySqlCommand deleteSeatsCmd = new MySqlCommand(deleteSeatsQuery, connection))
                    {
                        deleteSeatsCmd.Parameters.AddWithValue("@BOOKING_ID", AdminCancelTixbx.Text.Trim());
                        deleteSeatsCmd.ExecuteNonQuery();
                    }

                    // Then, delete the record in bookedtickets
                    string deleteBookingQuery = "DELETE FROM bookedtickets WHERE BOOKING_ID = @BOOKING_ID";

                    using (MySqlCommand deleteBookingCmd = new MySqlCommand(deleteBookingQuery, connection))
                    {
                        deleteBookingCmd.Parameters.AddWithValue("@BOOKING_ID", AdminCancelTixbx.Text.Trim());
                        int rowsAffected = deleteBookingCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            AdminTicketHistoryWindow athw = new AdminTicketHistoryWindow();
                            athw.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No booking found with the provided Booking ID.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

            private void userchckbtn_Click(object sender, EventArgs e)
            {
                // Get the user ID entered in the UserIDTxbx TextBox
                if (int.TryParse(UserIDTxbx.Text.Trim(), out int searchedUserId))
                {
                    string query = "SELECT BOOKING_ID, MOVIE_TITLE, MOVIE_SHOWINGDATE, MOVIE_SHOWINGTIME, MOVIE_THEATRE FROM bookedtickets WHERE UNIQUE_ID = @UserId";

                    try
                    {
                        if (connection.State == ConnectionState.Closed)
                        {
                            connection.Open();
                        }

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            // Bind the searched user ID to the query parameter
                            cmd.Parameters.AddWithValue("@UserId", searchedUserId);

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            DataTable bookingsTable = new DataTable();
                            adapter.Fill(bookingsTable);

                            // Display the result in dataGridView1
                            dataGridView1.DataSource = bookingsTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading bookings: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid User ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }