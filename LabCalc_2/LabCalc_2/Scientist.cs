using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalc_2
{
    class Scientist
    {
        public Scientist()
        {
            name = string.Empty;
            faculty = string.Empty;
            cathedra = string.Empty;
            post = string.Empty;
            time = string.Empty;
        }

        public Scientist(string _name, string _faculty, string _cathedra, string _post, string _time)
        {
            name = _name;
            faculty = _faculty;
            cathedra = _cathedra;
            post = _post;
            time = _time;
        }

        private string name;
        private string faculty;
        private string cathedra;
        private string post;
        private string time;

        public string Faculty
        {
            get
            { return faculty; }

            set
            { faculty = value; }

        }

        public string Cathedra
        {
            get
            { return cathedra; }

            set
            { cathedra = value; }

        }

        public string Post
        {
            get
            { return post; }

            set
            { post = value; }

        }

        public string Time
        {
            get
            { return time; }

            set
            {
                time = value;
            }

        }

        public string Name
        {
            get
            { return name; }

            set
            { name = value; }

        }

        public static string GetTimeString(int years)
        {
            string newFag = "0 - 5 years";
            string mediumTime = "6 - 15 years";
            string old = "16-60 years";

            if (years >= 0 && years <= 5)
            {
                return newFag;
            }
            else if (years >= 6 && years <= 15)
            {
                return mediumTime;
            }
            else
            {
                return old;
            }
        }

        public static bool IsTimeEqual(string status, int years)
        {
            string newFag = "0 - 5 years";
            string mediumTime = "6 - 15 years";
            string old = "16-60 years";

            if (status.Equals(newFag))
            {
                if (years >= 0 && years <= 5)
                    return true;
            }

            if (status.Equals(mediumTime))
            {
                if (years >= 6 && years <= 15)
                    return true;
            }

            if (status.Equals(old))
            {
                if (years >= 16)
                    return true;

            }

            return false;
        }
    }
}
