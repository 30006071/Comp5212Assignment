using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionFour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {

                List<Person> personList = new List<Person>();
                Person person1 = new Person("", "");
                Console.WriteLine("Enter your First Name");
                person1.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name");
                person1.LastName = Console.ReadLine();
                Console.WriteLine("Enter your birth year");
                person1.YearOfBirth = int.Parse(Console.ReadLine());
                Console.WriteLine($"\r\n {person1.GetFullName()} is {person1.GetAge()}");
                
                Console.WriteLine("Would you like to add a new person press y for yes or n for no");
                input = Console.ReadLine();
                personList.Add(person1);
            }
            while (input != "n");
            
        }
    }

    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }

        public Person(string _firstName, string _lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
        }
        public int GetAge()
        {
            return 2018 - YearOfBirth;
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
