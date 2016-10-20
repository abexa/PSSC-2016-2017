using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum tip_examen { distribuita, examen }
    class Discipline
    {
        List<Student> student = new List<Student>();
        tip_examen tip_ex;
        string nume_disciplina;
        int an_studiu;
        int credite;
        private List<Student> studenti
        {
            get { return student; }
            set { student = value; }
        }
        public tip_examen Tip_examene
        {
            get { return tip_ex; }
            set { tip_ex = value; }
        }
        public string Nume_discipline
        {
            get { return nume_disciplina; }
            set { nume_disciplina = value; }
        }
        public int Ani_studiu
        {
            get { return an_studiu; }
            set { an_studiu = value; }
        }
        public int Credite
        {
            get { return credite; }
            set { credite = value; }
        }

        public Discipline(List<Student> student, tip_examen tip_ex, string nume_disciplina, int an_studiu, int credite)
        {
            this.student = student;
            this.tip_ex = tip_ex;
            this.nume_disciplina = nume_disciplina;
            this.an_studiu = an_studiu;
            this.credite = credite;
        }
    }
}
