using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class MajorRepository
    {
        private static IList<Major> students;
        static MajorRepository()
        {
            students = new List<Major>();
        }

        public void Save(Major student)
        {
            students.Add(student);
        }

        public void Delete(Major student)
        {
            students.Remove(student);
        }

        //查
    }
}
