using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class Main : Form
    {
        CarsList cars = new CarsList();
        HashSet<Car> carsSearchResultSet = new HashSet<Car>();
        public Main()
        {
            InitializeComponent();

            foreach(Car x in CarsList.Items)
            carsSearchResultSet.Add(x);

            loadOptionsInSearchSection();
        }

        private void loadOptionsInSearchSection()
        {
            this.carBrandListBox.Items.AddRange(getCarBrands().ToArray());
            this.modelListBox.Items.AddRange(getModels().ToArray());
            this.yearListBox.Items.AddRange(getYears().ToArray());
            this.priceListBox.Items.AddRange(getPrices().ToArray());
        }

        private HashSet<String> getCarBrands()
        {
            HashSet<String> carBrands = new HashSet<String>();
            foreach(Car car in carsSearchResultSet)
            {
                carBrands.Add(car.Make);
            }
            return carBrands;
        }

        private HashSet<String> getModels()
        {
            HashSet<String>models = new HashSet<String>();
            foreach (Car car in carsSearchResultSet)
            {
                models.Add(car.Model);
            }
            return models;
        }

        private HashSet<String> getYears()
        {
            HashSet<String> years = new HashSet<String>();
            foreach (Car car in carsSearchResultSet)
            {
                years.Add(car.Year.ToString());
            }
            return years;
        }

        private HashSet<String> getPrices()
        {
            HashSet<String> prices = new HashSet<String>();
            foreach (Car car in carsSearchResultSet)
            {
                prices.Add(car.Price.ToString());
            }
            return prices;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add()
        {

        }

        private void remove()
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resultsTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchSection_Paint(object sender, PaintEventArgs e)
        {

        }

        private void carBrandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
