using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Decanat
    {
        List<Discipline> disciplina = new List<Discipline>();
        List<Profesor> profesor = new List<Profesor>();
        List<Student> student = new List<Student>();

        private List<Discipline> Discipline
        {
            get { return disciplina;  }
            set { disciplina = value; }
        }

        private List<Profesor> Profesori
        {
            get { return profesor; }
            set { profesor = value; }
        }
        
        private List<Student> Studenti
        {
            get { return student; }
            set { student = value; }
        }

        public Decanat(List<Profesor> profesor, List<Student> student, List<Discipline> disciplina)
        {
            this.profesor = profesor;
            this.student = student;
            this.disciplina = disciplina;
        }
    }
}
