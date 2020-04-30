using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar
{
    public class Activitati
    {
        public string Nume;
        public string Description;
        public DateTime StartDate;
        public DateTime EndDate;
        private string v;

        

        internal List<Persoana> PeopleInvolved { get; set; }

        public string Details()
        {
            return $"{Nume}, {Description}, {StartDate.ToString()}, {EndDate.ToString()}";
        }
    }
}
