using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anjar Tri Sasongko", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Kamarudin", 35, "190302", "Pemrograman");
            teacher.GetNameAndAge();

            Student student = new Student("Anjar Tri Sasongko", 20, "19.11.2607", "anjar.1912@students.@amikom.ac.id");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}
