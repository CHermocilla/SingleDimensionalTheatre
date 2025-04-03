using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TicketSystemVers2
{
    class seats
    {
        private char SEAT_ROW;
        private int MOVIE_ID;
        private int SEAT_NUMBER;
        private int AVAILABLE;
        private int BOOKING_ID;
        public void setSeatRow(char r)
        {
            SEAT_ROW = r;
        }
        public char getSeatRow()
        {
            return SEAT_ROW;
        }
        public void setSeatNumber(int s1)
        {
            SEAT_NUMBER = s1;
        }
        public int getSeatNumber()
        {
            return SEAT_NUMBER;
        }
        public void setMOVIE_ID(int m)
        {
            MOVIE_ID = m;
        }
        public int getMOVIE_ID()
        {
            return MOVIE_ID;
        }
        public void setAvailable(int a)
        {
            AVAILABLE = a;
        }
        public int getAvailable()
        {
            return AVAILABLE;
        }
        public void setBookingID(int b)
        {
            BOOKING_ID = b;
        }
        public int getBookingID()
        {
            return BOOKING_ID;
        }

        public static int seatCount;
        public static seats[] seatObject = new seats[128];
        public static void loadSeats(int p)
        {
            seatCount = 0;

            DataSet dsSeats = new DataSet();
            MySqlConnection connection = new MySqlConnection("datasource = localhost; port = 3306; username = root; password = root; database = movieticketingsystem");
            connection.Open();
            MySqlCommand cmSeats = new MySqlCommand("SELECT * FROM seats WHERE MOVIE_ID = @MOVIE_ID", connection);
            
            MySqlDataAdapter daSeats = new MySqlDataAdapter(cmSeats);
            daSeats.Fill(dsSeats);
            connection.Close();

            seatCount = dsSeats.Tables[0].Rows.Count;

            for (int i = 0; i < seatCount; i++)
            {
                seatObject[i] = new seats();

                DataRow dataRow = dsSeats.Tables[0].Rows[i];

                seatObject[i].setSeatRow(Convert.ToChar(dataRow[0]));
                seatObject[i].setSeatNumber((int)dataRow[1]);
                seatObject[i].setMOVIE_ID((int)dataRow[2]);
                seatObject[i].setAvailable((int)dataRow[3]);
                seatObject[i].setBookingID((int)dataRow[4]);
            }
        }
    }

}

