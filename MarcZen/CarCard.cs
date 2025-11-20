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

        private Label lblStatus; // final status label (only ONE)

        public int InventoryID { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }

        // Left click event
        public event EventHandler CardClicked;

        // Right click status update event
        public event EventHandler<StatusChangeEventArgs> StatusChangeRequested;

        public CarCard()
        {
            InitializeComponent();
            SetupCard();
        }

        private void SetupCard()
        {
            // Card layout
            this.Size = new Size(180, 260);
            this.BackColor = Color.LightGray;
            this.Margin = new Padding(10);
            this.Cursor = Cursors.Hand;

            // Make all parts clickable (left click)
            this.Click += CarCard_Click;
            panelCard.Click += CarCard_Click;
            pictureBoxCar.Click += CarCard_Click;
            lblBrand.Click += CarCard_Click;
            lblModel.Click += CarCard_Click;

            // ----------------------------
            // CREATE STATUS LABEL
            // ----------------------------
            lblStatus = new Label();
            lblStatus.Location = new Point(10, 215);
            lblStatus.Size = new Size(160, 30);
            lblStatus.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.BackColor = Color.LightGray;
            this.Controls.Add(lblStatus);

            // ----------------------------
            // RIGHT-CLICK MENU (CONTEXT MENU)
            // ----------------------------
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            var availableItem = new ToolStripMenuItem("Mark as Available");
            availableItem.Click += (s, e) => QuickStatusChange("Available");

            var rentedItem = new ToolStripMenuItem("Mark as Rented");
            rentedItem.Click += (s, e) => QuickStatusChange("Rented");

            var maintenanceItem = new ToolStripMenuItem("Mark as Maintenance");
            maintenanceItem.Click += (s, e) => QuickStatusChange("Maintenance");

            contextMenu.Items.Add(availableItem);
            contextMenu.Items.Add(rentedItem);
            contextMenu.Items.Add(maintenanceItem);

            // Apply context menu to all clickable elements
            this.ContextMenuStrip = contextMenu;
            panelCard.ContextMenuStrip = contextMenu;
            pictureBoxCar.ContextMenuStrip = contextMenu;
            lblBrand.ContextMenuStrip = contextMenu;
            lblModel.ContextMenuStrip = contextMenu;
            lblStatus.ContextMenuStrip = contextMenu;
        }

        // HANDLE LEFT-CLICK
        private void CarCard_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, e);
        }

        // HANDLE RIGHT-CLICK STATUS CHANGE
        private void QuickStatusChange(string newStatus)
        {
            StatusChangeRequested?.Invoke(this,
                new StatusChangeEventArgs(InventoryID, newStatus, CarBrand, CarModel));
        }

        // SET CARD DATA
        public void SetCarData(int id, string brand, string model, string imagePath, string status = "Available")
        {
            InventoryID = id;
            CarBrand = brand;
            CarModel = model;
            ImagePath = imagePath;
            Status = status;

            lblBrand.Text = brand;
            lblModel.Text = model;

            UpdateStatusDisplay(status);
            LoadCarImage(imagePath);
        }

        // UPDATE STATUS LABEL APPEARANCE
        private void UpdateStatusDisplay(string status)
        {
            lblStatus.Text = status;

            switch (status.ToLower())
            {
                case "available":
                    lblStatus.BackColor = Color.LightGreen;
                    lblStatus.ForeColor = Color.DarkGreen;
                    break;

                case "rented":
                    lblStatus.BackColor = Color.LightCoral;
                    lblStatus.ForeColor = Color.DarkRed;
                    break;

                case "maintenance":
                    lblStatus.BackColor = Color.LightYellow;
                    lblStatus.ForeColor = Color.DarkOrange;
                    break;

                default:
                    lblStatus.BackColor = Color.LightGray;
                    lblStatus.ForeColor = Color.Black;
                    break;
            }
        }

        // LOAD IMAGE
        private void LoadCarImage(string imagePath)
        {
            try
            {
                string fullPath = Path.Combine(Application.StartupPath, "Images", imagePath);

                if (File.Exists(fullPath))
                {
                    pictureBoxCar.Image = Image.FromFile(fullPath);
                    pictureBoxCar.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBoxCar.Image = null;
                    pictureBoxCar.BackColor = Color.White;
                }
            }
            catch
            {
                pictureBoxCar.Image = null;
                pictureBoxCar.BackColor = Color.White;
            }
        }

        // DESIGNER UI INITIALIZATION
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
            this.panelCard.Size = new System.Drawing.Size(174, 200);
            this.panelCard.TabIndex = 0;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblModel.Location = new System.Drawing.Point(10, 160);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(69, 25);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(10, 135);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(55, 21);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand";
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(150, 120);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            // 
            // CarCard
            // 
            this.Controls.Add(this.panelCard);
            this.Name = "CarCard";
            this.Size = new System.Drawing.Size(180, 260);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);

        }
    }

    public class StatusChangeEventArgs : EventArgs
    {
        public int InventoryID { get; set; }
        public string NewStatus { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }

        public StatusChangeEventArgs(int inventoryId, string newStatus, string carBrand, string carModel)
        {
            InventoryID = inventoryId;
            NewStatus = newStatus;
            CarBrand = carBrand;
            CarModel = carModel;
        }
    }
}
