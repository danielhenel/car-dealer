using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    internal class Car
    {
        private string make;
        string model;
        int year;
        int price;
        int wheelSize;
        int horsepower;
        int displacement;
        int engineType;
        int width;
        int height;
        int lenght;
        int gasMileage;
        string drivetrain;
        int passengerCapacity;
        int passengerDoors;
        string bodyStyle;
        string imageName;

        public Car(string make, string model, int year,
            int price, int wheelSize, int horsepower, 
            int displacement, int engineType, int width, 
            int height, int lenght, int gasMileage, 
            string drivetrain, int passengerCapacity, 
            int passengerDoors, string bodyStyle,
            string imageName)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.WheelSize = wheelSize;
            this.Horsepower = horsepower;
            this.Displacement = displacement;
            this.EngineType = engineType;
            this.Width = width;
            this.Height = height;
            this.Lenght = lenght;
            this.GasMileage = gasMileage;
            this.Drivetrain = drivetrain;
            this.PassengerCapacity = passengerCapacity;
            this.PassengerDoors = passengerDoors;
            this.BodyStyle = bodyStyle;
            this.ImageName = imageName;
        }

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public int Price { get => price; set => price = value; }
        public int WheelSize { get => wheelSize; set => wheelSize = value; }
        public int Horsepower { get => horsepower; set => horsepower = value; }
        public int Displacement { get => displacement; set => displacement = value; }
        public int EngineType { get => engineType; set => engineType = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int Lenght { get => lenght; set => lenght = value; }
        public int GasMileage { get => gasMileage; set => gasMileage = value; }
        public string Drivetrain { get => drivetrain; set => drivetrain = value; }
        public int PassengerCapacity { get => passengerCapacity; set => passengerCapacity = value; }
        public int PassengerDoors { get => passengerDoors; set => passengerDoors = value; }
        public string BodyStyle { get => bodyStyle; set => bodyStyle = value; }
        public string ImageName { get => imageName; set => imageName = value; }
    }
}
