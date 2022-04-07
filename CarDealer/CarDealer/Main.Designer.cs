using System.Drawing;

namespace CarDealer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftMenu = new System.Windows.Forms.Panel();
            this.bookTestDriveSection = new System.Windows.Forms.Panel();
            this.addNewCarSection = new System.Windows.Forms.Panel();
            this.searchSection = new System.Windows.Forms.Panel();
            this.optionsBar = new System.Windows.Forms.Panel();
            this.bodyStyleListBox = new System.Windows.Forms.CheckedListBox();
            this.passengerDoorsListBox = new System.Windows.Forms.CheckedListBox();
            this.passengerCapacityListBox = new System.Windows.Forms.CheckedListBox();
            this.bodyStylelabel = new System.Windows.Forms.Label();
            this.driveTrainListBox = new System.Windows.Forms.CheckedListBox();
            this.widthListBox = new System.Windows.Forms.CheckedListBox();
            this.passengerDoorsLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.engineTypeListBox = new System.Windows.Forms.CheckedListBox();
            this.passengerCapacityLabel = new System.Windows.Forms.Label();
            this.engineTypeLabel = new System.Windows.Forms.Label();
            this.displacementListBox = new System.Windows.Forms.CheckedListBox();
            this.gasMileageListBox = new System.Windows.Forms.CheckedListBox();
            this.lengthListBox = new System.Windows.Forms.CheckedListBox();
            this.driveTrainLabel = new System.Windows.Forms.Label();
            this.gasMileageLabel = new System.Windows.Forms.Label();
            this.heightListBox = new System.Windows.Forms.CheckedListBox();
            this.displacementLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.horsePowerListBox = new System.Windows.Forms.CheckedListBox();
            this.horsePowerlabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.wheelSizeListBox = new System.Windows.Forms.CheckedListBox();
            this.wheelSizelabel = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.CheckedListBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.yearListBox = new System.Windows.Forms.CheckedListBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelListBox = new System.Windows.Forms.CheckedListBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.carBrandListBox = new System.Windows.Forms.CheckedListBox();
            this.upMenu = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resultsTable = new System.Windows.Forms.FlowLayoutPanel();
            this.searchButton = new System.Windows.Forms.Button();
            this.leftMenu.SuspendLayout();
            this.addNewCarSection.SuspendLayout();
            this.searchSection.SuspendLayout();
            this.optionsBar.SuspendLayout();
            this.upMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftMenu
            // 
            this.leftMenu.Controls.Add(this.bookTestDriveSection);
            this.leftMenu.Controls.Add(this.addNewCarSection);
            this.leftMenu.Controls.Add(this.searchSection);
            this.leftMenu.Location = new System.Drawing.Point(0, 66);
            this.leftMenu.Name = "leftMenu";
            this.leftMenu.Size = new System.Drawing.Size(200, 600);
            this.leftMenu.TabIndex = 0;
            // 
            // bookTestDriveSection
            // 
            this.bookTestDriveSection.BackColor = System.Drawing.Color.RosyBrown;
            this.bookTestDriveSection.Location = new System.Drawing.Point(3, 497);
            this.bookTestDriveSection.Name = "bookTestDriveSection";
            this.bookTestDriveSection.Size = new System.Drawing.Size(200, 91);
            this.bookTestDriveSection.TabIndex = 2;
            // 
            // addNewCarSection
            // 
            this.addNewCarSection.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addNewCarSection.Controls.Add(this.searchButton);
            this.addNewCarSection.Location = new System.Drawing.Point(3, 404);
            this.addNewCarSection.Name = "addNewCarSection";
            this.addNewCarSection.Size = new System.Drawing.Size(200, 87);
            this.addNewCarSection.TabIndex = 1;
            this.addNewCarSection.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // searchSection
            // 
            this.searchSection.AutoScroll = true;
            this.searchSection.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchSection.Controls.Add(this.optionsBar);
            this.searchSection.Location = new System.Drawing.Point(3, 3);
            this.searchSection.Name = "searchSection";
            this.searchSection.Size = new System.Drawing.Size(200, 395);
            this.searchSection.TabIndex = 0;
            this.searchSection.Paint += new System.Windows.Forms.PaintEventHandler(this.searchSection_Paint);
            // 
            // optionsBar
            // 
            this.optionsBar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.optionsBar.Controls.Add(this.bodyStyleListBox);
            this.optionsBar.Controls.Add(this.passengerDoorsListBox);
            this.optionsBar.Controls.Add(this.passengerCapacityListBox);
            this.optionsBar.Controls.Add(this.bodyStylelabel);
            this.optionsBar.Controls.Add(this.driveTrainListBox);
            this.optionsBar.Controls.Add(this.widthListBox);
            this.optionsBar.Controls.Add(this.passengerDoorsLabel);
            this.optionsBar.Controls.Add(this.widthLabel);
            this.optionsBar.Controls.Add(this.engineTypeListBox);
            this.optionsBar.Controls.Add(this.passengerCapacityLabel);
            this.optionsBar.Controls.Add(this.engineTypeLabel);
            this.optionsBar.Controls.Add(this.displacementListBox);
            this.optionsBar.Controls.Add(this.gasMileageListBox);
            this.optionsBar.Controls.Add(this.lengthListBox);
            this.optionsBar.Controls.Add(this.driveTrainLabel);
            this.optionsBar.Controls.Add(this.gasMileageLabel);
            this.optionsBar.Controls.Add(this.heightListBox);
            this.optionsBar.Controls.Add(this.displacementLabel);
            this.optionsBar.Controls.Add(this.lengthLabel);
            this.optionsBar.Controls.Add(this.horsePowerListBox);
            this.optionsBar.Controls.Add(this.horsePowerlabel);
            this.optionsBar.Controls.Add(this.heightLabel);
            this.optionsBar.Controls.Add(this.wheelSizeListBox);
            this.optionsBar.Controls.Add(this.wheelSizelabel);
            this.optionsBar.Controls.Add(this.priceListBox);
            this.optionsBar.Controls.Add(this.priceLabel);
            this.optionsBar.Controls.Add(this.yearListBox);
            this.optionsBar.Controls.Add(this.yearLabel);
            this.optionsBar.Controls.Add(this.modelListBox);
            this.optionsBar.Controls.Add(this.modelLabel);
            this.optionsBar.Controls.Add(this.carBrandLabel);
            this.optionsBar.Controls.Add(this.carBrandListBox);
            this.optionsBar.Location = new System.Drawing.Point(0, 0);
            this.optionsBar.Name = "optionsBar";
            this.optionsBar.Size = new System.Drawing.Size(180, 2332);
            this.optionsBar.TabIndex = 1;
            // 
            // bodyStyleListBox
            // 
            this.bodyStyleListBox.FormattingEnabled = true;
            this.bodyStyleListBox.Location = new System.Drawing.Point(0, 2177);
            this.bodyStyleListBox.Name = "bodyStyleListBox";
            this.bodyStyleListBox.Size = new System.Drawing.Size(180, 109);
            this.bodyStyleListBox.TabIndex = 21;
            // 
            // passengerDoorsListBox
            // 
            this.passengerDoorsListBox.FormattingEnabled = true;
            this.passengerDoorsListBox.Location = new System.Drawing.Point(0, 2032);
            this.passengerDoorsListBox.Name = "passengerDoorsListBox";
            this.passengerDoorsListBox.Size = new System.Drawing.Size(180, 109);
            this.passengerDoorsListBox.TabIndex = 20;
            // 
            // passengerCapacityListBox
            // 
            this.passengerCapacityListBox.FormattingEnabled = true;
            this.passengerCapacityListBox.Location = new System.Drawing.Point(0, 1889);
            this.passengerCapacityListBox.Name = "passengerCapacityListBox";
            this.passengerCapacityListBox.Size = new System.Drawing.Size(180, 109);
            this.passengerCapacityListBox.TabIndex = 19;
            // 
            // bodyStylelabel
            // 
            this.bodyStylelabel.AutoSize = true;
            this.bodyStylelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyStylelabel.Location = new System.Drawing.Point(0, 2160);
            this.bodyStylelabel.Name = "bodyStylelabel";
            this.bodyStylelabel.Size = new System.Drawing.Size(82, 16);
            this.bodyStylelabel.TabIndex = 31;
            this.bodyStylelabel.Text = "Body Style";
            // 
            // driveTrainListBox
            // 
            this.driveTrainListBox.FormattingEnabled = true;
            this.driveTrainListBox.Location = new System.Drawing.Point(0, 1746);
            this.driveTrainListBox.Name = "driveTrainListBox";
            this.driveTrainListBox.Size = new System.Drawing.Size(180, 109);
            this.driveTrainListBox.TabIndex = 18;
            // 
            // widthListBox
            // 
            this.widthListBox.FormattingEnabled = true;
            this.widthListBox.Location = new System.Drawing.Point(0, 1172);
            this.widthListBox.Name = "widthListBox";
            this.widthListBox.Size = new System.Drawing.Size(180, 109);
            this.widthListBox.TabIndex = 17;
            // 
            // passengerDoorsLabel
            // 
            this.passengerDoorsLabel.AutoSize = true;
            this.passengerDoorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerDoorsLabel.Location = new System.Drawing.Point(0, 2016);
            this.passengerDoorsLabel.Name = "passengerDoorsLabel";
            this.passengerDoorsLabel.Size = new System.Drawing.Size(128, 16);
            this.passengerDoorsLabel.TabIndex = 30;
            this.passengerDoorsLabel.Text = "Passenger Doors";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(0, 1154);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(46, 16);
            this.widthLabel.TabIndex = 16;
            this.widthLabel.Text = "Width";
            // 
            // engineTypeListBox
            // 
            this.engineTypeListBox.FormattingEnabled = true;
            this.engineTypeListBox.Location = new System.Drawing.Point(-3, 1031);
            this.engineTypeListBox.Name = "engineTypeListBox";
            this.engineTypeListBox.Size = new System.Drawing.Size(180, 109);
            this.engineTypeListBox.TabIndex = 15;
            // 
            // passengerCapacityLabel
            // 
            this.passengerCapacityLabel.AutoSize = true;
            this.passengerCapacityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerCapacityLabel.Location = new System.Drawing.Point(0, 1869);
            this.passengerCapacityLabel.Name = "passengerCapacityLabel";
            this.passengerCapacityLabel.Size = new System.Drawing.Size(147, 16);
            this.passengerCapacityLabel.TabIndex = 29;
            this.passengerCapacityLabel.Text = "Passenger Capacity";
            // 
            // engineTypeLabel
            // 
            this.engineTypeLabel.AutoSize = true;
            this.engineTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineTypeLabel.Location = new System.Drawing.Point(0, 1012);
            this.engineTypeLabel.Name = "engineTypeLabel";
            this.engineTypeLabel.Size = new System.Drawing.Size(95, 16);
            this.engineTypeLabel.TabIndex = 14;
            this.engineTypeLabel.Text = "Engine Type";
            // 
            // displacementListBox
            // 
            this.displacementListBox.FormattingEnabled = true;
            this.displacementListBox.Location = new System.Drawing.Point(0, 889);
            this.displacementListBox.Name = "displacementListBox";
            this.displacementListBox.Size = new System.Drawing.Size(180, 109);
            this.displacementListBox.TabIndex = 13;
            // 
            // gasMileageListBox
            // 
            this.gasMileageListBox.FormattingEnabled = true;
            this.gasMileageListBox.Location = new System.Drawing.Point(0, 1604);
            this.gasMileageListBox.Name = "gasMileageListBox";
            this.gasMileageListBox.Size = new System.Drawing.Size(180, 109);
            this.gasMileageListBox.TabIndex = 25;
            // 
            // lengthListBox
            // 
            this.lengthListBox.FormattingEnabled = true;
            this.lengthListBox.Location = new System.Drawing.Point(0, 1459);
            this.lengthListBox.Name = "lengthListBox";
            this.lengthListBox.Size = new System.Drawing.Size(180, 109);
            this.lengthListBox.TabIndex = 24;
            // 
            // driveTrainLabel
            // 
            this.driveTrainLabel.AutoSize = true;
            this.driveTrainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driveTrainLabel.Location = new System.Drawing.Point(0, 1730);
            this.driveTrainLabel.Name = "driveTrainLabel";
            this.driveTrainLabel.Size = new System.Drawing.Size(74, 16);
            this.driveTrainLabel.TabIndex = 31;
            this.driveTrainLabel.Text = "Drivetrain";
            // 
            // gasMileageLabel
            // 
            this.gasMileageLabel.AutoSize = true;
            this.gasMileageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasMileageLabel.Location = new System.Drawing.Point(0, 1586);
            this.gasMileageLabel.Name = "gasMileageLabel";
            this.gasMileageLabel.Size = new System.Drawing.Size(95, 16);
            this.gasMileageLabel.TabIndex = 28;
            this.gasMileageLabel.Text = "Gas Mileage";
            // 
            // heightListBox
            // 
            this.heightListBox.FormattingEnabled = true;
            this.heightListBox.Location = new System.Drawing.Point(0, 1315);
            this.heightListBox.Name = "heightListBox";
            this.heightListBox.Size = new System.Drawing.Size(180, 109);
            this.heightListBox.TabIndex = 23;
            // 
            // displacementLabel
            // 
            this.displacementLabel.AutoSize = true;
            this.displacementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displacementLabel.Location = new System.Drawing.Point(0, 871);
            this.displacementLabel.Name = "displacementLabel";
            this.displacementLabel.Size = new System.Drawing.Size(102, 16);
            this.displacementLabel.TabIndex = 12;
            this.displacementLabel.Text = "Displacement";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(0, 1441);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(53, 16);
            this.lengthLabel.TabIndex = 27;
            this.lengthLabel.Text = "Length";
            // 
            // horsePowerListBox
            // 
            this.horsePowerListBox.FormattingEnabled = true;
            this.horsePowerListBox.Location = new System.Drawing.Point(0, 748);
            this.horsePowerListBox.Name = "horsePowerListBox";
            this.horsePowerListBox.Size = new System.Drawing.Size(180, 109);
            this.horsePowerListBox.TabIndex = 11;
            // 
            // horsePowerlabel
            // 
            this.horsePowerlabel.AutoSize = true;
            this.horsePowerlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horsePowerlabel.Location = new System.Drawing.Point(0, 730);
            this.horsePowerlabel.Name = "horsePowerlabel";
            this.horsePowerlabel.Size = new System.Drawing.Size(96, 16);
            this.horsePowerlabel.TabIndex = 10;
            this.horsePowerlabel.Text = "Horse Power";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(0, 1298);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(52, 16);
            this.heightLabel.TabIndex = 26;
            this.heightLabel.Text = "Height";
            // 
            // wheelSizeListBox
            // 
            this.wheelSizeListBox.FormattingEnabled = true;
            this.wheelSizeListBox.Location = new System.Drawing.Point(-3, 607);
            this.wheelSizeListBox.Name = "wheelSizeListBox";
            this.wheelSizeListBox.Size = new System.Drawing.Size(180, 109);
            this.wheelSizeListBox.TabIndex = 9;
            // 
            // wheelSizelabel
            // 
            this.wheelSizelabel.AutoSize = true;
            this.wheelSizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wheelSizelabel.Location = new System.Drawing.Point(0, 588);
            this.wheelSizelabel.Name = "wheelSizelabel";
            this.wheelSizelabel.Size = new System.Drawing.Size(85, 16);
            this.wheelSizelabel.TabIndex = 8;
            this.wheelSizelabel.Text = "Wheel Size";
            // 
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(0, 464);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(180, 109);
            this.priceListBox.TabIndex = 7;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(0, 445);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price";
            // 
            // yearListBox
            // 
            this.yearListBox.FormattingEnabled = true;
            this.yearListBox.Location = new System.Drawing.Point(0, 323);
            this.yearListBox.Name = "yearListBox";
            this.yearListBox.Size = new System.Drawing.Size(180, 109);
            this.yearListBox.TabIndex = 5;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(0, 304);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(40, 16);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year";
            // 
            // modelListBox
            // 
            this.modelListBox.FormattingEnabled = true;
            this.modelListBox.Location = new System.Drawing.Point(0, 178);
            this.modelListBox.Name = "modelListBox";
            this.modelListBox.Size = new System.Drawing.Size(180, 109);
            this.modelListBox.TabIndex = 3;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(0, 159);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(50, 16);
            this.modelLabel.TabIndex = 2;
            this.modelLabel.Text = "Model";
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBrandLabel.Location = new System.Drawing.Point(0, 17);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(76, 16);
            this.carBrandLabel.TabIndex = 1;
            this.carBrandLabel.Text = "Car Brand";
            // 
            // carBrandListBox
            // 
            this.carBrandListBox.FormattingEnabled = true;
            this.carBrandListBox.Location = new System.Drawing.Point(0, 36);
            this.carBrandListBox.Name = "carBrandListBox";
            this.carBrandListBox.Size = new System.Drawing.Size(180, 109);
            this.carBrandListBox.TabIndex = 0;
            // 
            // upMenu
            // 
            this.upMenu.BackColor = System.Drawing.Color.OrangeRed;
            this.upMenu.Controls.Add(this.nextButton);
            this.upMenu.Controls.Add(this.backButton);
            this.upMenu.Location = new System.Drawing.Point(0, 1);
            this.upMenu.Name = "upMenu";
            this.upMenu.Size = new System.Drawing.Size(1206, 59);
            this.upMenu.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(94, 10);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // resultsTable
            // 
            this.resultsTable.AutoScroll = true;
            this.resultsTable.BackColor = System.Drawing.Color.Turquoise;
            this.resultsTable.Location = new System.Drawing.Point(210, 66);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.Size = new System.Drawing.Size(996, 601);
            this.resultsTable.TabIndex = 2;
            this.resultsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.resultsTable_Paint);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(21, 17);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(156, 51);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 666);
            this.Controls.Add(this.resultsTable);
            this.Controls.Add(this.upMenu);
            this.Controls.Add(this.leftMenu);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.leftMenu.ResumeLayout(false);
            this.addNewCarSection.ResumeLayout(false);
            this.searchSection.ResumeLayout(false);
            this.optionsBar.ResumeLayout(false);
            this.optionsBar.PerformLayout();
            this.upMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftMenu;
        private System.Windows.Forms.Panel bookTestDriveSection;
        private System.Windows.Forms.Panel addNewCarSection;
        private System.Windows.Forms.Panel searchSection;
        private System.Windows.Forms.Panel upMenu;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.FlowLayoutPanel resultsTable;
        private System.Windows.Forms.Panel optionsBar;
        private System.Windows.Forms.CheckedListBox carBrandListBox;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.CheckedListBox modelListBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.CheckedListBox yearListBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.CheckedListBox priceListBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.CheckedListBox wheelSizeListBox;
        private System.Windows.Forms.Label wheelSizelabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.CheckedListBox engineTypeListBox;
        private System.Windows.Forms.Label engineTypeLabel;
        private System.Windows.Forms.CheckedListBox displacementListBox;
        private System.Windows.Forms.Label displacementLabel;
        private System.Windows.Forms.CheckedListBox horsePowerListBox;
        private System.Windows.Forms.Label horsePowerlabel;
        private System.Windows.Forms.CheckedListBox widthListBox;
        private System.Windows.Forms.CheckedListBox driveTrainListBox;
        private System.Windows.Forms.CheckedListBox passengerCapacityListBox;
        private System.Windows.Forms.CheckedListBox passengerDoorsListBox;
        private System.Windows.Forms.CheckedListBox bodyStyleListBox;
        private System.Windows.Forms.CheckedListBox heightListBox;
        private System.Windows.Forms.CheckedListBox lengthListBox;
        private System.Windows.Forms.CheckedListBox gasMileageListBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label gasMileageLabel;
        private System.Windows.Forms.Label passengerCapacityLabel;
        private System.Windows.Forms.Label passengerDoorsLabel;
        private System.Windows.Forms.Label driveTrainLabel;
        private System.Windows.Forms.Label bodyStylelabel;
        private System.Windows.Forms.Button searchButton;
    }
}

