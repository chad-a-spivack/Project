using System;

namespace ConversionCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Conversion Calculator!");
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Enter A for Standard to Metric");
            Console.WriteLine("Enter B for Metric to Standard");
            Console.WriteLine("Enter C to exit");
            Console.Write("Please select unit conversion option: ");
            string input = Console.ReadLine();
            if (input == "A" || input == "a")
            {
                StandardToMetric();
            }
            else if (input == "B" || input == "b")
            {
                MetricToStandard();
            }
            else if (input == "C" || input == "c")
            {
                return;
            }
            else
            {
                MainMenu();
            }
        }

        private static void MetricToStandard()
        {
            Console.WriteLine("Metric to standard calculator");
           
            Console.WriteLine("Units of measurment");
            Console.WriteLine("Enter 1 for mL to oz");
            Console.WriteLine("Enter 2 for L to cups");
            Console.WriteLine("Enter 3 for main menu");
            string unit = Console.ReadLine();
            if (unit == "1")
            {
                MilliliterToOunces();
            }
            else if (unit == "2")
            {
                LitersToCups();
            }
            else if (unit == "3")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid response");
                MetricToStandard();
            }
        }

        private static void LitersToCups()
        {
            Console.Write("Enter an integer for Liters: ");
            string metric = Console.ReadLine();
            double intMetric = double.Parse(metric);
            double result = intMetric * 4.227;
            Console.WriteLine($"{intMetric} L is = {result} cups");
        }

        private static void MilliliterToOunces()
        {
            Console.Write("Enter an integer for mL: ");
            string metric = Console.ReadLine();
            double intMetric = double.Parse(metric);
            double result = intMetric / 30;
            Console.WriteLine($"{intMetric} mL is = {result} oz");
        }

        private static void StandardToMetric()
        {
            Console.WriteLine("Standard to metric calculator");

            Console.WriteLine("Units of measurment");
            Console.WriteLine("Enter 1 for oz to mL");
            Console.WriteLine("Enter 2 for cups to L");
            Console.WriteLine("Enter 3 for main menu");
            string unit = Console.ReadLine();
            if (unit == "1")
            {
                OuncesToMilliliter();
            }
            else if (unit == "2")
            {
                CupsToLiters();
            }
            else if (unit == "3")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("Invalid response");
                StandardToMetric();
            }
        }

        private static void CupsToLiters()
        {
            Console.Write("Enter an integer for cups: ");
            string standard = Console.ReadLine();
            double doubStandard = double.Parse(standard);
            double result = doubStandard / 4.227;
            
            Console.WriteLine($"{doubStandard} cups is = {result} Liters");
        }

        private static void OuncesToMilliliter()
        {
            Console.Write("Enter an integer for ounces: ");
            string standard = Console.ReadLine();
            double doubStandard = double.Parse(standard);
            double result = doubStandard * 29.574;
            Console.WriteLine($"{doubStandard} oz is = {result} mL");
        }
    }
}
