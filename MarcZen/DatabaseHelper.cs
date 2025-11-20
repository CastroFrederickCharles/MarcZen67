using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MarcZen
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MarcZenDB"].ConnectionString;
        }

        // ==================== GENERAL METHODS ====================

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

        // ==================== MAINTENANCE METHODS ====================

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
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message, "Database Error");
                return false;
            }
        }

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
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message, "Database Error");
                return new DataTable();
            }
        }

        public bool DeleteMaintenanceRecord(int maintenanceId)
        {
            try
            {
                string query = "DELETE FROM Maintenance WHERE MaintenanceID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", maintenanceId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting maintenance record: " + ex.Message, "Database Error");
                return false;
            }
        }

        // ==================== INVENTORY METHODS ====================

        public DataTable LoadInventory(string filterType = "All")
        {
            try
            {
                string query = @"SELECT 
                                InventoryID,
                                CarBrand,
                                CarModel,
                                CarType,
                                Year,
                                Color,
                                PlateNumber,
                                DailyRate,
                                Status,
                                ImagePath
                                FROM Inventory";

                if (filterType != "All")
                    query += " WHERE CarType = @FilterType";

                query += " ORDER BY CarBrand, CarModel";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    if (filterType != "All")
                        adapter.SelectCommand.Parameters.AddWithValue("@FilterType", filterType);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Database Error");
                return new DataTable();
            }
        }

        public bool InsertInventoryItem(string brand, string model, string type, int year,
            string color, string plateNumber, decimal dailyRate, string status, string imagePath)
        {
            try
            {
                string query = @"INSERT INTO Inventory 
                               (CarBrand, CarModel, CarType, Year, Color, PlateNumber, DailyRate, Status, ImagePath)
                               VALUES (@Brand, @Model, @Type, @Year, @Color, @PlateNumber, @DailyRate, @Status, @ImagePath)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Type", type ?? "");
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Color", color ?? "");
                    cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    cmd.Parameters.AddWithValue("@DailyRate", dailyRate);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath ?? "");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting inventory item: " + ex.Message, "Database Error");
                return false;
            }
        }

        public bool UpdateInventoryItem(int inventoryId, string brand, string model, string type,
            int year, string color, string plateNumber, decimal dailyRate, string status, string imagePath)
        {
            try
            {
                string query = @"UPDATE Inventory SET 
                               CarBrand = @Brand,
                               CarModel = @Model,
                               CarType = @Type,
                               Year = @Year,
                               Color = @Color,
                               PlateNumber = @PlateNumber,
                               DailyRate = @DailyRate,
                               Status = @Status,
                               ImagePath = @ImagePath
                               WHERE InventoryID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", inventoryId);
                    cmd.Parameters.AddWithValue("@Brand", brand);
                    cmd.Parameters.AddWithValue("@Model", model);
                    cmd.Parameters.AddWithValue("@Type", type ?? "");
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Color", color ?? "");
                    cmd.Parameters.AddWithValue("@PlateNumber", plateNumber);
                    cmd.Parameters.AddWithValue("@DailyRate", dailyRate);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ImagePath", imagePath ?? "");

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory item: " + ex.Message, "Database Error");
                return false;
            }
        }

        public bool DeleteInventoryItem(int inventoryId)
        {
            try
            {
                string query = "DELETE FROM Inventory WHERE InventoryID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", inventoryId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting inventory item: " + ex.Message, "Database Error");
                return false;
            }
        }

        public DataTable GetCarTypes()
        {
            try
            {
                string query = "SELECT DISTINCT CarType FROM Inventory ORDER BY CarType";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car types: " + ex.Message, "Database Error");
                return new DataTable();
            }
        }

        // ==================== STATUS METHODS (MERGED) ====================

        public string GetCarStatus(int inventoryId)
        {
            try
            {
                string query = "SELECT Status FROM Inventory WHERE InventoryID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", inventoryId);
                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    return result?.ToString() ?? "Unknown";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting status: " + ex.Message, "Database Error");
                return "Unknown";
            }
        }

        public bool UpdateCarStatus(int inventoryId, string newStatus)
        {
            try
            {
                string query = "UPDATE Inventory SET Status = @Status WHERE InventoryID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", inventoryId);
                    cmd.Parameters.AddWithValue("@Status", newStatus);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message, "Database Error");
                return false;
            }
        }
        // Get maintenance record ID by vehicle name
        public int? GetMaintenanceIDByVehicle(string vehicleName)
        {
            try
            {
                string query = "SELECT TOP 1 MaintenanceID FROM Maintenance WHERE Vehicle = @Vehicle ORDER BY CreatedDate DESC";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Vehicle", vehicleName);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            return Convert.ToInt32(result);
                        else
                            return null;
                    }
                }
            }
            catch
            {
                return null;
            }
        }

    }
}

