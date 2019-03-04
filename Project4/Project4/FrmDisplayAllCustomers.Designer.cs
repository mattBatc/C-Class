namespace Project4
{
    partial class FrmDisplayAllCustomers
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
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LNColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FNColl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Project4.Program);
            // 
            // PhoneColl
            // 
            this.PhoneColl.HeaderText = "Phone Number";
            this.PhoneColl.Name = "PhoneColl";
            this.PhoneColl.ReadOnly = true;
            // 
            // ZipColl
            // 
            this.ZipColl.HeaderText = "Zip Code";
            this.ZipColl.Name = "ZipColl";
            this.ZipColl.ReadOnly = true;
            // 
            // StateColl
            // 
            this.StateColl.HeaderText = "State";
            this.StateColl.Name = "StateColl";
            this.StateColl.ReadOnly = true;
            // 
            // CityColl
            // 
            this.CityColl.HeaderText = "City";
            this.CityColl.Name = "CityColl";
            this.CityColl.ReadOnly = true;
            // 
            // AddColl
            // 
            this.AddColl.HeaderText = "Address";
            this.AddColl.Name = "AddColl";
            this.AddColl.ReadOnly = true;
            // 
            // LNColl
            // 
            this.LNColl.HeaderText = "Last Name";
            this.LNColl.Name = "LNColl";
            this.LNColl.ReadOnly = true;
            // 
            // FNColl
            // 
            this.FNColl.HeaderText = "First Name";
            this.FNColl.Name = "FNColl";
            this.FNColl.ReadOnly = true;
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FNColl,
            this.LNColl,
            this.AddColl,
            this.CityColl,
            this.StateColl,
            this.ZipColl,
            this.PhoneColl});
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.ReadOnly = true;
            this.listView.Size = new System.Drawing.Size(864, 573);
            this.listView.TabIndex = 0;
            // 
            // FrmDisplayAllCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 597);
            this.Controls.Add(this.listView);
            this.Name = "FrmDisplayAllCustomers";
            this.Text = "Display All Customers";
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn LNColl;
        private System.Windows.Forms.DataGridViewTextBoxColumn FNColl;
        private System.Windows.Forms.DataGridView listView;
    }
}