namespace Project4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.TBZip = new System.Windows.Forms.TextBox();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.CBState = new System.Windows.Forms.ComboBox();
            this.ButAdd = new System.Windows.Forms.Button();
            this.ButExit = new System.Windows.Forms.Button();
            this.LblBottom = new System.Windows.Forms.Label();
            this.NumErr = new System.Windows.Forms.Label();
            this.CityErr = new System.Windows.Forms.Label();
            this.StateErr = new System.Windows.Forms.Label();
            this.ZipErr = new System.Windows.Forms.Label();
            this.AddressErr = new System.Windows.Forms.Label();
            this.FNErr = new System.Windows.Forms.Label();
            this.LNErr = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cearCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllCustomerToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.cearCustomersToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telephone Number";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFirstName.Location = new System.Drawing.Point(17, 90);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(168, 29);
            this.TBFirstName.TabIndex = 8;
            // 
            // TBLastName
            // 
            this.TBLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLastName.Location = new System.Drawing.Point(333, 90);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(172, 29);
            this.TBLastName.TabIndex = 9;
            // 
            // TBAddress
            // 
            this.TBAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAddress.Location = new System.Drawing.Point(17, 177);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(340, 29);
            this.TBAddress.TabIndex = 10;
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.Location = new System.Drawing.Point(17, 258);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(130, 29);
            this.TBCity.TabIndex = 11;
            // 
            // TBZip
            // 
            this.TBZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBZip.Location = new System.Drawing.Point(468, 258);
            this.TBZip.Name = "TBZip";
            this.TBZip.Size = new System.Drawing.Size(100, 29);
            this.TBZip.TabIndex = 12;
            // 
            // TBPhone
            // 
            this.TBPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBPhone.Location = new System.Drawing.Point(17, 360);
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.Size = new System.Drawing.Size(217, 29);
            this.TBPhone.TabIndex = 13;
            // 
            // CBState
            // 
            this.CBState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBState.FormattingEnabled = true;
            this.CBState.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.CBState.Location = new System.Drawing.Point(236, 255);
            this.CBState.Name = "CBState";
            this.CBState.Size = new System.Drawing.Size(146, 32);
            this.CBState.Sorted = true;
            this.CBState.TabIndex = 14;
            // 
            // ButAdd
            // 
            this.ButAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButAdd.Location = new System.Drawing.Point(590, 47);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(176, 71);
            this.ButAdd.TabIndex = 15;
            this.ButAdd.Text = "Add Customer";
            this.ButAdd.UseVisualStyleBackColor = true;
            this.ButAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // ButExit
            // 
            this.ButExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButExit.Location = new System.Drawing.Point(590, 149);
            this.ButExit.Name = "ButExit";
            this.ButExit.Size = new System.Drawing.Size(176, 71);
            this.ButExit.TabIndex = 16;
            this.ButExit.Text = "Exit";
            this.ButExit.UseVisualStyleBackColor = true;
            // 
            // LblBottom
            // 
            this.LblBottom.AutoSize = true;
            this.LblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBottom.ForeColor = System.Drawing.Color.Red;
            this.LblBottom.Location = new System.Drawing.Point(196, 435);
            this.LblBottom.Name = "LblBottom";
            this.LblBottom.Size = new System.Drawing.Size(381, 42);
            this.LblBottom.TabIndex = 17;
            this.LblBottom.Text = "Fix The Above Errors!";
            this.LblBottom.Visible = false;
            // 
            // NumErr
            // 
            this.NumErr.AutoSize = true;
            this.NumErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumErr.ForeColor = System.Drawing.Color.Red;
            this.NumErr.Location = new System.Drawing.Point(254, 366);
            this.NumErr.Name = "NumErr";
            this.NumErr.Size = new System.Drawing.Size(54, 20);
            this.NumErr.TabIndex = 18;
            this.NumErr.Text = "Blank";
            this.NumErr.Visible = false;
            // 
            // CityErr
            // 
            this.CityErr.AutoSize = true;
            this.CityErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityErr.ForeColor = System.Drawing.Color.Red;
            this.CityErr.Location = new System.Drawing.Point(153, 264);
            this.CityErr.Name = "CityErr";
            this.CityErr.Size = new System.Drawing.Size(54, 20);
            this.CityErr.TabIndex = 19;
            this.CityErr.Text = "Blank";
            this.CityErr.Visible = false;
            // 
            // StateErr
            // 
            this.StateErr.AutoSize = true;
            this.StateErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateErr.ForeColor = System.Drawing.Color.Red;
            this.StateErr.Location = new System.Drawing.Point(389, 264);
            this.StateErr.Name = "StateErr";
            this.StateErr.Size = new System.Drawing.Size(54, 20);
            this.StateErr.TabIndex = 20;
            this.StateErr.Text = "Blank";
            this.StateErr.Visible = false;
            // 
            // ZipErr
            // 
            this.ZipErr.AutoSize = true;
            this.ZipErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipErr.ForeColor = System.Drawing.Color.Red;
            this.ZipErr.Location = new System.Drawing.Point(574, 264);
            this.ZipErr.Name = "ZipErr";
            this.ZipErr.Size = new System.Drawing.Size(54, 20);
            this.ZipErr.TabIndex = 21;
            this.ZipErr.Text = "Blank";
            this.ZipErr.Visible = false;
            // 
            // AddressErr
            // 
            this.AddressErr.AutoSize = true;
            this.AddressErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressErr.ForeColor = System.Drawing.Color.Red;
            this.AddressErr.Location = new System.Drawing.Point(363, 183);
            this.AddressErr.Name = "AddressErr";
            this.AddressErr.Size = new System.Drawing.Size(54, 20);
            this.AddressErr.TabIndex = 22;
            this.AddressErr.Text = "Blank";
            this.AddressErr.Visible = false;
            // 
            // FNErr
            // 
            this.FNErr.AutoSize = true;
            this.FNErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNErr.ForeColor = System.Drawing.Color.Red;
            this.FNErr.Location = new System.Drawing.Point(191, 96);
            this.FNErr.Name = "FNErr";
            this.FNErr.Size = new System.Drawing.Size(54, 20);
            this.FNErr.TabIndex = 23;
            this.FNErr.Text = "Blank";
            this.FNErr.Visible = false;
            // 
            // LNErr
            // 
            this.LNErr.AutoSize = true;
            this.LNErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNErr.ForeColor = System.Drawing.Color.Red;
            this.LNErr.Location = new System.Drawing.Point(514, 96);
            this.LNErr.Name = "LNErr";
            this.LNErr.Size = new System.Drawing.Size(54, 20);
            this.LNErr.TabIndex = 24;
            this.LNErr.Text = "Blank";
            this.LNErr.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // displayAllCustomerToolStripMenuItem
            // 
            this.displayAllCustomerToolStripMenuItem.Name = "displayAllCustomerToolStripMenuItem";
            this.displayAllCustomerToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.displayAllCustomerToolStripMenuItem.Text = "Display All Customer";
            this.displayAllCustomerToolStripMenuItem.Click += new System.EventHandler(this.displayAllCustomerToolStripMenuItem_Click);
            // 
            // cearCustomersToolStripMenuItem
            // 
            this.cearCustomersToolStripMenuItem.Name = "cearCustomersToolStripMenuItem";
            this.cearCustomersToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.cearCustomersToolStripMenuItem.Text = "Clear Customers";
            this.cearCustomersToolStripMenuItem.Click += new System.EventHandler(this.cearCustomersToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 496);
            this.Controls.Add(this.LNErr);
            this.Controls.Add(this.FNErr);
            this.Controls.Add(this.AddressErr);
            this.Controls.Add(this.ZipErr);
            this.Controls.Add(this.StateErr);
            this.Controls.Add(this.CityErr);
            this.Controls.Add(this.NumErr);
            this.Controls.Add(this.LblBottom);
            this.Controls.Add(this.ButExit);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.CBState);
            this.Controls.Add(this.TBPhone);
            this.Controls.Add(this.TBZip);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.TBAddress);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Enter Customer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.TextBox TBZip;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.ComboBox CBState;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.Button ButExit;
        private System.Windows.Forms.Label LblBottom;
        private System.Windows.Forms.Label NumErr;
        private System.Windows.Forms.Label CityErr;
        private System.Windows.Forms.Label StateErr;
        private System.Windows.Forms.Label ZipErr;
        private System.Windows.Forms.Label AddressErr;
        private System.Windows.Forms.Label FNErr;
        private System.Windows.Forms.Label LNErr;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cearCustomersToolStripMenuItem;
    }
}

