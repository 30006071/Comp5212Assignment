using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("","","");
            Console.WriteLine("Enter Car colour");
            car1.Colour = Console.ReadLine();
            Console.WriteLine("Enter Car Make");
            car1.Make = Console.ReadLine();
            Console.WriteLine("Enter type of Gearbox");
            car1.Gearbox = Console.ReadLine();
            Console.WriteLine($"\r\n"+"This car is a " + car1.Colour + " " + car1.Make + " with a " + car1.Gearbox + " transmission.");
            Console.ReadLine();


        }
    }
    public class Car
    {

        public string Colour { get; set; }
        public string Make { get; set; }
        public string Gearbox { get; set; }

        public Car(string _col, string _mk, string _gbox)
        {
            Colour = _col;
            Make = _mk;
            Gearbox = _gbox;
        }

    }
}
