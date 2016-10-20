using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student
    {
        List<Note> note = new List<Note>();
        string nume;
        string prenume;
        string adresa_mail;
        int an;
        int cnp;
        int nr_matricol;

        private List<Note> Note
        {
            get { return note; }
            set { note = value; }
        }
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Prenume
        {
            get { return prenume; }
            set { prenume = value; }
        }

        public string Adresa_mail
        {
            get { return adresa_mail; }
            set { adresa_mail = value; }
        }

        public int An
        {
            get { return an; }
            set { an = value; }
        }

        public int CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }

        public int Nr_matricol
        {
            get { return nr_matricol; }
            set { nr_matricol = value; }
        }

        public Student(List<Note> note,string nume, string prenume, string adresa_mail, int an, int cnp, int nr_matricol)
        {
            this.note = note;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa_mail = adresa_mail;
            this.an = an;
            this.cnp = cnp;
            this.nr_matricol = nr_matricol;
        }
    }
}
