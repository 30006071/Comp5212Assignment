using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("Enter Car colour");
            car1.SetColour(Console.ReadLine());
            Console.WriteLine("Enter Car Make");
            car1.SetMake(Console.ReadLine());
            Console.WriteLine("Enter type of Gearbox");
            car1.SetGearbox(Console.ReadLine());
            Console.WriteLine("\r\n" + "Colour: " + car1.GetColour() + "\r\n" + "Make: " + car1.GetMake() + "\r\n" + "Gearbox Type:" + car1.GetGearbox() + "\r\n");
            Console.WriteLine("This car is a " + car1.GetColour() + " " + car1.GetMake() +" with a " + car1.GetGearbox() + " transmission.");
            Console.ReadLine();
        }
    }
    class Car
    {
        private string colour;
        private string make;
        private string gearbox;


        public string GetColour()
        {
            return colour;
        }

        public void SetColour(string col)
        {
            colour = col;
        }

        public string GetMake()
        {
            return make;
        }

        public void SetMake(string mk)
        {
            make = mk;
        }


        public string GetGearbox()
        {
            return gearbox;
        }
        public void SetGearbox(string gbox)
        {
            gearbox = gbox;
        }
    }
    }
