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
            this.carBrandListBox = new System.Windows.Forms.CheckedListBox();
            this.upMenu = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resultsTable = new System.Windows.Forms.FlowLayoutPanel();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelListBox = new System.Windows.Forms.CheckedListBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearListBox = new System.Windows.Forms.CheckedListBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceListBox = new System.Windows.Forms.CheckedListBox();
            this.leftMenu.SuspendLayout();
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
            this.optionsBar.Size = new System.Drawing.Size(180, 1075);
            this.optionsBar.TabIndex = 1;
            // 
            // carBrandListBox
            // 
            this.carBrandListBox.FormattingEnabled = true;
            this.carBrandListBox.Location = new System.Drawing.Point(0, 36);
            this.carBrandListBox.Name = "carBrandListBox";
            this.carBrandListBox.Size = new System.Drawing.Size(180, 109);
            this.carBrandListBox.TabIndex = 0;
            this.carBrandListBox.SelectedIndexChanged += new System.EventHandler(this.carBrandListBox_SelectedIndexChanged);
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
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 11);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // resultsTable
            // 
            this.resultsTable.BackColor = System.Drawing.Color.Turquoise;
            this.resultsTable.Location = new System.Drawing.Point(210, 66);
            this.resultsTable.Name = "resultsTable";
            this.resultsTable.Size = new System.Drawing.Size(1031, 601);
            this.resultsTable.TabIndex = 2;
            this.resultsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.resultsTable_Paint);
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
            // modelListBox
            // 
            this.modelListBox.FormattingEnabled = true;
            this.modelListBox.Location = new System.Drawing.Point(0, 178);
            this.modelListBox.Name = "modelListBox";
            this.modelListBox.Size = new System.Drawing.Size(180, 109);
            this.modelListBox.TabIndex = 3;
            this.modelListBox.SelectedIndexChanged += new System.EventHandler(this.modelListBox_SelectedIndexChanged);
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
            // yearListBox
            // 
            this.yearListBox.FormattingEnabled = true;
            this.yearListBox.Location = new System.Drawing.Point(0, 323);
            this.yearListBox.Name = "yearListBox";
            this.yearListBox.Size = new System.Drawing.Size(180, 109);
            this.yearListBox.TabIndex = 5;
            this.yearListBox.SelectedIndexChanged += new System.EventHandler(this.yearListBox_SelectedIndexChanged);
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
            // priceListBox
            // 
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.Location = new System.Drawing.Point(0, 464);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(180, 109);
            this.priceListBox.TabIndex = 7;
            this.priceListBox.SelectedIndexChanged += new System.EventHandler(this.priceListBox_SelectedIndexChanged);
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
    }
}

