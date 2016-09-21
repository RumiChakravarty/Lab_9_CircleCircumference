using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_CircleCircumference
{
    class CircleApp
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Circle Tester");
                        
            string repeat = "";
            do
            {
                string inputdata = "";
                double radiusOfCircle = 0;
                bool check = false;
                do
                {
                    Console.Write("Enter Radius: ");
                    inputdata = Console.ReadLine();
                     check = Validator.radiusIsValid(inputdata, out radiusOfCircle);
                    if(check == false)
                    {
                        Console.WriteLine("Please enter a valid data");
                    }
                    
                  //  Console.WriteLine("x is:"+ radiusOfCircle +"  input string is "+inputdata + " "+check);
                } while (!check);
              
              
                Circle circleRadiusCircumference = new Circle(radiusOfCircle);

                Console.WriteLine($"Circumference: {circleRadiusCircumference.getFormattedCircumference()}");

                Console.WriteLine($"Area: {circleRadiusCircumference.getFormattedArea()}");

                
                Console.Write("Do you want to Continue?(y/n)");
                repeat = Console.ReadLine().Trim().ToLower();
            } while (repeat == "y");

            Console.WriteLine($"Goodbye. You created {Circle.getObjectCount()} Circle Object(s). ");




        }
    }
}
