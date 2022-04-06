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

        static List<Car> items;
        static private String path = "Resources/1000CarsDataSet";
        static Dictionary<string, HashSet<String>> makeDict = new Dictionary<string, HashSet<string>> {};
        static Dictionary<string, HashSet<String>> modelDict = new Dictionary<string, HashSet<string>> {};
        static Dictionary<int, HashSet<String>> yearDict = new Dictionary<int, HashSet<string>> {};
        static Dictionary<int, HashSet<String>> priceDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> wheelSizeDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> horsepowerDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> displacementDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> engineTypeDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> widthDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> heightDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> lenghtDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> gasMileageDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<string, HashSet<String>> drivetrainDict = new Dictionary<string, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> passengerCapacityDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<int, HashSet<String>> passengerDoorsDict = new Dictionary<int, HashSet<string>> { };
        static Dictionary<string, HashSet<String>> bodyStyleDict = new Dictionary<string, HashSet<string>> { };

        static private void saveAddToDict(Dictionary<string, HashSet<String>> dict, string key, string value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new HashSet<string>();
                dict[key].Add(value);
            }
        }

        static private void saveAddToDict(Dictionary<int, HashSet<String>> dict, int key, string value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(value);
            }
            else
            {
                dict[key] = new HashSet<string>();
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

        static private Car loadCar(string fileName)
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
                    subs[16] //imageName
                    ));
        }

        static private void loadData()
        {
            var fileName = Directory.GetFiles(path).Select(f => Path.GetFileName(f));
            string[] fileEntries = fileName.ToArray();
            foreach (string fileEntry in fileEntries)
            {
                Car car = loadCar(fileEntry);
                
                saveAddToDict(makeDict,car.Make,car.ImageName);
                saveAddToDict(modelDict, car.Model, car.ImageName);
                saveAddToDict(yearDict, car.Year, car.ImageName);
                saveAddToDict(priceDict, car.Price, car.ImageName);
                saveAddToDict(wheelSizeDict, car.WheelSize, car.ImageName);
                saveAddToDict(horsepowerDict, car.Horsepower, car.ImageName);
                saveAddToDict(displacementDict, car.Displacement, car.ImageName);
                saveAddToDict(engineTypeDict, car.EngineType, car.ImageName);
                saveAddToDict(widthDict, car.Width, car.ImageName);
                saveAddToDict(heightDict, car.Height, car.ImageName);
                saveAddToDict(lenghtDict, car.Lenght, car.ImageName);
                saveAddToDict(gasMileageDict, car.GasMileage, car.ImageName);
                saveAddToDict(drivetrainDict, car.Drivetrain, car.ImageName);
                saveAddToDict(passengerCapacityDict, car.PassengerCapacity, car.ImageName);
                saveAddToDict(passengerDoorsDict, car.PassengerDoors, car.ImageName);
                saveAddToDict(bodyStyleDict, car.BodyStyle, car.ImageName);
            }   
        }
    }
}
