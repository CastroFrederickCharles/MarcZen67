using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class CarCard : UserControl
    {
        private Panel panelCard;
        private Label lblModel;
        private Label lblBrand;
        private PictureBox pictureBoxCar;

        public int InventoryID { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string ImagePath { get; set; }

        public CarCard()
        {
            InitializeComponent();
            SetupCard();
        }

        private void SetupCard()
        {
            // Style the card
            this.Size = new Size(180, 240);
            this.BackColor = Color.LightGray;
            this.Margin = new Padding(10);
            this.Cursor = Cursors.Hand; // Show it's clickable

            // Make entire card clickable
            this.Click += CarCard_Click;
            pictureBoxCar.Click += CarCard_Click;
            lblBrand.Click += CarCard_Click;
            lblModel.Click += CarCard_Click;
        }

        public void SetCarData(int id, string brand, string model, string imagePath)
        {
            InventoryID = id;
            CarBrand = brand;
            CarModel = model;
            ImagePath = imagePath;

            // Update labels
            lblBrand.Text = brand;
            lblModel.Text = model;

            // Load image
            LoadCarImage(imagePath);
        }

        private void LoadCarImage(string imagePath)
        {
            try
            {
                // Try to load from Images folder in project
                string fullPath = Path.Combine(Application.StartupPath, "Images", imagePath);

                if (File.Exists(fullPath))
                {
                    pictureBoxCar.Image = Image.FromFile(fullPath);
                    pictureBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // Show placeholder if image not found
                    pictureBoxCar.BackColor = Color.White;
                    pictureBoxCar.Image = null;
                }
            }
            catch
            {
                pictureBoxCar.BackColor = Color.White;
                pictureBoxCar.Image = null;
            }
        }

        // Card click event
        public event EventHandler CardClicked;

        private void CarCard_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }

        private void InitializeComponent()
        {
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Controls.Add(this.lblModel);
            this.panelCard.Controls.Add(this.lblBrand);
            this.panelCard.Controls.Add(this.pictureBoxCar);
            this.panelCard.Location = new System.Drawing.Point(3, 3);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(180, 240);
            this.panelCard.TabIndex = 0;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblModel.Location = new System.Drawing.Point(10, 165);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(65, 25);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "label2";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(10, 140);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 21);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "label1";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(160, 120);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // CarCard
            // 
            this.Controls.Add(this.panelCard);
            this.Name = "CarCard";
            this.Size = new System.Drawing.Size(186, 248);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}