using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MarcZen
{
    public partial class Maintenance : Form
    {
        private DatabaseHelper dbHelper;
        private string vehicleToHighlight;

        public Maintenance(string vehicleName = "")
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            vehicleToHighlight = vehicleName;

            SetupForm();
            LoadDataFromDatabase();

            // Pre-fill txtVehicle if provided (Brand + Model)
            if (!string.IsNullOrEmpty(vehicleToHighlight))
            {
                txtVehicle.Text = vehicleToHighlight;
                txtVehicle.Focus();
            }
        }

        private void SetupForm()
        {
            // Test database connection
            if (!dbHelper.TestConnection())
            {
                MessageBox.Show("Failed to connect to database.", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // DataGridView settings
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

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

                // Highlight a vehicle if set
                if (!string.IsNullOrEmpty(vehicleToHighlight))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Vehicle"].Value.ToString() == vehicleToHighlight)
                        {
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error");
            }
        }

        private void MarcZen_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateDateTimeLabel();
        }

        private void UpdateDateTimeLabel()
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy  |  hh:mm tt");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            UpdateDateTimeLabel();
        }

        // Navigation buttons (Dashboard, Inventory, Rental, etc.)
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var form = new Dashboard();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            var form = new Inventory();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnRentalTransaction_Click(object sender, EventArgs e)
        {
            var form = new RentalTransaction();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            var form = new Customers();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form = new Reports();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            var form = new Payments();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var form = new Login();
            form.FormClosed += (s, args) => this.Close();
            this.Hide();
            form.Show();
        }

        // Add maintenance record
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker1.Value;
                string description = txtDescription.Text.Trim();
                string vehicle = txtVehicle.Text.Trim();
                string contact = txtContact.Text.Trim();

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

                decimal material = 0, labor = 0, other = 0;

                if (!string.IsNullOrEmpty(txtMaterial.Text) && !decimal.TryParse(txtMaterial.Text, out material))
                {
                    MessageBox.Show("Invalid Material cost.", "Validation Error");
                    txtMaterial.Focus();
                    return;
                }

                if (!string.IsNullOrEmpty(txtLabor.Text) && !decimal.TryParse(txtLabor.Text, out labor))
                {
                    MessageBox.Show("Invalid Labor cost.", "Validation Error");
                    txtLabor.Focus();
                    return;
                }

                if (!string.IsNullOrEmpty(txtOther.Text) && !decimal.TryParse(txtOther.Text, out other))
                {
                    MessageBox.Show("Invalid Other cost.", "Validation Error");
                    txtOther.Focus();
                    return;
                }

                bool success = dbHelper.InsertMaintenanceRecord(date, description, vehicle, contact, material, labor, other);

                if (success)
                {
                    MessageBox.Show("Maintenance record added successfully!", "Success");
                    ClearInputs();
                    LoadDataFromDatabase();
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
                MessageBox.Show("Select a record first.", "No Selection");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["MaintenanceID"].Value);
            bool success = dbHelper.DeleteMaintenanceRecord(id);

            if (success)
            {
                MessageBox.Show("Deleted successfully.", "Deleted");
                LoadDataFromDatabase();
            }
        }

        // Highlight a vehicle manually from other forms
        public void HighlightVehicle(string vehicleName)
        {
            vehicleToHighlight = vehicleName;
            LoadDataFromDatabase();

            // Pre-fill txtVehicle when highlighting
            if (!string.IsNullOrEmpty(vehicleToHighlight))
            {
                txtVehicle.Text = vehicleToHighlight;
            }
        }
    }
}
