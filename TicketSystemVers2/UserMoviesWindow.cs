using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketSystemVers2
{
    public partial class UserMoviesWindow : Form
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter dataadapter = new MySqlDataAdapter();
        MySqlDataReader reader;
        DataSet dataset1 = new DataSet();
        DataSet dataset2 = new DataSet();
        DataTable datatable1 = new DataTable();

        public UserMoviesWindow()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)//WORKING
        {
            UserHomeWindow uhw = new UserHomeWindow();
            uhw.Show();
            this.Close();
        }

        private void moviesbtn_Click(object sender, EventArgs e)//WORKING
        {
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
        }

        private void bookticketbtn_Click(object sender, EventArgs e)//WORKING
        {
            UserBookTicketsWindow ubtw = new UserBookTicketsWindow();
            ubtw.Show();
            this.Close();
        }

        private void cancelticketbtn_Click(object sender, EventArgs e)//WORKING
        {
            int currentUserId = currentUser.UserSession.CurrentUserId; // Assuming you retrieve the logged-in user's ID

            UserCancelTicketWindow uctw = new UserCancelTicketWindow(currentUserId);
            uctw.Show();
            this.Close();
        }

        private void signoutbtn_Click(object sender, EventArgs e)//WORKING
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

        private void UserMoviesWindow_Load(object sender, EventArgs e)//FOR THE MOVIES TO APPEAR IN THE COMBO BOX\\
        {
            dataadapter.SelectCommand = new MySqlCommand("select DISTINCT MOVIE_TITLE from moviedetails", connection);
            dataadapter.Fill(dataset1);
            selectmoviecmbx.DataSource = dataset1.Tables[0];
            selectmoviecmbx.DisplayMember = "MOVIE_TITLE";
        }

        private void selectmoviecmbx_SelectedIndexChanged(object sender, EventArgs e) // WORKING, SHOWS MOVIE DETAILS\\
        {
            string price = "Php ";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from moviedetails WHERE MOVIE_TITLE=@MOVIE_TITLE", connection);
            cmd.Parameters.AddWithValue("@MOVIE_TITLE", selectmoviecmbx.Text);

            reader = cmd.ExecuteReader();


            //DataTable moviedetails1 = new DataTable();
            //dataadapter.Fill(moviedetails1);
            //selectmoviecmbx.DataSource = moviedetails1;

            while (reader.Read())
            {
                selectmoviecmbx.Text = reader["MOVIE_TITLE"].ToString();
                //movieidlbl.Text = reader["MOVIE_ID"].ToString();
                movietitlelbl.Text = reader["MOVIE_TITLE"].ToString();
                movieratinglbl.Text = reader["MOVIE_RATING"].ToString();
                moviegenrelbl.Text = reader["MOVIE_GENRE"].ToString();
                moviecastlbl.Text = reader["MOVIE_CAST"].ToString();
                moviedirectorslbl.Text = reader["MOVIE_DIRECTORS"].ToString();
                moviepricelbl.Text = price + reader["MOVIE_PRICE"].ToString();
                moviedescriplbl.Text = reader["MOVIE_DESCRIPTION"].ToString();
                movieposterimg.ImageLocation = reader["MOVIE_POSTERURL"].ToString(); //Poster Image
            }

            //selectmoviecmbx.DisplayMember = "MOVIE_TITLE";
            //selectmoviecmbx.ValueMember = "MOVIE_ID";
            //selectmoviecmbx.DataSource = datatable1;


            connection.Close();
        }

        private void selectmoviecmbx_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void moviedirectorslbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserBookTicketsWindow ubtw = new UserBookTicketsWindow();
            ubtw.Show();
        }
    }
}
