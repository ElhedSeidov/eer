
namespace ConsoleApp1
{
    class Student : Person
    {
       public Student(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public  void Learn()
        {
            Console.WriteLine("Learning");
        }
    }

}
