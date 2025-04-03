using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketSystemVers2
{
    public partial class AdminAddMoviesWindow : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");

        public AdminAddMoviesWindow()
        {
            InitializeComponent();
        }
        private void clearallfields()
        {
            movieidtxtbx.Text = "";
            movietitletxtbx.Text = "";
            moviegenretxtbx.Text = "";
            moviedirectorstxtbx.Text = "";
            moviecasttxtbx.Text = "";
            moviedescriptxtbx.Text = "";
            movieposterurltxtbx.Text = "";
            deletemovietxtbx.Text = "";
        } // WORKING \\ //SELF-EXPLANATORY METHOD\\
        public bool emptyfieldboxes()
        {
            if (movieidtxtbx.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        } // SELF-EXPLANATORY METHOD\\

        private void datagridviewfill()
        {
            connection.Open();
            string query = "SELECT * from moviedetails";
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(query, connection);
            DataTable datatable1 = new DataTable();
            adapter1.Fill(datatable1);
            dataGridView1.DataSource = datatable1;
            connection.Close();
        }
        private void homebtn_Click(object sender, EventArgs e) // WORKING
        {
            AdminHomeWindow ahw = new AdminHomeWindow();
            ahw.Show();
            this.Close();
        }
        private void CurrentMoviesRunningBtn_Click(object sender, EventArgs e) // WORKING
        {
            AdminTicketHistoryWindow athw = new AdminTicketHistoryWindow();
            athw.Show();
            this.Close();
        }
        private void AddMoviesBtn_Click(object sender, EventArgs e) // WORKING
        {
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
        }

        private void CheckBookTicketBtn_Click(object sender, EventArgs e)//WORKING
        {
            AdminTicketHistoryWindow acbtw = new AdminTicketHistoryWindow();
            acbtw.Show();
            this.Close();
        }

        private void signoutbtn_Click(object sender, EventArgs e)// WORKING
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
                AdminHomeWindow ahw = new AdminHomeWindow(); //AdminHomeWindow is the name of your next form
                ahw.Show(); // .Show(); shows the next form
                this.Hide(); // this.Hide(); hides the current window
            }
        }


        private void AdminAddMoviesWindow_Load(object sender, EventArgs e)
        {
            datagridviewfill();
        }

        private void addmoviebtn_Click(object sender, EventArgs e) // WORKING
        {

            if (movietitletxtbx.Text == "" || moviegenretxtbx.Text == "" || moviecasttxtbx.Text == "" || moviedirectorstxtbx.Text == "" || moviedatepicker.Text == "" || movietimepicker.Text == "" || moviedescriptxtbx.Text == "" || movieposterurltxtbx.Text == "" || movieratingcmbx.Text == "" || moviepricetxtbx.Text == "")
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (connection.State == ConnectionState.Closed)
                {
                    try
                    {
                        connection.Open();

                        String showingdatetxt = moviedatepicker.Value.ToString("yyyy-MM-dd");

                        string insertMovie = "INSERT INTO moviedetails ( MOVIE_TITLE, MOVIE_GENRE, MOVIE_CAST, MOVIE_DIRECTORS, MOVIE_DESCRIPTION, MOVIE_RATING, MOVIE_POSTERURL, MOVIE_SHOWINGDATE, MOVIE_SHOWINGTIME, MOVIE_THEATRE, MOVIE_PRICE) " +
                        "VALUES( @MOVIE_TITLE, @MOVIE_GENRE, @MOVIE_CAST, @MOVIE_DIRECTORS, @MOVIE_DESCRIPTION, @MOVIE_RATING, @MOVIE_POSTERURL, @MOVIE_SHOWINGDATE, @MOVIE_SHOWINGTIME, @MOVIE_THEATRE, @MOVIE_PRICE)";

                        using (MySqlCommand cmd = new MySqlCommand(insertMovie, connection))
                        {
                            //cmd.Parameters.AddWithValue("@MOVIE_ID", movieidtxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_TITLE", movietitletxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_GENRE", moviegenretxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_CAST", moviecasttxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_DIRECTORS", moviedirectorstxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_DESCRIPTION", moviedescriptxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_POSTERURL", movieposterurltxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("MOVIE_RATING", movieratingcmbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_SHOWINGDATE", showingdatetxt);
                            cmd.Parameters.AddWithValue("@MOVIE_SHOWINGTIME", movietimepicker.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_PRICE", moviepricetxtbx.Text.Trim());
                            cmd.Parameters.AddWithValue("@MOVIE_THEATRE", movietheatrecmbx.Text.Trim());

                            cmd.ExecuteNonQuery();

                            connection.Close();

                            MessageBox.Show("Movie added succesfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            DialogResult check = MessageBox.Show("Do you want to add another date or time with this movie you added?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (check == DialogResult.Yes)
                            {
                                //RETAINS ALL DATA IN TEXT BOXES
                            }
                            else
                            {
                                clearallfields();

                                AdminAddMoviesWindow aamw = new AdminAddMoviesWindow();
                                aamw.Show();
                                this.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void deletemoviebtn_Click(object sender, EventArgs e) //SOMEHOW WORKING, ADD AN ERROR TO WHEN ID DOESN'T EXIST 
        {

            if (emptyfieldboxes())
            {
                MessageBox.Show("Please input a valid movie ID", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete Movie ID: " + deletemovietxtbx.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        try
                        {
                            connection.Open();

                            string updateData = "DELETE from moviedetails WHERE MOVIE_ID = @MOVIE_ID";

                            using (MySqlCommand updateD = new MySqlCommand(updateData, connection))
                            {
                                updateD.Parameters.AddWithValue("@MOVIE_ID", deletemovietxtbx.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearallfields();

                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminAddMoviesWindow aamw = new AdminAddMoviesWindow();
                                aamw.Show();
                                this.Close();


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
        }

        private void deletemoviecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        } //don't delete

        private void label1_Click(object sender, EventArgs e)
        {

        } //don't delete

        private void displaycmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("select * from featuredmovies", connection);

        }

        private void tryimagebtn_Click(object sender, EventArgs e)
        {

        }

        private void updatefeaturedbtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();

                    // Determine which column to update based on the combobox selection
                    string selectedDisplay = displaycmbx.SelectedItem.ToString();
                    string columnName = "";

                    switch (selectedDisplay)
                    {
                        case "Display 1":
                            columnName = "Display1";
                            break;
                        case "Display 2":
                            columnName = "Display2";
                            break;
                        case "Display 3":
                            columnName = "Display3";
                            break;
                        case "Display 4":
                            columnName = "Display4";
                            break;
                        default:
                            MessageBox.Show("Please select a valid display option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                    }

                    // Construct the query dynamically
                    string query = $"UPDATE featuredmovies SET {columnName} = @PosterURL";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@PosterURL", updposterurl.Text.Trim());

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Poster updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear all fields and reset the form
                        clearallfields();

                        AdminAddMoviesWindow aamw = new AdminAddMoviesWindow();
                        aamw.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}


