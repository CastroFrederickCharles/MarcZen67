namespace MarcZen
{
    partial class Inventory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new RoundedButton();
            this.btnPayments = new RoundedButton();
            this.btnReports = new RoundedButton();
            this.btnCustomers = new RoundedButton();
            this.btnRentalTransaction = new RoundedButton();
            this.btnMaintenance = new RoundedButton();
            this.btnInventory = new RoundedButton();
            this.btnDashboard = new RoundedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNameAdmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnPayments);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnRentalTransaction);
            this.panel1.Controls.Add(this.btnMaintenance);
            this.panel1.Controls.Add(this.btnInventory);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 1043);
            this.panel1.TabIndex = 19;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLogout.CornerRadius = 20;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.FlatAppearance.BorderSize = 5;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 977);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(308, 46);
            this.btnLogout.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.Black;
            this.btnPayments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPayments.CornerRadius = 20;
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayments.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPayments.FlatAppearance.BorderSize = 5;
            this.btnPayments.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.White;
            this.btnPayments.Location = new System.Drawing.Point(0, 734);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(308, 46);
            this.btnPayments.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnPayments.TabIndex = 6;
            this.btnPayments.Text = "Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Black;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReports.CornerRadius = 20;
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnReports.FlatAppearance.BorderSize = 5;
            this.btnReports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(0, 656);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(308, 46);
            this.btnReports.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Black;
            this.btnCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomers.CornerRadius = 20;
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCustomers.FlatAppearance.BorderSize = 5;
            this.btnCustomers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(0, 578);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(308, 46);
            this.btnCustomers.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRentalTransaction
            // 
            this.btnRentalTransaction.BackColor = System.Drawing.Color.Black;
            this.btnRentalTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRentalTransaction.CornerRadius = 20;
            this.btnRentalTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentalTransaction.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnRentalTransaction.FlatAppearance.BorderSize = 2;
            this.btnRentalTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentalTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentalTransaction.ForeColor = System.Drawing.Color.White;
            this.btnRentalTransaction.Location = new System.Drawing.Point(0, 422);
            this.btnRentalTransaction.Name = "btnRentalTransaction";
            this.btnRentalTransaction.Size = new System.Drawing.Size(308, 46);
            this.btnRentalTransaction.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnRentalTransaction.TabIndex = 3;
            this.btnRentalTransaction.Text = "Rental Transaction";
            this.btnRentalTransaction.UseVisualStyleBackColor = false;
            this.btnRentalTransaction.Click += new System.EventHandler(this.btnRentalTransaction_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Black;
            this.btnMaintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaintenance.CornerRadius = 20;
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnMaintenance.FlatAppearance.BorderSize = 5;
            this.btnMaintenance.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 500);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(308, 46);
            this.btnMaintenance.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnMaintenance.TabIndex = 3;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Black;
            this.btnInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInventory.CornerRadius = 20;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Enabled = false;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnInventory.FlatAppearance.BorderSize = 5;
            this.btnInventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 344);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(308, 46);
            this.btnInventory.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Black;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDashboard.CornerRadius = 20;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDashboard.FlatAppearance.BorderSize = 5;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 266);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(308, 46);
            this.btnDashboard.Style = RoundedButton.ButtonStyles.ButtonX;
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(28, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 135);
            this.panel2.TabIndex = 0;
            // 
            // lblNameAdmin
            // 
            this.lblNameAdmin.AutoSize = true;
            this.lblNameAdmin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAdmin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblNameAdmin.Location = new System.Drawing.Point(1536, 50);
            this.lblNameAdmin.Name = "lblNameAdmin";
            this.lblNameAdmin.Size = new System.Drawing.Size(213, 24);
            this.lblNameAdmin.TabIndex = 22;
            this.lblNameAdmin.Text = "Admin - Christina Ponce";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 37);
            this.label5.TabIndex = 20;
            this.label5.Text = "Inventory";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDate.Location = new System.Drawing.Point(1401, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(25, 24);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "...";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(342, 265);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1520, 668);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(1558, 238);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(191, 21);
            this.comboBoxFilter.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1755, 238);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1520, 243);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Filter:";
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNameAdmin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDate);
            this.Name = "Inventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton btnInventory;
        private RoundedButton btnDashboard;
        private RoundedButton btnLogout;
        private RoundedButton btnPayments;
        private RoundedButton btnReports;
        private RoundedButton btnCustomers;
        private RoundedButton btnRentalTransaction;
        private RoundedButton btnMaintenance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNameAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerDate;
    }
}