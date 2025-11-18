namespace MarcZen
{
    public partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new RoundedPanel();
            this.btnLogin = new RoundedButton();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.roundedTextBoxContainer2 = new RoundedTextBoxContainer();
            this.roundedTextBoxContainer1 = new RoundedTextBoxContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(217, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 223);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(32, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 265);
            this.panel2.TabIndex = 1;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.Black;
            this.roundedPanel1.BorderThickness = 1;
            this.roundedPanel1.Controls.Add(this.btnLogin);
            this.roundedPanel1.Controls.Add(this.cbRememberMe);
            this.roundedPanel1.Controls.Add(this.roundedTextBoxContainer2);
            this.roundedPanel1.Controls.Add(this.roundedTextBoxContainer1);
            this.roundedPanel1.Controls.Add(this.label3);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.CornerRadius = 15;
            this.roundedPanel1.Location = new System.Drawing.Point(1206, 90);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(635, 874);
            this.roundedPanel1.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.CornerRadius = 20;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(72, 661);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(496, 66);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRememberMe.Location = new System.Drawing.Point(131, 512);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(120, 24);
            this.cbRememberMe.TabIndex = 6;
            this.cbRememberMe.Text = "Remeber me";
            this.cbRememberMe.UseVisualStyleBackColor = true;
            // 
            // roundedTextBoxContainer2
            // 
            this.roundedTextBoxContainer2.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBoxContainer2.BackColorCustom = System.Drawing.Color.White;
            this.roundedTextBoxContainer2.BorderColor = System.Drawing.Color.Black;
            this.roundedTextBoxContainer2.BorderRadius = 10;
            this.roundedTextBoxContainer2.Location = new System.Drawing.Point(131, 460);
            this.roundedTextBoxContainer2.Name = "roundedTextBoxContainer2";
            this.roundedTextBoxContainer2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.roundedTextBoxContainer2.Size = new System.Drawing.Size(378, 35);
            this.roundedTextBoxContainer2.TabIndex = 4;
            this.roundedTextBoxContainer2.TextValue = "";
            // 
            // roundedTextBoxContainer1
            // 
            this.roundedTextBoxContainer1.BackColor = System.Drawing.Color.Transparent;
            this.roundedTextBoxContainer1.BackColorCustom = System.Drawing.Color.White;
            this.roundedTextBoxContainer1.BorderColor = System.Drawing.Color.Black;
            this.roundedTextBoxContainer1.BorderRadius = 10;
            this.roundedTextBoxContainer1.Location = new System.Drawing.Point(131, 328);
            this.roundedTextBoxContainer1.Name = "roundedTextBoxContainer1";
            this.roundedTextBoxContainer1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.roundedTextBoxContainer1.Size = new System.Drawing.Size(378, 35);
            this.roundedTextBoxContainer1.TabIndex = 3;
            this.roundedTextBoxContainer1.TextValue = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "Login";
            this.Text = "Login";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private RoundedButton btnLogin;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private RoundedTextBoxContainer roundedTextBoxContainer2;
        private RoundedTextBoxContainer roundedTextBoxContainer1;
    }
}