using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

//[assembly: InternalsVisibleTo("Homework")]

namespace CSharp
{
    public class Person
    {
        internal string Name { get; set; }
        internal int Age;

        public void Eat()
        {

        }
    }




    public class Abiltity
    {

    }



    internal class SQL: Major
    {

    }

    internal class Teacher : Person
    {
        //public IEnumerable<Major> TeachOn { get; set; }


        //1:1
        public Student Student { get; set; }

        //1:n
        public IList<Student> Students { get; set; }
    }
}
