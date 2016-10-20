using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        List<Discipline> disciplina = new List<Discipline>();
        List<Student> student = new List<Student>();
        tip_note note;
        string nume;
        string prenume;
        string adresa_mail;
        private List<Discipline> Discipline
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        private List<Student> Studenti
        {
            get { return student; }
            set { student = value; }
        }

        public tip_note Nota
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
        public Profesor(List<Student> student, List<Discipline> disciplina, tip_note note, string nume, string prenume, string adresa_mail)
        {
            this.student = student;
            this.disciplina = disciplina;
            this.note = note;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa_mail = adresa_mail;
        }
    }
}
