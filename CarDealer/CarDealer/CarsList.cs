using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace CarDealer
{
    internal class CarsList
    {
        public CarsList()
        {
            loadData();
        }

        static List<Car> items = new List<Car> { };
        static private String path = "Resources/1000CarsDataSet";
        static Dictionary<string, HashSet<Car>> makeDict = new Dictionary<string, HashSet<Car>> {};
        static Dictionary<string, HashSet<Car>> modelDict = new Dictionary<string, HashSet<Car>> {};
        static Dictionary<int, HashSet<Car>> yearDict = new Dictionary<int, HashSet<Car>> {};
        static Dictionary<int, HashSet<Car>> priceDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> wheelSizeDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> horsepowerDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> displacementDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> engineTypeDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> widthDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> heightDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> lengthDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> gasMileageDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<string, HashSet<Car>> drivetrainDict = new Dictionary<string, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> passengerCapacityDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<int, HashSet<Car>> passengerDoorsDict = new Dictionary<int, HashSet<Car>> { };
        static Dictionary<string, HashSet<Car>> bodyStyleDict = new Dictionary<string, HashSet<Car>> { };

        public static Dictionary<string, HashSet<Car>> MakeDict { get => makeDict;}
        public static Dictionary<string, HashSet<Car>> ModelDict { get => modelDict;}
        public static Dictionary<int, HashSet<Car>> YearDict { get => yearDict;}
        public static Dictionary<int, HashSet<Car>> PriceDict { get => priceDict;}
        public static Dictionary<int, HashSet<Car>> WheelSizeDict { get => wheelSizeDict;}
        public static Dictionary<int, HashSet<Car>> HorsepowerDict { get => horsepowerDict;}
        public static Dictionary<int, HashSet<Car>> DisplacementDict { get => displacementDict;}
        public static Dictionary<int, HashSet<Car>> EngineTypeDict { get => engineTypeDict;}
        public static Dictionary<int, HashSet<Car>> WidthDict { get => widthDict;}
        public static Dictionary<int, HashSet<Car>> HeightDict { get => heightDict;}
        public static Dictionary<int, HashSet<Car>> LengthDict { get => lengthDict;}
        public static Dictionary<int, HashSet<Car>> GasMileageDict { get => gasMileageDict;}
        public static Dictionary<string, HashSet<Car>> DrivetrainDict { get => drivetrainDict;}
        public static Dictionary<int, HashSet<Car>> PassengerCapacityDict { get => passengerCapacityDict;}
        public static Dictionary<int, HashSet<Car>> PassengerDoorsDict { get => passengerDoorsDict;}
        public static Dictionary<string, HashSet<Car>> BodyStyleDict { get => bodyStyleDict;}
        public static List<Car> Items { get => items;}

        static private void saveAddToDict(Dictionary<string, HashSet<Car>> dict, string key, Car value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new HashSet<Car>();
                dict[key].Add(value);
            }
        }

        static private void saveAddToDict(Dictionary<int, HashSet<Car>> dict, int key, Car value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new HashSet<Car>();
                dict[key].Add(value);
            }
        }

        static private int saveParseToInt(string number)
        {
            try
            {
                int result = int.Parse(number);
                return result;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        static public Car loadCar(string fileName)
        {
            string[] subs = fileName.Split('_');

            return (
                new Car(
                    subs[0], //make
                    subs[1], //model
                    saveParseToInt(subs[2]), //year
                    saveParseToInt(subs[3]), //price
                    saveParseToInt(subs[4]), //wheelSize
                    saveParseToInt(subs[5]), //horsepower
                    saveParseToInt(subs[6]), //displacement
                    saveParseToInt(subs[7]), //engineType
                    saveParseToInt(subs[8]), //width
                    saveParseToInt(subs[9]), //height
                    saveParseToInt(subs[10]), //lenght
                    saveParseToInt(subs[11]), //gasMileage
                    subs[12], //drivetrain
                    saveParseToInt(subs[13]), //passengerCapacity
                    saveParseToInt(subs[14]), //passengerDoors
                    subs[15], //bodyStyle
                    fileName //imageName
                    ));
        }

        static public Car getCarByFilename(string fileName)
        {
            for(int i=0; i<items.Count; i++)
            {
                if(items[i].ImageName==fileName) return items[i];
            }
            return null;
        }


        static private void loadData()
        {
            var fileName = Directory.GetFiles(path).Select(f => Path.GetFileName(f));
            string[] fileEntries = fileName.ToArray();
            foreach (string fileEntry in fileEntries)
            {
                if (fileEntry.Substring(fileEntry.Length - 3, 3) == "txt") continue;
                Car car = loadCar(fileEntry);
                //System.IO.File.Create(path + "/" + fileEntry.Substring(0, fileEntry.Length - 3) + "txt");

                items.Add(car);
                saveAddToDict(makeDict,car.Make,car);
                saveAddToDict(modelDict, car.Model, car);
                saveAddToDict(yearDict, car.Year, car);
                saveAddToDict(priceDict, car.Price, car);
                saveAddToDict(wheelSizeDict, car.WheelSize, car);
                saveAddToDict(horsepowerDict, car.Horsepower, car);
                saveAddToDict(displacementDict, car.Displacement, car);
                saveAddToDict(engineTypeDict, car.EngineType, car);
                saveAddToDict(widthDict, car.Width, car);
                saveAddToDict(heightDict, car.Height, car);
                saveAddToDict(lengthDict, car.Length, car);
                saveAddToDict(gasMileageDict, car.GasMileage, car);
                saveAddToDict(drivetrainDict, car.Drivetrain, car);
                saveAddToDict(passengerCapacityDict, car.PassengerCapacity, car);
                saveAddToDict(passengerDoorsDict, car.PassengerDoors, car);
                saveAddToDict(bodyStyleDict, car.BodyStyle, car);
            }   
        }
    }
}
