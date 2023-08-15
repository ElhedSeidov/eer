using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Teacher : Person
    {


        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {


        }



        public void  Explain()
        {
            Console.WriteLine("Explaining");
            

        }
    }
}
