using MySql.Data.MySqlClient;
using System.Data;

namespace TicketSystemVers2
{
    public partial class UserHomeWindow : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=root;database=movieticketingsystem");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataSet dataset1 = new DataSet();


        public UserHomeWindow()
        {
            InitializeComponent();
        }
        private void picallfalse()//IMPORTANT
        {

        }
        private void UserHomeWindow_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e) //FIGURED IT OUT, WORKS NOW\\ //~Figure out the code how to make the slideshow work.~\\
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void homebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already here.", "Information", MessageBoxButtons.OK);
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
            int currentUserId = currentUser.UserSession.CurrentUserId; // Assuming you retrieve the logged-in user's ID

            UserCancelTicketWindow uctw = new UserCancelTicketWindow(currentUserId);
            uctw.Show();
            this.Close();
        }

        private void movpic1_Click(object sender, EventArgs e)
        {

        }

        private void UserHomeWindow_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("select * from featuredmovies", connection);
            MySqlDataReader reader;
          
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              featured1.ImageLocation = reader["Display1"].ToString();
              featured2.ImageLocation = reader["Display2"].ToString();
              featured3.ImageLocation = reader["Display3"].ToString();
              featured4.ImageLocation = reader["Display4"].ToString();
            }

            connection.Close();
        }
    }
}

