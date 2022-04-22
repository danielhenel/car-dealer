using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class ReservationForm : Form
    {
        private Car car;
        private ViewCarDetailsForm parent;
        public ReservationForm(Car car, ViewCarDetailsForm parent)
        {
            this.car = car;
            this.parent = parent;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            String path = "Resources/1000CarsDataSet";
            Reservation reservation = new Reservation(this.textBox.Text, this.dateTimePicker.Value);
           // System.IO.File.Create(path + "/" + car.ImageName.Substring(0, car.ImageName.Length - 3) + "txt");
            File.AppendAllText(path + "/" + car.ImageName.Substring(0, car.ImageName.Length - 3) + "txt", reservation.ToString()+"\n");
            parent.loadReservations(path + "/" + car.ImageName.Substring(0, car.ImageName.Length - 3) + "txt");
            parent.showReservations();
;            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
