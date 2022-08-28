using System;

namespace Homework
{
    class AutoService
    {
        public static void Main()
        {
            BMWm3 myCar1 = new BMWm3();
            Console.WriteLine("-------------------------");
            Console.WriteLine("Car info:");
            Console.WriteLine(myCar1.CarBrand + " " + myCar1.ModelName);
            Console.WriteLine("Exhaust sound:");
            myCar1.ExhaustSound();
            Console.WriteLine("Body type:");
            myCar1.CarBody();

            Console.WriteLine("\nAvaiable parts (transmission):");
            Transmission a1 = new Transmission();
            a1.AvailableTransmissions();

            Console.WriteLine("\nRecommended wheels:");
            Wheel b1 = new Wheel();
            b1.CarWheels();

            Console.WriteLine("\nEngines in stock:");
            Engine engine1 = new Engine();
            engine1.AvaibleEngines();
            engine1.NewEngine = "4.4-liter BMW M";
            Console.WriteLine("Exclusive engines (need to be ordered and shipped):");
            Console.WriteLine(engine1.NewEngine);

            Console.WriteLine("\n-------------------------");
            BMWx5 myCar2 = new BMWx5();
            Console.WriteLine("Short info about another car:");
            Console.WriteLine(myCar2.CarBrand + " " + myCar2.ModelName);
            Console.WriteLine("Exhaust sound:");
            myCar2.ExhaustSound();
            Console.WriteLine("Body type:");
            myCar2.CarBody();
            Console.WriteLine("-------------------------");
        }
    }

    class Vehicle
    {
        public string CarBrand = "BMW";
        public virtual void ExhaustSound()
        {
            Console.WriteLine("Bu-Bu-Bu-Bu");
        }

        public void CarBody()
        {
            Console.WriteLine("Enter car body type: 1 - Sedan, 2 - SUV");
            int BodyIndex = int.Parse(Console.ReadLine());
            if (BodyIndex > 1)
            {
                Console.WriteLine("This car is SUV");
            }
            else
            {
                Console.WriteLine("This car is Sedan");
            }
        }
    }

    class Wheel
    {
        public void CarWheels()
        {
            string[] RimRadius = new string[]
            {
                "StockType - 16'",
                "ComfortType - 19'",
                "GangstaType - 22'"
            };
            Console.WriteLine(RimRadius[0]);
        }
    }

    class Transmission
    {
        public void AvailableTransmissions()
        {
            string[] TransmissionsArr = new string[]
            {
                "4x4",
                "Front-wheel drive",
                "Rear-wheel drive"
            };
            foreach (var j in TransmissionsArr)
            {
                Console.WriteLine(j);
            }
        }
    }

    class Engine
    {
        private string NewEngines;
        public string NewEngine
        {
            get { return NewEngines; }
            set { NewEngines = value; }
        }
        public void AvaibleEngines()
        {
            string[] EnginesArr = new string[]
            {
                "3.0 - liter BMW M",
                "2.0 - liter BMW",
                "3.0 - diesel BMW M"
            };

            foreach (var i in EnginesArr)
            {
                Console.WriteLine(i);
            }
        }
    }

    class BMWm3: Vehicle
    {
        public int BodyIndex = 1;
        public string ModelName = "M3";
        public override void ExhaustSound()
        {
            Console.WriteLine("Ra-ta-ta-ta");
        }
    }

    class BMWx5: Vehicle
    {
        public int BodyIndex = 2;
        public string ModelName = "X5";
        public override void ExhaustSound()
        {
            Console.WriteLine("Br-Br-Br-Br");
        }
    }
}