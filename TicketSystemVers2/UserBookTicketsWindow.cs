using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Org.BouncyCastle.Math.EC.ECCurve;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Button = System.Windows.Forms.Button;
using System.Drawing.Printing;



namespace TicketSystemVers2
{
    public partial class UserBookTicketsWindow : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter dataadapter = new MySqlDataAdapter();
        MySqlDataReader reader;
        DataSet dataset1 = new DataSet();
        DataSet dataset2 = new DataSet();
        DataSet dataset3 = new DataSet();
        DataSet dataset4 = new DataSet();
        DataTable datatable1 = new DataTable();


        public UserBookTicketsWindow()
        {
            InitializeComponent();
            dataadapter.SelectCommand = new MySqlCommand("select DISTINCT MOVIE_TITLE from moviedetails", connection);
            dataadapter.Fill(dataset1);
            MovieCMBX.DataSource = dataset1.Tables[0];
            MovieCMBX.DisplayMember = "MOVIE_TITLE";
            MovieCMBX.ValueMember = "MOVIE_TITLE";
            TheatreCMBX.Enabled = false;
            DateCMBX.Enabled = false;
            TimeCMBX.Enabled = false;

        }
        private void MovieCMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MovieCMBX != null)
            {

                MySqlCommand cmd = new MySqlCommand("select DISTINCT MOVIE_THEATRE from moviedetails WHERE MOVIE_TITLE=@MOVIE_TITLE", connection);
                cmd.Parameters.AddWithValue("@MOVIE_TITLE", MovieCMBX.SelectedValue.ToString());
                dataadapter.SelectCommand = new MySqlCommand("select DISTINCT MOVIE_THEATRE from moviedetails", connection);

                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                dataadapter.Fill(ds2);
                TheatreCMBX.DataSource = ds2.Tables[0];
                TheatreCMBX.DisplayMember = "MOVIE_THEATRE";
                TheatreCMBX.ValueMember = "MOVIE_THEATRE";
                TheatreCMBX.Enabled = true;
                DateCMBX.Enabled = false;
                TimeCMBX.Enabled = false;
            }
        }
        private void TheatreCMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TheatreCMBX != null)
            {

                dataadapter.SelectCommand = new MySqlCommand("select DISTINCT MOVIE_SHOWINGDATE from moviedetails", connection);

                //cmd.Parameters.AddWithValue("@MOVIE_THEATRE", TheatreCMBX.SelectedValue.ToString());   

                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                DataSet ds3 = new DataSet();
                dataadapter.Fill(ds3);
                DateCMBX.DataSource = ds3.Tables[0];
                DateCMBX.DisplayMember = "MOVIE_SHOWINGDATE";
                DateCMBX.ValueMember = "MOVIE_SHOWINGDATE";
                TheatreCMBX.Enabled = true;
                DateCMBX.Enabled = true;
                TimeCMBX.Enabled = false;
            }
        }
        private void DateCMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DateCMBX != null)
            {
                dataadapter.SelectCommand = new MySqlCommand("select DISTINCT MOVIE_SHOWINGTIME from moviedetails", connection);

                //cmd.Parameters.AddWithValue("@MOVIE_TITLE", MovieCMBX.SelectedValue.ToString());   

                MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                DataSet ds4 = new DataSet();
                dataadapter.Fill(ds4);
                TimeCMBX.DataSource = ds4.Tables[0];
                TimeCMBX.DisplayMember = "MOVIE_SHOWINGTIME";
                TimeCMBX.ValueMember = "MOVIE_SHOWINGTIME";
                TheatreCMBX.Enabled = true;
                DateCMBX.Enabled = true;
                TimeCMBX.Enabled = true;

            }
        }
        private void TimeCMBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSeatList();
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
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
        }
        private void cancelticketbtn_Click(object sender, EventArgs e)
        {
            int currentUserId = currentUser.UserSession.CurrentUserId; // Assuming you retrieve the logged-in user's ID

            UserCancelTicketWindow uctw = new UserCancelTicketWindow(currentUserId);
            uctw.Show();
            this.Close();
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


        private void BookNowBtn_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            int currentUserId = currentUser.UserSession.CurrentUserId;

            int moviePrice = 0; // Declare moviePrice at the top

            // Fetch the movie price from moviedetails table
            string priceQuery = "SELECT MOVIE_PRICE FROM moviedetails WHERE MOVIE_TITLE = @MOVIE_TITLE";

            using (MySqlCommand priceCmd = new MySqlCommand(priceQuery, connection))
            {
                priceCmd.Parameters.AddWithValue("@MOVIE_TITLE", MovieCMBX.GetItemText(MovieCMBX.Text));

                using (MySqlDataReader reader = priceCmd.ExecuteReader())
                {
                    if (reader.Read()) // Check if there is a result
                    {
                        moviePrice = reader.GetInt32("MOVIE_PRICE"); // Assuming MOVIE_PRICE is of type INT
                    }
                    else
                    {
                        MessageBox.Show("No price found for the selected movie.");
                        return; // Exit if no price is found
                    }
                }
            }

            // Insert into bookedtickets table first
            // Insert into bookedtickets table, including currentUserId

            string insertData = "INSERT INTO bookedtickets (MOVIE_TITLE, MOVIE_SHOWINGDATE, MOVIE_SHOWINGTIME, MOVIE_THEATRE, AVAILABILITY, UNIQUE_ID) " +
                          "VALUES(@MOVIE_TITLE, @MOVIE_SHOWINGDATE, @MOVIE_SHOWINGTIME, @MOVIE_THEATRE, 1, @USERID)";

            long bookingID = 0;

            try
            {

                using (MySqlCommand cmd = new MySqlCommand(insertData, connection))
                {
                    cmd.Parameters.AddWithValue("@MOVIE_TITLE", MovieCMBX.GetItemText(MovieCMBX.Text));
                    cmd.Parameters.AddWithValue("@MOVIE_SHOWINGDATE", DateCMBX.GetItemText(DateCMBX.Text));
                    cmd.Parameters.AddWithValue("@MOVIE_SHOWINGTIME", TimeCMBX.GetItemText(TimeCMBX.Text));
                    cmd.Parameters.AddWithValue("@MOVIE_THEATRE", TheatreCMBX.GetItemText(TheatreCMBX.Text));
                    cmd.Parameters.AddWithValue("@USERID", currentUserId); // Ensure this matches the USERS table UNIQUE_ID

                    cmd.ExecuteNonQuery();

                    // Get the last inserted BOOKING_ID from the bookedtickets table
                    bookingID = cmd.LastInsertedId;
                }

                // Check if any seats are selected
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("No seats selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit if no seats are selected
                }

                // Now insert the seats into the bookingseats table
                foreach (var selectedSeat in listBox1.Items)
                {
                    string insertSeatData = "INSERT INTO bookingseats (BOOKING_ID, SEAT_ID, MOVIE_SHOWINGDATE, MOVIE_SHOWINGTIME) " +
                                             "VALUES(@BOOKING_ID, @SEAT_ID, @MOVIE_SHOWINGDATE, @MOVIE_SHOWINGTIME)";

                    using (MySqlCommand seatCmd = new MySqlCommand(insertSeatData, connection))
                    {
                        seatCmd.Parameters.AddWithValue("@BOOKING_ID", bookingID);
                        seatCmd.Parameters.AddWithValue("@SEAT_ID", selectedSeat.ToString());
                        seatCmd.Parameters.AddWithValue("@MOVIE_SHOWINGDATE", DateCMBX.GetItemText(DateCMBX.Text));
                        seatCmd.Parameters.AddWithValue("@MOVIE_SHOWINGTIME", TimeCMBX.GetItemText(TimeCMBX.Text));

                        seatCmd.ExecuteNonQuery();  // Insert seat into bookingseats table
                        ChangeButtonState(selectedSeat.ToString(), true); // Pass true to indicate it's booked
                    }
                }


                int selectedSeatsCount = listBox1.Items.Count;
                double totalPrice = moviePrice * selectedSeatsCount;
                MessageBox.Show($"The total price for this booking is: " + totalPrice.ToString("C"), "Movie Price", MessageBoxButtons.OK, MessageBoxIcon.Information);


                DateTime bookingDateTime = DateTime.Now;

                string insertPriceQuery = "INSERT INTO totalrevenue (TOTAL_PRICE, TOTALPRICE_BOOKINGDATE) VALUES (@TOTAL_PRICE, @TOTALPRICE_BOOKINGDATE)";

                using (MySqlCommand cmd = new MySqlCommand(insertPriceQuery, connection))
                {

                    cmd.Parameters.AddWithValue("@TOTAL_PRICE", totalPrice);
                    cmd.Parameters.AddWithValue("@TOTALPRICE_BOOKINGDATE", bookingDateTime);
                    cmd.ExecuteNonQuery();
                }

                Pricelbl.Text = totalPrice.ToString("C");

                payment pay = new payment();
                pay.ShowDialog();


                MessageBox.Show("Movie booked successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                PrintBookingDetails();
                listBox1.Items.Clear();
                RefreshSeatList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }


        private void RefreshSeatList()
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Clear the previous seat selections
            foreach (Control seatButton in SeatBox.Controls)
            {
                if (seatButton is Button button)
                {
                    button.Enabled = true; // Enable all seat buttons
                    button.BackColor = Color.Thistle; // Reset to default color
                }
            }

            // Get the selected movie details
            string selectedMovieTitle = MovieCMBX.GetItemText(MovieCMBX.SelectedItem);
            string selectedDate = DateCMBX.GetItemText(DateCMBX.SelectedItem);
            string selectedTime = TimeCMBX.GetItemText(TimeCMBX.SelectedItem);

            // Fetch the booked seats for the selected movie, date, and time
            string bookedSeatsQuery = @"
        SELECT bs.SEAT_ID 
        FROM bookingseats bs 
        JOIN bookedtickets bt ON bs.BOOKING_ID = bt.BOOKING_ID 
        WHERE bt.MOVIE_TITLE = @MOVIE_TITLE 
        AND bt.MOVIE_SHOWINGDATE = @MOVIE_SHOWINGDATE 
        AND bt.MOVIE_SHOWINGTIME = @MOVIE_SHOWINGTIME";

            using (MySqlCommand cmd = new MySqlCommand(bookedSeatsQuery, connection))
            {
                cmd.Parameters.AddWithValue("@MOVIE_TITLE", selectedMovieTitle);
                cmd.Parameters.AddWithValue("@MOVIE_SHOWINGDATE", selectedDate);
                cmd.Parameters.AddWithValue("@MOVIE_SHOWINGTIME", selectedTime);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string bookedSeat = reader.GetString("SEAT_ID");

                        // Update the button state for booked seats
                        foreach (Control seatButton in SeatBox.Controls)
                        {
                            if (seatButton is Button button && button.Text == bookedSeat)
                            {
                                button.Enabled = false; // Disable booked seat
                                button.BackColor = Color.Red; // Change color to indicate booking
                            }
                        }
                    }
                }
            }
        }


        // Method to change the button state (color and enabled state)
        private void ChangeButtonState(string seatID, bool isBooked)
        {
            foreach (Control control in SeatBox.Controls)
            {
                if (control is Button button && button.Text == seatID)
                {
                    if (isBooked)
                    {
                        button.BackColor = Color.OrangeRed; // Change color to indicate booked
                        button.Enabled = false; // Make it unclickable
                    }
                    else
                    {
                        button.BackColor = DefaultBackColor; // Reset color to default if needed
                        button.Enabled = true; // Make it clickable again
                    }
                    break;
                }
            }
        }

        private void PrintBookingDetails()
        {
            PrintDocument printDocument = new PrintDocument();

            // Attach the PrintPage event handler
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Set the paper size
            printDocument.DefaultPageSettings.PaperSize = new PaperSize("Single Dimensional Theatre", 219, 792);

            // Optional: Show print dialog before printing
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float leftMargin = 3;
            float topMargin = 3;

            DateTime bookingDateTime = DateTime.Now;

            // Load and draw the logo image
            Image logo = Image.FromFile("C:\\Users\\ceeli\\Downloads\\SDT_Logo.png");  // Ensure the file path is correct

            int logoX = 0;  // X coordinate (adjust as necessary)
            int logoY = 3;  // Y coordinate (adjust as necessary)
            int logoWidth = 190;  // Adjust the width to fit your needs
            int logoHeight = 80;  // Adjust the height to fit your needs

            e.Graphics.DrawImage(logo, new Rectangle(logoX, logoY, logoWidth, logoHeight));

            e.Graphics.DrawString("2413 Milky Way Street, 20412, PH", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 0, 81);
            e.Graphics.DrawString("Branch 1", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 60, 95);
            e.Graphics.DrawString("Operated by the SDT Team", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 3, 111);
            e.Graphics.DrawString("SALES INVOICE", new Font("Franklin Gothic CondensedBlack", 14), Brushes.Black, 20, 140);
            e.Graphics.DrawString(bookingDateTime.ToString(), new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 20, 160);

            e.Graphics.DrawString("Movie:", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 10, 190);
            e.Graphics.DrawString(MovieCMBX.Text, new Font("Franklin Gothic Condensed Medium", 12), Brushes.Black, 10, 205);
            e.Graphics.DrawString("Theatre:", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 10, 225);
            e.Graphics.DrawString(TheatreCMBX.Text, new Font("Franklin Gothic Condensed Medium", 12), Brushes.Black, 10, 240);
            e.Graphics.DrawString("Date:", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 10, 265);
            e.Graphics.DrawString(DateCMBX.Text, new Font("Franklin Gothic Condensed Medium", 12), Brushes.Black, 10, 280);
            e.Graphics.DrawString("Time:", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 10, 300);
            e.Graphics.DrawString(TimeCMBX.Text, new Font("Franklin Gothic Condensed Medium", 12), Brushes.Black, 10, 315);
            e.Graphics.DrawString("Total Price:", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 10, 340);
            e.Graphics.DrawString(Pricelbl.Text, new Font("Franklin Gothic Condensed Medium", 12), Brushes.Black, 10, 355);
            e.Graphics.DrawString("Seats:", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 10, 370);


            int yPosition = 395;

            //Print selected seats from the ListBox
            foreach (var seat in listBox1.Items)
            {
            e.Graphics.DrawString(seat.ToString(), new Font("Franklin Gothic Condensed Medium", 12), Brushes.Black, 40, yPosition);
               yPosition += 20;
            }

            BookingNumRef bookingRefGenerator = new BookingNumRef();
            string bookingReference = bookingRefGenerator.CreateNewBookingReference();
            int currentUserId = currentUser.UserSession.CurrentUserId;


            e.Graphics.DrawString($"User ID.: {currentUserId}", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 5, 487);
            e.Graphics.DrawString($"Ref no.: {bookingReference}", new Font("Franklin Gothic Condensed Medium", 7), Brushes.Black, 5, 505);
            e.Graphics.DrawString("This serves as your official receipt", new Font("Franklin Gothic Condensed Medium", 7), Brushes.Black, 3, 520);
            e.Graphics.DrawString("Valid only on screening details indicated.", new Font("Franklin Gothic Condensed Medium", 7), Brushes.Black, 3, 535);
            e.Graphics.DrawString("Thank you, enjoy your movie!", new Font("Franklin Gothic Condensed Medium", 10), Brushes.Black, 3, 550);


            //You can also calculate the total price based on the number of seats
            // decimal totalPrice = listBox1.Items.Count * TicketPrice;
            // e.Graphics.DrawString($"Total Price: PHP {totalPrice.ToString("N2")}", new Font("Arial", 10), Brushes.Black, 20, yPosition + 20);
        }


        private void UserBookTicketsWindow_Load(object sender, EventArgs e)
        {
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {


        }
        private void SeatBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserBookTicketsWindow_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button77_Click(object sender, EventArgs e)
        {
            Button clickedSeat = sender as Button;
            string seatNumber = clickedSeat.Text;

            // Check if the seat is already booked
            if (clickedSeat.BackColor == Color.Gray) // Assuming booked seats are gray
            {
                MessageBox.Show("This seat is already booked.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit if the seat is booked
            }

            // Check if the seat is already selected
            if (listBox1.Items.Contains(seatNumber))
            {
                // If the seat is already selected, remove it
                listBox1.Items.Remove(seatNumber);
                clickedSeat.BackColor = Color.Thistle; // Change color back to indicate deselection
            }
            else
            {
                // Check if the limit of 3 seats has been reached
                if (listBox1.Items.Count < 3)
                {
                    listBox1.Items.Add(seatNumber);
                    clickedSeat.BackColor = Color.LightGreen; // Change color to indicate selection
                }
                else
                {
                    // Show a message to the user
                    MessageBox.Show("You can only select up to 3 seat per booking.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
                
