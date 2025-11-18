using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarcZen // Replace with your actual namespace
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MarcZenDB"].ConnectionString;
        }

        // Test database connection
        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message, "Error");
                return false;
            }
        }

        // Insert maintenance record
        public bool InsertMaintenanceRecord(DateTime date, string description, string vehicle,
            string contactNumber, decimal material, decimal labor, decimal other)
        {
            try
            {
                decimal total = material + labor + other;

                string query = @"INSERT INTO Maintenance 
                               (Date, MaintenanceDescription, Vehicle, ContactNumber, Material, Labor, OtherCost, Total)
                               VALUES (@Date, @Description, @Vehicle, @Contact, @Material, @Labor, @Other, @Total)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Vehicle", vehicle);
                        cmd.Parameters.AddWithValue("@Contact", contactNumber ?? "");
                        cmd.Parameters.AddWithValue("@Material", material);
                        cmd.Parameters.AddWithValue("@Labor", labor);
                        cmd.Parameters.AddWithValue("@Other", other);
                        cmd.Parameters.AddWithValue("@Total", total);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message, "Database Error");
                return false;
            }
        }

        // Load all maintenance records
        public DataTable LoadMaintenanceRecords()
        {
            try
            {
                string query = @"SELECT 
                    MaintenanceID,
                    FORMAT(Date, 'MM/dd/yy') AS Date,
                    MaintenanceDescription AS [Maintenance Description],
                    Vehicle,
                    ContactNumber AS [Contact Number],
                    Material,
                    Labor,
                    OtherCost AS Other,
                    Total
                   FROM Maintenance
                   ORDER BY Date DESC, CreatedDate DESC";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message, "Database Error");
                return new DataTable();
            }
        }

        // Delete maintenance record by ID
        public bool DeleteMaintenanceRecord(int maintenanceId)
        {
            try
            {
                string query = "DELETE FROM Maintenance WHERE MaintenanceID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", maintenanceId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Database Error");
                return false;
            }
        }
    }
}