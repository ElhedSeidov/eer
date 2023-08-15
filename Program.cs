using System;

namespace ConsoleApp1

{
    public class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new  Teacher("name","surname",22);
            teacher.Explain();
            Student student = new Student("name", "surname", 19);
            student.Learn();
        }
    }
}