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
            this.upMenu = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resultsTable = new System.Windows.Forms.FlowLayoutPanel();
            this.optionsBar = new System.Windows.Forms.Panel();
            this.leftMenu.SuspendLayout();
            this.searchSection.SuspendLayout();
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
            // optionsBar
            // 
            this.optionsBar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.optionsBar.Location = new System.Drawing.Point(0, 0);
            this.optionsBar.Name = "optionsBar";
            this.optionsBar.Size = new System.Drawing.Size(180, 600);
            this.optionsBar.TabIndex = 1;
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
    }
}

