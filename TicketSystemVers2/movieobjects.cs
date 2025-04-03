using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemVers2
{
    class movieobjects
    {

        public static int movieCount;
        public static movieobjects[] mobject = new movieobjects[12];

        private int mOVIE_ID;

        public int GetMOVIE_ID()
        {
            return mOVIE_ID;
        }

        public void SetMOVIE_ID(int value)
        {
            mOVIE_ID = value;
        }

        private string mOVIE_TITLE;

        public string GetMOVIE_TITLE()
        {
            return mOVIE_TITLE;
        }

        public void SetMOVIE_TITLE(string value)
        {
            mOVIE_TITLE = value;
        }

        private string mOVIE_DESCRIPTION;

        public string GetMOVIE_DESCRIPTION()
        {
            return mOVIE_DESCRIPTION;
        }

        public void SetMOVIE_DESCRIPTION(string value)
        {
            mOVIE_DESCRIPTION = value;
        }

        private string mOVIE_GENRE;

        public string GetMOVIE_GENRE()
        {
            return mOVIE_GENRE;
        }

        public void SetMOVIE_GENRE(string value)
        {
            mOVIE_GENRE = value;
        }

        private string mOVIE_CAST;

        public string GetMOVIE_CAST()
        {
            return mOVIE_CAST;
        }

        public void SetMOVIE_CAST(string value)
        {
            mOVIE_CAST = value;
        }

        private string mOVIE_DIRECTORS;

        public string GetMOVIE_DIRECTORS()
        {
            return mOVIE_DIRECTORS;
        }

        public void SetMOVIE_DIRECTORS(string value)
        {
            mOVIE_DIRECTORS = value;
        }

        private string mOVIE_RATING;

        public string GetMOVIE_RATING()
        {
            return mOVIE_RATING;
        }

        public void SetMOVIE_RATING(string value)
        {
            mOVIE_RATING = value;
        }

        private string mOVIE_POSTERURL;

        public string GetMOVIE_POSTERURL()
        {
            return mOVIE_POSTERURL;
        }

        public void SetMOVIE_POSTERURL(string value)
        {
            mOVIE_POSTERURL = value;
        }

        private string mOVIE_SHOWINGDATE;

        public string GetMOVIE_SHOWINGDATE()
        {
            return mOVIE_SHOWINGDATE;
        }

        public void SetMOVIE_SHOWINGDATE(string value)
        {
            mOVIE_SHOWINGDATE = value;
        }

        private string mOVIE_SHOWINGTIME;

        public string GetMOVIE_SHOWINGTIME()
        {
            return mOVIE_SHOWINGTIME;
        }

        public void SetMOVIE_SHOWINGTIME(string value)
        {
            mOVIE_SHOWINGTIME = value;
        }
    }
    }
