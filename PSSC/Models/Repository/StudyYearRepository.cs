using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    class StudyYearRepository : IRepository
    {
        private static List<Models.Subject.Subject> _subject = new List<Models.Subject.Subject>();

        public StudyYearRepository()
        {
        }

        public Models.Subject.Subject GetById(Guid Id)
        {
            var result = _subject.Find(p => p.GetID == Id);
            return result;
        }

        public void Add(Subject.Subject entity)
        {
            var result = _subject.FirstOrDefault(p => p.Equals(entity));

        }

        public void Delete(Subject.Subject entity)
        {
            var result = _subject.FirstOrDefault(p => p.Equals(entity));

        }
   

    }
}