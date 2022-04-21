using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CarDealer
{
    public partial class Main : Form
    {
        CarsList cars = new CarsList();
        private string path = Environment.CurrentDirectory;
        HashSet<Car> allCars = new HashSet<Car>();
        List<HashSet<Car>> states = new List<HashSet<Car>>();
        int actuallState = 0;
        public Main()
        {
            InitializeComponent();

            foreach(Car x in CarsList.Items)
            {
                allCars.Add(x);
            }
            states.Add(new HashSet<Car> (allCars));
            
            loadOptionsInSearchSection();
            loadPictures();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void loadOptionsInSearchSection()
        {
            this.carBrandListBox.Items.Clear();
            this.carBrandListBox.Items.AddRange(getCarBrands().ToArray());

            this.modelListBox.Items.Clear();
            this.modelListBox.Items.AddRange(getModels().ToArray());

            this.yearListBox.Items.Clear();
            this.yearListBox.Items.AddRange(getYears().ToArray());

            this.priceListBox.Items.Clear();
            this.priceListBox.Items.AddRange(getPrices().ToArray());

            this.wheelSizeListBox.Items.Clear();
            this.wheelSizeListBox.Items.AddRange(getWheelSizes().ToArray());

            this.horsePowerListBox.Items.Clear();
            this.horsePowerListBox.Items.AddRange(getHorsepowers().ToArray());

            this.displacementListBox.Items.Clear();
            this.displacementListBox.Items.AddRange(getDisplacement().ToArray());

            this.engineTypeListBox.Items.Clear();
            this.engineTypeListBox.Items.AddRange(getEngineTypes().ToArray());

            this.widthListBox.Items.Clear();
            this.widthListBox.Items.AddRange(getWidth().ToArray());

            this.heightListBox.Items.Clear();
            this.heightListBox.Items.AddRange(getHeight().ToArray());

            this.lengthListBox.Items.Clear();
            this.lengthListBox.Items.AddRange(getLength().ToArray());

            this.gasMileageListBox.Items.Clear();
            this.gasMileageListBox.Items.AddRange(getGasMileage().ToArray());

            this.driveTrainListBox.Items.Clear();
            this.driveTrainListBox.Items.AddRange(getDriveTrain().ToArray());

            this.passengerCapacityListBox.Items.Clear();
            this.passengerCapacityListBox.Items.AddRange(getPassengerCapacity().ToArray());

            this.passengerDoorsListBox.Items.Clear();
            this.passengerDoorsListBox.Items.AddRange(getPassengerDoors().ToArray());

            this.bodyStyleListBox.Items.Clear();
            this.bodyStyleListBox.Items.AddRange(getBodyStyle().ToArray());
        }

        private void loadPictures()
        {
            resultsTable.Controls.Clear();
            int k = 0;
            foreach(Car car in states[actuallState])
            {
                PictureBox pic = new PictureBox();
                pic.Size = new System.Drawing.Size(155, 155);
                pic.TabIndex = k;
                pic.TabStop = false;
                pic.Click += new System.EventHandler(pic_Click);
               // pic.Image = Image.FromFile(path + "\\Resources\\1000CarsDataSet\\" + car.ImageName);
                pic.ImageLocation = path + "\\Resources\\1000CarsDataSet\\" + car.ImageName;
                pic.AccessibleName = car.ImageName;
                k++;

                this.resultsTable.Controls.Add(pic);
            }
        }

        private HashSet<String> getCarBrands()
        {
            HashSet<String> carBrands = new HashSet<String>();
            foreach(Car car in states[actuallState])
            {
                carBrands.Add(car.Make + "(" +(new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.MakeDict[car.Make]))).Count.ToString() + ")");
            }
            return carBrands;
        }

        private HashSet<String> getModels()
        {
            HashSet<String>models = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                models.Add(car.Model + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.ModelDict[car.Model]))).Count.ToString() + ")");
            }
            return models;
        }

        private HashSet<String> getYears()
        {
            HashSet<String> years = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                years.Add(car.Year.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.YearDict[car.Year]))).Count.ToString() + ")");
            }
            return years;
        }

        private HashSet<String> getPrices()
        {
            HashSet<String> prices = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                prices.Add(car.Price.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.PriceDict[car.Price]))).Count.ToString() + ")");
            }
            return prices;
        }

        private HashSet<String> getWheelSizes()
        {
            HashSet<String> wheelsizes = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                wheelsizes.Add(car.WheelSize.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.WheelSizeDict[car.WheelSize]))).Count.ToString() + ")");
            }
            return wheelsizes;
        }

        private HashSet<String> getHorsepowers()
        {
            HashSet<String> horsepow = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                horsepow.Add(car.Horsepower.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.HorsepowerDict[car.Horsepower]))).Count.ToString() + ")");
            }
            return horsepow;
        }

        private HashSet<String> getDisplacement()
        {
            HashSet<String> dis = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                dis.Add(car.Displacement.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.DisplacementDict[car.Displacement]))).Count.ToString() + ")");
            }
            return dis;
        }

        private HashSet<String> getEngineTypes()
        {
            HashSet<String> enginetypes = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                enginetypes.Add(car.EngineType.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.EngineTypeDict[car.EngineType]))).Count.ToString() + ")");
            }
            return enginetypes;
        }

        private HashSet<String> getWidth()
        {
            HashSet<String> width = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                width.Add(car.Width.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.WidthDict[car.Width]))).Count.ToString() + ")");
            }
            return width;
        }

        private HashSet<String> getHeight()
        {
            HashSet<String> height = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                height.Add(car.Height.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.HeightDict[car.Height]))).Count.ToString() + ")");
            }
            return height;
        }

        private HashSet<String> getLength()
        {
            HashSet<String> length = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                length.Add(car.Length.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.LengthDict[car.Length]))).Count.ToString() + ")");
            }
            return length;
        }

        private HashSet<String> getGasMileage()
        {
            HashSet<String> gasmil = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                gasmil.Add(car.GasMileage.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.GasMileageDict[car.GasMileage]))).Count.ToString() + ")");
            }
            return gasmil;
        }

        private HashSet<String> getDriveTrain()
        {
            HashSet<String> drive = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                drive.Add(car.Drivetrain.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.DrivetrainDict[car.Drivetrain]))).Count.ToString() + ")");
            }
            return drive;
        }

        private HashSet<String> getPassengerCapacity()
        {
            HashSet<String> pass = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                pass.Add(car.PassengerCapacity.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.PassengerCapacityDict[car.PassengerCapacity]))).Count.ToString() + ")");
            }
            return pass;
        }

        private HashSet<String> getPassengerDoors()
        {
            HashSet<String> pass = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                pass.Add(car.PassengerDoors.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.PassengerDoorsDict[car.PassengerDoors]))).Count.ToString() + ")");
            }
            return pass;
        }

        private HashSet<String> getBodyStyle()
        {
            HashSet<String> body = new HashSet<String>();
            foreach (Car car in states[actuallState])
            {
                body.Add(car.BodyStyle.ToString() + "(" + (new HashSet<Car>(states[actuallState].Intersect<Car>
                    (CarsList.BodyStyleDict[car.BodyStyle]))).Count.ToString() + ")");
            }
            return body;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            HashSet<Car> carsSearchResultSet = new HashSet<Car>(allCars);
            List<HashSet<Car>> unions = new List<HashSet<Car>>();

            
            {
                //car brands
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in carBrandListBox.CheckedItems)
                {
                    sum.UnionWith(CarsList.MakeDict[Regex.Match(brand, "[a-zA-Z0-9 ]*").Value]);
                }
                unions.Add(sum);
            }
            {
                //car models
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in modelListBox.CheckedItems)
                    sum.UnionWith(CarsList.ModelDict[Regex.Match(brand, "[a-zA-Z0-9 ]*").Value]);
                unions.Add(sum);
            }
            {
                //year
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in yearListBox.CheckedItems)
                    sum.UnionWith(CarsList.YearDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //price
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in priceListBox.CheckedItems)
                    sum.UnionWith(CarsList.PriceDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //wheelsize
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in wheelSizeListBox.CheckedItems)
                    sum.UnionWith(CarsList.WheelSizeDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //horse power
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in horsePowerListBox.CheckedItems)
                    sum.UnionWith(CarsList.HorsepowerDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //displacement
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in displacementListBox.CheckedItems)
                    sum.UnionWith(CarsList.DisplacementDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //engine type
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in engineTypeListBox.CheckedItems)
                    sum.UnionWith(CarsList.EngineTypeDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //width
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in widthListBox.CheckedItems)
                    sum.UnionWith(CarsList.WidthDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //height
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in heightListBox.CheckedItems)
                    sum.UnionWith(CarsList.HeightDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //length
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in lengthListBox.CheckedItems)
                    sum.UnionWith(CarsList.LengthDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //gas mileage
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in lengthListBox.CheckedItems)
                    sum.UnionWith(CarsList.GasMileageDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //drivetrain
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in driveTrainListBox.CheckedItems)
                    sum.UnionWith(CarsList.DrivetrainDict[Regex.Match(brand, "[a-zA-Z0-9 ]*").Value]);
                unions.Add(sum);
            }
            {
                //passeneger capacity
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in passengerCapacityListBox.CheckedItems)
                    sum.UnionWith(CarsList.PassengerCapacityDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //Passenger Doors
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in passengerDoorsListBox.CheckedItems)
                    sum.UnionWith(CarsList.PassengerDoorsDict[int.Parse(Regex.Match(brand, "[a-zA-Z0-9 ]*").Value)]);
                unions.Add(sum);
            }
            {
                //body style
                HashSet<Car> sum = new HashSet<Car>();
                foreach (String brand in bodyStyleListBox.CheckedItems)
                    sum.UnionWith(CarsList.BodyStyleDict[Regex.Match(brand, "[a-zA-Z0-9 ]*").Value]);
                unions.Add(sum);
            }

            ///carsSearchResultSet.IntersectWith(sum);
            foreach (HashSet<Car> union in unions)
            {
                if(union.Count > 0)
                {
                    carsSearchResultSet.IntersectWith(union);
                }
            }

            addNewState(carsSearchResultSet);
            actuallState++;

            loadOptionsInSearchSection();
            loadPictures();
        }

        private void addNewState(HashSet<Car> temp)
        {
            states.Add(new HashSet<Car>(temp));
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //back state
            if(actuallState > 0) actuallState--;

            loadOptionsInSearchSection();
            loadPictures();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //next state
            if (actuallState < states.Count - 1) actuallState++;

            loadOptionsInSearchSection();
            loadPictures();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            ViewCarDetailsForm viewCar = new ViewCarDetailsForm(CarsList.getCarByFilename(((PictureBox)sender).AccessibleName)    );
            viewCar.Show();
        }
    }
}
