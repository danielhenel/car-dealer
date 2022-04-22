using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class ViewCarDetailsForm : Form
    {
        private string path = Environment.CurrentDirectory;
        private Car car = null;
        private List<Reservation> reservations = new List<Reservation>();
        bool[] validator = new bool[16];

        public ViewCarDetailsForm(Car car)
        {
            InitializeComponent();
            this.car = car;
            makeBox.Text = car.Make;
            modelBox.Text = car.Model;
            yearBox.Text = car.Year.ToString();
            priceBox.Text = car.Price.ToString();
            wheelSizeBox.Text = car.WheelSize.ToString();
            horsepowerBox.Text = car.Horsepower.ToString();
            displacementBox.Text = car.Displacement.ToString();
            engineTypeBox.Text = car.EngineType.ToString();
            widthBox.Text = car.Width.ToString();
            heightBox.Text = car.Height.ToString();
            lengthBox.Text = car.Length.ToString();
            gasMileageBox.Text = car.GasMileage.ToString();
            drivetrainBox.Text = car.Drivetrain.ToString();
            passengerCapacityBox.Text = car.PassengerCapacity.ToString();
            passengerDoorsBox.Text = car.PassengerDoors.ToString();
            bodyStyleBox.Text = car.BodyStyle.ToString();
            pic.Image = Image.FromFile(path + "\\Resources\\1000CarsDataSet\\" + car.ImageName);

            loadReservations("Resources/1000CarsDataSet" + "/" + car.ImageName.Substring(0, car.ImageName.Length - 3) + "txt");
            showReservations();

            for (int i = 0; i < validator.Length; i++)
            {
                validator[i] = true;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveValues();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            makeBox.Text = car.Make;
            modelBox.Text = car.Model;
            yearBox.Text = car.Year.ToString();
            priceBox.Text = car.Price.ToString();
            wheelSizeBox.Text = car.WheelSize.ToString();
            horsepowerBox.Text = car.Horsepower.ToString();
            displacementBox.Text = car.Displacement.ToString();
            engineTypeBox.Text = car.EngineType.ToString();
            widthBox.Text = car.Width.ToString();
            heightBox.Text = car.Height.ToString();
            lengthBox.Text = car.Length.ToString();
            gasMileageBox.Text = car.GasMileage.ToString();
            drivetrainBox.Text = car.Drivetrain.ToString();
            passengerCapacityBox.Text = car.PassengerCapacity.ToString();
            passengerDoorsBox.Text = car.PassengerDoors.ToString();
            bodyStyleBox.Text = car.BodyStyle.ToString();
            pic.Image = Image.FromFile(path + "\\Resources\\1000CarsDataSet\\" + car.ImageName);

            for (int i = 0; i < validator.Length; i++)
            {
                validator[i] = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.engineTypeBox.ReadOnly = false;
            this.displacementBox.ReadOnly = false;
            this.horsepowerBox.ReadOnly = false;
            this.wheelSizeBox.ReadOnly = false;
            this.yearBox.ReadOnly = false;
            this.modelBox.ReadOnly = false;
            this.makeBox.ReadOnly = false;
            this.bodyStyleBox.ReadOnly = false;
            this.passengerDoorsBox.ReadOnly = false;
            this.passengerCapacityBox.ReadOnly = false;
            this.gasMileageBox.ReadOnly = false;
            this.heightBox.ReadOnly = false;
            this.lengthBox.ReadOnly = false;
            this.widthBox.ReadOnly = false;
            this.priceBox.ReadOnly = false;
            this.drivetrainBox.ReadOnly = false;
            this.editButton.Visible = false;
            this.saveButton.Visible = true;
            this.resetButton.Visible = true;
            this.cancelButton.Visible = true;
            this.saveButton.Enabled = false;

        }

        private void makeBox_Validating(object sender, CancelEventArgs e)
        {
            validator[0] = true;

            activateSaveButton();
        }

        private void modelBox_Validating(object sender, CancelEventArgs e)
        {
            validator[1] = true;

            activateSaveButton();
        }

        private void yearBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.yearBox.Text);
                if (newValue > 1900 && newValue <= DateTime.Now.Year)
                {
                    validator[2] = true;
                }
                else
                {
                    this.yearBox.Text = "WRONG VALUE!";
                    validator[2] = false;
                }
            }
            catch
            {
                this.yearBox.Text = "WRONG VALUE!";
                validator[2] = false;
            }
            activateSaveButton();
        }

        private void priceBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.priceBox.Text);
                if (newValue > 0 && newValue <= 1000)
                {
                    validator[3] = true;
                }
                else
                {
                    this.priceBox.Text = "WRONG VALUE!";
                    validator[3] = false;
                }
            }
            catch
            {
                this.priceBox.Text = "WRONG VALUE!";
                validator[3] = false;
            }
            activateSaveButton();
        }

        private void wheelSizeBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.wheelSizeBox.Text);
                if (newValue > 0)
                {
                    validator[4] = true;
                }
                else
                {
                    this.wheelSizeBox.Text = "WRONG VALUE!";
                    validator[4] = false;
                }
            }
            catch
            {
                this.wheelSizeBox.Text = "WRONG VALUE!";
                validator[4] = false;
            }
            activateSaveButton();
        }

        private void horsepowerBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.horsepowerBox.Text);
                if (newValue > 0)
                {
                    validator[5] = true;
                }
                else
                {
                    this.horsepowerBox.Text = "WRONG VALUE!";
                    validator[5] = false;
                }
            }
            catch
            {
                this.horsepowerBox.Text = "WRONG VALUE!";
                validator[5] = false;
            }
            activateSaveButton();
        }

        private void displacementBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.displacementBox.Text);
                if (newValue > 0)
                {
                    validator[6] = true;
                }
                else
                {
                    this.displacementBox.Text = "WRONG VALUE!";
                    validator[6] = false;
                }
            }
            catch
            {
                this.displacementBox.Text = "WRONG VALUE!";
                validator[6] = false;
            }

            activateSaveButton();
        }

        private void engineTypeBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.engineTypeBox.Text);
                if (newValue > 0)
                {
                    validator[7] = true;
                }
                else
                {
                    this.engineTypeBox.Text = "WRONG VALUE!";
                    validator[7] = false;
                }
            }
            catch
            {
                this.engineTypeBox.Text = "WRONG VALUE!";
                validator[7] = false;
            }

            activateSaveButton();
        }

        private void widthBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.widthBox.Text);
                if (newValue > 0)
                {
                    validator[8] = true;
                }
                else
                {
                    this.widthBox.Text = "WRONG VALUE!";
                    validator[8] = false;
                }
            }
            catch
            {
                this.widthBox.Text = "WRONG VALUE!";
                validator[8] = false;
            }
            activateSaveButton();
        }

        private void lengthBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.lengthBox.Text);
                if (newValue > 0)
                {
                    validator[9] = true;
                }
                else
                {
                    this.lengthBox.Text = "WRONG VALUE!";
                    validator[9] = false;
                }
            }
            catch
            {
                this.lengthBox.Text = "WRONG VALUE!";
                validator[9] = false;
            }

            activateSaveButton();
        }

        private void heightBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.heightBox.Text);
                if (newValue > 0)
                {
                    validator[10] = true;
                }
                else
                {
                    this.heightBox.Text = "WRONG VALUE!";
                    validator[10] = false;
                }
            }
            catch
            {
                this.heightBox.Text = "WRONG VALUE!";
                validator[10] = false;
            }

            activateSaveButton();
        }

        private void gasMileageBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.gasMileageBox.Text);
                if (newValue > 0)
                {
                    validator[11] = true;
                }
                else
                {
                    this.gasMileageBox.Text = "WRONG VALUE!";
                    validator[11] = false;
                }
            }
            catch
            {
                this.gasMileageBox.Text = "WRONG VALUE!";
                validator[11] = false;
            }

            activateSaveButton();
        }

        private void drivetrainBox_Validating(object sender, CancelEventArgs e)
        {
            validator[12] = true;

            activateSaveButton();
        }

        private void passengerCapacityBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.passengerCapacityBox.Text);
                if (newValue > 0)
                {
                    validator[13] = true;
                }
                else
                {
                    this.passengerCapacityBox.Text = "WRONG VALUE!";
                    validator[13] = false;
                }
            }
            catch
            {
                this.passengerCapacityBox.Text = "WRONG VALUE!";
                validator[13] = false;
            }

            activateSaveButton();
        }

        private void passengerDoorsBox_Validating(object sender, CancelEventArgs e)
        {
            int newValue;
            try
            {
                newValue = int.Parse(this.passengerDoorsBox.Text);
                if (newValue > 0)
                {
                    validator[14] = true;
                }
                else
                {
                    this.passengerDoorsBox.Text = "WRONG VALUE!";
                    validator[14] = false;
                }
            }
            catch
            {
                this.passengerDoorsBox.Text = "WRONG VALUE!";
                validator[14] = false;
            }

            activateSaveButton();
        }

        private void bodyStyleBox_Validating(object sender, CancelEventArgs e)
        {
            validator[15] = true;

            activateSaveButton();
        }

        private void activateSaveButton()
        {
            for(int i = 0; i < validator.Length; i++)
            {
                if (validator[i] == false)
                {
                    saveButton.Enabled = false;
                    return;
                }
                    
            }
            saveButton.Enabled = true;
        }

        private void saveValues()
        {
            car.Make = makeBox.Text;
            car.Model = modelBox.Text;
            car.Year = int.Parse(yearBox.Text);
            car.Price = int.Parse(priceBox.Text);
            car.WheelSize = int.Parse(wheelSizeBox.Text);
            car.Horsepower = int.Parse(horsepowerBox.Text);
            car.Displacement = int.Parse(displacementBox.Text);
            car.EngineType = int.Parse(engineTypeBox.Text);
            car.Width = int.Parse(widthBox.Text);
            car.Height = int.Parse(heightBox.Text);
            car.Length = int.Parse(lengthBox.Text);
            car.GasMileage = int.Parse(gasMileageBox.Text);
            car.Drivetrain = drivetrainBox.Text;
            car.PassengerCapacity = int.Parse(passengerCapacityBox.Text);
            car.PassengerDoors = int.Parse(passengerDoorsBox.Text);
            bodyStyleBox.Text = car.BodyStyle;

            this.editButton.Visible = true;
            this.saveButton.Visible = false;
            this.resetButton.Visible = false;
            this.cancelButton.Visible = false;
            //String path = "Resources/1000CarsDataSet/";
            //pic.ImageLocation = "Resources/1000CarsDataSet/" + car.ToString();
            //System.IO.File.Move(path+car.ImageName, path+car.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ReservationForm re = new ReservationForm(car, this);
            re.Show();
        }

        private Reservation parseReservation(String line)
        {
            String [] subs = line.Split(' ');
            String name = "";
            String date = "";
            bool name1 = false;
            bool date1 = false;

            foreach(String sub in subs)
            {
                if (sub == "NAME:")
                {
                    date1 = false;
                    name1 = true;
                }
                else if (sub == "DATE:")
                {
                    date1 = true;
                    name1 = false;
                }
                else
                {
                    if (name1)
                    {
                        if(name == "")
                        {
                            name += sub;
                        }
                        else
                        {
                            name += " " + sub;
                        }
                        
                    }
                    
                    if (date1)
                    {
                        if (date == "")
                        { 
                       
                            date += sub;
                        }
                        else
                        {
                            date += " " + sub;
                        }
                    }
                }
            }

            Console.WriteLine(date);
            DateTime date2 = DateTime.Parse(date);
            return new Reservation(name, date2);
        }

        public void loadReservations(String filename)
        {
            reservations.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != " ")
                    { Reservation r = parseReservation(line);
                        reservations.Add(r);
                            }
                }
            }
        }

        public void showReservations()
        {
            this.flowLayoutPanel1.Controls.Clear();
            int k  = 0;
            foreach(Reservation r in reservations.ToArray())
            {

                Panel panel = new Panel();
                panel.Location = new System.Drawing.Point(3, 3);
                panel.Name = "panel"+k.ToString();
                panel.Size = new System.Drawing.Size(363, 50);
                panel.TabIndex = k;
                panel.Click += new System.EventHandler(this.panel_Click);
                panel.BackColor = System.Drawing.Color.Red;
                panel.AccessibleName = r.ToString();
                
                Label name = new Label();
                Label date = new Label();
               
                name.Text = r.Name;
                date.Text = r.Date.ToString();

                panel.Controls.Add(name);
                panel.Controls.Add(date);

                name.AutoSize = true;
                name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
                name.Location = new System.Drawing.Point(0, 10);

                date.AutoSize = true;
                date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
                date.Location = new System.Drawing.Point(0, 30);


                this.flowLayoutPanel1.Controls.Add(panel);

                k++;
                
            }
        }

        private void panel_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
