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
    public partial class Maintenance : Form
    {
        private DatabaseHelper dbHelper;

        public Maintenance()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            SetupForm();
            LoadDataFromDatabase(); // Load existing data from database
        }

        private void SetupForm()
        {
            // Test database connection on startup
            if (!dbHelper.TestConnection())
            {
                MessageBox.Show("Failed to connect to database. Please check your connection settings.",
                    "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Setup DataGridView appearance
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        // Load data from database
        private void LoadDataFromDatabase()
        {
            try
            {
                DataTable dt = dbHelper.LoadMaintenanceRecords();
                dataGridView1.DataSource = dt;

                // Format currency columns
                if (dt.Columns.Contains("Material"))
                {
                    dataGridView1.Columns["Material"].DefaultCellStyle.Format = "₱#,##0.00";
                    dataGridView1.Columns["Labor"].DefaultCellStyle.Format = "₱#,##0.00";
                    dataGridView1.Columns["Other"].DefaultCellStyle.Format = "₱#,##0.00";
                    dataGridView1.Columns["Total"].DefaultCellStyle.Format = "₱#,##0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error");
            }
        }

        private void MarcZen_Load(object sender, EventArgs e)
        {
            // Start the timer on load
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateDateTimeLabel();
        }

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var form1 = new Dashboard();
            form1.FormClosed += (s, args) => this.Close();
            this.Hide();
            form1.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var form2 = new Inventory();
            form2.FormClosed += (s, args) => this.Close();
            this.Hide();
            form2.Show();
        }

        private void btnRentalTransaction_Click(object sender, EventArgs e)
        {
            var form3 = new RentalTransaction();
            form3.FormClosed += (s, args) => this.Close();
            this.Hide();
            form3.Show();
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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input controls
                DateTime date = dateTimePicker1.Value;
                string description = txtDescription.Text.Trim();
                string vehicle = txtVehicle.Text.Trim();
                string contact = txtContact.Text.Trim();

                // Validate inputs
                if (string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Please enter a maintenance description.", "Validation Error");
                    txtDescription.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(vehicle))
                {
                    MessageBox.Show("Please enter a vehicle.", "Validation Error");
                    txtVehicle.Focus();
                    return;
                }

                // Parse decimal values (with validation)
                decimal material = 0;
                decimal labor = 0;
                decimal other = 0;

                if (!string.IsNullOrEmpty(txtMaterial.Text) && !decimal.TryParse(txtMaterial.Text, out material))
                {
                    MessageBox.Show("Please enter a valid number for Material cost.", "Validation Error");
                    txtMaterial.Focus();
                    return;
                }

                if (!string.IsNullOrEmpty(txtLabor.Text) && !decimal.TryParse(txtLabor.Text, out labor))
                {
                    MessageBox.Show("Please enter a valid number for Labor cost.", "Validation Error");
                    txtLabor.Focus();
                    return;
                }

                if (!string.IsNullOrEmpty(txtOther.Text) && !decimal.TryParse(txtOther.Text, out other))
                {
                    MessageBox.Show("Please enter a valid number for Other cost.", "Validation Error");
                    txtOther.Focus();
                    return;
                }

                // Insert into database
                bool success = dbHelper.InsertMaintenanceRecord(date, description, vehicle,
                    contact, material, labor, other);

                if (success)
                {
                    MessageBox.Show("Maintenance record added successfully!", "Success");
                    ClearInputs();
                    LoadDataFromDatabase(); // Refresh the grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record: " + ex.Message, "Error");
            }
        }

        private void ClearInputs()
        {
            txtDescription.Clear();
            txtVehicle.Clear();
            txtContact.Clear();
            txtMaterial.Clear();
            txtLabor.Clear();
            txtOther.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txtDescription.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first.", "No Selection");
                return;
            }
            DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete this record?",
                        "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            int id = Convert.ToInt32(
                dataGridView1.SelectedRows[0].Cells["MaintenanceID"].Value);

            bool success = dbHelper.DeleteMaintenanceRecord(id);

            if (success)
            {
                MessageBox.Show("Deleted.");
                LoadDataFromDatabase();
            }

        }
    }
    }


        // Optional: Add refresh button functionality
 /*       private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
            MessageBox.Show("Data refreshed!", "Success");
        }
    }
}

*/                         