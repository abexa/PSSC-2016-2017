using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    enum tip_note {nota_examen, nota_activitate }
    class Note
    {
        List<Discipline> disciplina = new List<Discipline>();
        List<Student> student = new List<Student>();
        tip_note note;
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
            get { return note;}
            set { note = value; }
        }
        public Note(List<Student> student, List<Discipline> disciplina, tip_note note)
        {
            this.student = student;
            this.disciplina = disciplina;
            this.note = note;
        }
        }
}
