using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class UserCancelTicketWindow : Form
    {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");

        private int currentUserId; // Store the passed user ID

        public UserCancelTicketWindow(int userId)
        {
            InitializeComponent();
        }


        private void LoadAllBookings()
        {
            // Retrieve the current user ID from the session
            int currentUserId = currentUser.UserSession.CurrentUserId;

            // Modify the query to filter by the logged-in user's ID
            string query = "SELECT BOOKING_ID, MOVIE_TITLE, MOVIE_SHOWINGDATE, MOVIE_SHOWINGTIME, MOVIE_THEATRE FROM bookedtickets WHERE UNIQUE_ID = @UserId";

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UserId", currentUserId);

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


        private void homebtn_Click(object sender, EventArgs e)
        {
            UserHomeWindow uhw = new UserHomeWindow();
            uhw.Show();
            this.Close();
        }

        private void moviesbtn_Click(object sender, EventArgs e)
        {
            UserMoviesWindow umw = new UserMoviesWindow();
            umw.Show();
            this.Close();
        }

        private void bookticketbtn_Click(object sender, EventArgs e)
        {
            UserBookTicketsWindow ubtw = new UserBookTicketsWindow();
            ubtw.Show();
            this.Close();
        }

        private void cancelticketbtn_Click(object sender, EventArgs e)
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
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                UserHomeWindow uhw = new UserHomeWindow();
                uhw.Show();
                this.Close();
            }
        }

        private void UserCancelTicketWindow_Load(object sender, EventArgs e)
        {
            LoadAllBookings();
        }

        private void CancelTktBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Delete Booking ID: " + canceltxtbx.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();

                        // First, delete related records in bookingseats
                        string deleteSeatsQuery = "DELETE FROM bookingseats WHERE BOOKING_ID = @BOOKING_ID";

                        using (MySqlCommand deleteSeatsCmd = new MySqlCommand(deleteSeatsQuery, connection))
                        {
                            deleteSeatsCmd.Parameters.AddWithValue("@BOOKING_ID", canceltxtbx.Text.Trim());
                            deleteSeatsCmd.Parameters.AddWithValue("@UNIQUE_ID", currentUser.UserSession.CurrentUserId); // Filter by user ID
                            deleteSeatsCmd.ExecuteNonQuery();
                        }

                        // Then, delete the record in bookedtickets
                        string deleteBookingQuery = "DELETE FROM bookedtickets WHERE BOOKING_ID = @BOOKING_ID AND UNIQUE_ID = @UNIQUE_ID";

                        using (MySqlCommand deleteBookingCmd = new MySqlCommand(deleteBookingQuery, connection))
                        {
                            deleteBookingCmd.Parameters.AddWithValue("@BOOKING_ID", canceltxtbx.Text.Trim());
                            deleteBookingCmd.Parameters.AddWithValue("@UNIQUE_ID", currentUser.UserSession.CurrentUserId); // Filter by user ID
                            int rowsAffected = deleteBookingCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                clearallfields();
                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                UserCancelTicketWindow actw = new UserCancelTicketWindow(currentUser.UserSession.CurrentUserId);
                                actw.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No booking found under your account with this Booking ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }


        }
        private void clearallfields()
        {
            cancelticketbtn.Text = "";
        } // WORKING \\ //SELF-EXPLANATORY METHOD\\
    }

    }


