using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar
{
    class Persoana
    {
        public string nume;
        public string prenume;// nume, prenume, data nasterii, adresa de email
        public string email;
        public string datanasterii;
        public Persoana(string nume, string prenume, string datanasterii, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.datanasterii = datanasterii;
            this.email = email;

        }
        public string Name()
        {
            return $"{prenume} {nume}";
        }
        public string Details()
        {
            return $"{Name()}, {datanasterii.Trim()}, {email}";
        }
    }
}
