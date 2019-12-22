using CSharp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class MemoryRepository<T> /*: IRepository<T>*/
    {
        private static IList<T> students;
        static MemoryRepository()
        {
            students = new List<T>();
        }

        public void Save(T student)
        {
            students.Add(student);
        }

        public void Delete(T student)
        {
            students.Remove(student);
        }
    }
}
