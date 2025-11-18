using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class Inventory : Form
    {
        private Timer Timer;
        private DatabaseHelper dbHelper;

        public Inventory()
        {
            InitializeComponent(); // <-- required to create lblDate and other controls

            // Initialize database helper
            dbHelper = new DatabaseHelper();

            // Setup timer
            Timer = new Timer();
            Timer.Interval = 1000; // 1 second
            Timer.Tick += Timer_Tick;
            Timer.Start();
            UpdateDateTimeLabel();

            // Setup form and load data
            SetupForm();
            LoadCarTypes();
            LoadInventory();
        }

        private void SetupForm()
        {
            // Test database connection
            if (!dbHelper.TestConnection())
            {
                MessageBox.Show("Failed to connect to database. Please check your connection settings.",
                    "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setup FlowLayoutPanel for car cards
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.Padding = new Padding(10);
        }

        // Load car types into ComboBox filter
        private void LoadCarTypes()
        {
            try
            {
                comboBoxFilter.Items.Clear();
                comboBoxFilter.Items.Add("All");

                DataTable dt = dbHelper.GetCarTypes();
                foreach (DataRow row in dt.Rows)
                {
                    if (row["CarType"] != DBNull.Value && !string.IsNullOrEmpty(row["CarType"].ToString()))
                    {
                        comboBoxFilter.Items.Add(row["CarType"].ToString());
                    }
                }

                comboBoxFilter.SelectedIndex = 0; // Select "All" by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading filters: " + ex.Message, "Error");
            }
        }

        // Load inventory and display as cards
        private void LoadInventory(string filterType = "All")
        {
            try
            {
                // Clear existing cards
                flowLayoutPanel1.Controls.Clear();

                // Load data from database
                DataTable dt = dbHelper.LoadInventory(filterType);

                // Create a card for each car
                foreach (DataRow row in dt.Rows)
                {
                    CarCard card = new CarCard();
                    card.SetCarData(
                        Convert.ToInt32(row["InventoryID"]),
                        row["CarBrand"].ToString(),
                        row["CarModel"].ToString(),
                        row["ImagePath"].ToString()
                    );

                    // Optional: Add click event to view details
                    card.CardClicked += Card_Clicked;

                    flowLayoutPanel1.Controls.Add(card);
                }

                // Show message if no cars found
                if (dt.Rows.Count == 0)
                {
                    Label lblNoData = new Label();
                    lblNoData.Text = "No vehicles found";
                    lblNoData.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                    lblNoData.ForeColor = Color.Gray;
                    lblNoData.AutoSize = true;
                    lblNoData.Padding = new Padding(20);
                    flowLayoutPanel1.Controls.Add(lblNoData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Error");
            }
        }

        // Handle card click event
        private void Card_Clicked(object sender, EventArgs e)
        {
            CarCard card = sender as CarCard;
            if (card != null)
            {
                MessageBox.Show(
                    $"Vehicle Selected:\n\n" +
                    $"Brand: {card.CarBrand}\n" +
                    $"Model: {card.CarModel}\n" +
                    $"ID: {card.InventoryID}",
                    "Car Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Search button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedFilter = comboBoxFilter.SelectedItem?.ToString() ?? "All";
            LoadInventory(selectedFilter);
        }

        // ComboBox selection changed (auto-search on change)
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBoxFilter.SelectedItem?.ToString() ?? "All";
            LoadInventory(selectedFilter);
        }

        // Date/Time methods
        private void UpdateDateTimeLabel()
        {
            DateTime now = DateTime.Now; // local system time
            lblDate.Text = now.ToString("dddd, MMMM dd yyyy  |  hh:mm tt");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        // Navigation buttons
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var form1 = new Dashboard();
            form1.FormClosed += (s, args) => this.Close();
            this.Hide();
            form1.Show();
        }

        private void btnRentalTransaction_Click(object sender, EventArgs e)
        {
            var form3 = new RentalTransaction();
            form3.FormClosed += (s, args) => this.Close();
            this.Hide();
            form3.Show();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            var form4 = new Maintenance();
            form4.FormClosed += (s, args) => this.Close();
            this.Hide();
            form4.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var form5 = new Customers();
            form5.FormClosed += (s, args) => this.Close();
            this.Hide();
            form5.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form6 = new Reports();
            form6.FormClosed += (s, args) => this.Close();
            this.Hide();
            form6.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            var form7 = new Payments();
            form7.FormClosed += (s, args) => this.Close();
            this.Hide();
            form7.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form8 = new Login();
            form8.FormClosed += (s, args) => this.Close();
            this.Hide();
            form8.Show();
        }
    }
}