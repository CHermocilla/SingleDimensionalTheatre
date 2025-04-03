using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemVers2
{
    public class BookingNumRef
    {

        public string BookingReference = "";

        public string CreateNewBookingReference()

        {

            //This generates the day the booking was booked.
            var dateAndTime = DateTime.Now;
            int year = dateAndTime.Year;
            int month = dateAndTime.Month;
            int day = dateAndTime.Day;

            //SDT01012020-00000 FORMAT OF BOOKING REF ! 
            System.Random rand = new System.Random((int)System.DateTime.Now.Ticks);
            int random = rand.Next(1, 1000000000);
            this.BookingReference = random.ToString();
            BookingReference = "SDT" + day + month + year + "-" + BookingReference;

            return BookingReference;
        }
    }
   

}
