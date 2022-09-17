using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _920a_Omeniuk_PZ4
{

    class Program
    {
        static void Main()
        {
            // Random method for initialize variable price
            Random randomPrice = new Random();
            long price = randomPrice.Next(10000, 1000000);


            // Initialize objects
            Car car = new Car();
            car.Price = price;
            Ship ship = new Ship();
            ship.Price = price;
            Plane plane = new Plane();
            plane.Price = price;

            // Method random
            Random randomY = new Random();
            long coordinateY = randomY.Next(0, 100000);
            Random randomX = new Random();
            long coordinateX = randomX.Next(0, 100000);


            // Output to the console
            Console.WriteLine("Оберiть тип транспорта\n" +
                "Car\n" +
                "Ship\n" +
                "Plane\n");
            // Input to the console
            string? WhatVehicle = Console.ReadLine();

            // Console interface execution conditions  
            if (WhatVehicle == "Car" || WhatVehicle == "car")
            {
                car.Coordinate(coordinateY, coordinateX);
                Console.WriteLine("Цiна = {0}", car.Price.ToString() + " UAH");
                Console.WriteLine("Координати = X:{0},Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());
                Console.Read();
            }
            else if(WhatVehicle == "Ship" || WhatVehicle == "ship")
            {
                ship.Coordinate(coordinateY, coordinateX);
                Console.WriteLine("Цiна корабля = {0}", ship.Price + 100.ToString() + " UAH");
                Console.WriteLine("Координати = X:{0},Y: {1}", ship.CoordinateX.ToString(), ship.CoordinateY.ToString());
                Console.Read();
            }
            else if (WhatVehicle == "Plane" || WhatVehicle  == "plane")
            {
                plane.Coordinate(coordinateY, coordinateX);
                Console.WriteLine("Цiна лiтака = {0}", plane.Price+1000.ToString() + " UAH");
                Console.WriteLine("Координати = X:{0},Y: {1}", plane.CoordinateX.ToString(), plane.CoordinateY.ToString());
                Console.Read();
            }
        }
    }
        internal class Vehicle // Class Vehicle
        {
            // Getter & Setter
            public double CoordinateX { get; set; }
            public double CoordinateY { get; set; }
            public double Price { get; set; }
            public double Speed{ get; set; }
            public double Year_of_construction { get; set; }


            // Method for dynamically changing values
            // Constructor
            public void Coordinate(double CoordinateX, double CoordinateY)
            {
                this.CoordinateX = CoordinateX;
                this.CoordinateY = CoordinateY;
            }
            // Method for dynamically changing values
            // Constructor
            public void SpeedMethod(double Speed)
            {
                this.Speed = Speed;
            }
        }

        class Plane : Vehicle // Class Plane extends to Vehicle
        {
            // Getter & Setter
            public double Height { get; set; }
            public double NumberOfPassengers { get; set; }
        }

        class Ship : Vehicle // Class Ship extends to Vehicle
        {
            // Getter & Setter
            public double NumberOfPassengers { get; set; }
            public string? DestinationPort { get; set; }
        }

        class Car : Vehicle // Class Car extends to Vehicle
        {

        }
    }