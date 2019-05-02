namespace Project05
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
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visitName = new System.Windows.Forms.TextBox();
            this.visitScore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.homeScore = new System.Windows.Forms.TextBox();
            this.homeName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visit_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visit_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Home_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButt = new System.Windows.Forms.Button();
            this.clearButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(71, 163);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 20);
            this.dateBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sports Scores!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Visitor Team";
            // 
            // visitName
            // 
            this.visitName.Location = new System.Drawing.Point(414, 163);
            this.visitName.Name = "visitName";
            this.visitName.Size = new System.Drawing.Size(139, 20);
            this.visitName.TabIndex = 5;
            // 
            // visitScore
            // 
            this.visitScore.Location = new System.Drawing.Point(414, 218);
            this.visitScore.Name = "visitScore";
            this.visitScore.Size = new System.Drawing.Size(138, 20);
            this.visitScore.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Visitor Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Home Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(581, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Home Score";
            // 
            // homeScore
            // 
            this.homeScore.Location = new System.Drawing.Point(704, 217);
            this.homeScore.Name = "homeScore";
            this.homeScore.Size = new System.Drawing.Size(139, 20);
            this.homeScore.TabIndex = 10;
            // 
            // homeName
            // 
            this.homeName.Location = new System.Drawing.Point(703, 163);
            this.homeName.Name = "homeName";
            this.homeName.Size = new System.Drawing.Size(139, 20);
            this.homeName.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Visit_Name,
            this.Visit_score,
            this.Home_name,
            this.Home_score});
            this.dataGridView1.Location = new System.Drawing.Point(71, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(771, 227);
            this.dataGridView1.TabIndex = 12;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Visit_Name
            // 
            this.Visit_Name.HeaderText = "Visitor Team";
            this.Visit_Name.Name = "Visit_Name";
            // 
            // Visit_score
            // 
            this.Visit_score.HeaderText = "Score";
            this.Visit_score.Name = "Visit_score";
            // 
            // Home_name
            // 
            this.Home_name.HeaderText = "Home Team";
            this.Home_name.Name = "Home_name";
            // 
            // Home_score
            // 
            this.Home_score.HeaderText = "Score";
            this.Home_score.Name = "Home_score";
            // 
            // addButt
            // 
            this.addButt.Location = new System.Drawing.Point(71, 213);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(75, 23);
            this.addButt.TabIndex = 13;
            this.addButt.Text = "Add";
            this.addButt.UseVisualStyleBackColor = true;
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // clearButt
            // 
            this.clearButt.Location = new System.Drawing.Point(196, 213);
            this.clearButt.Name = "clearButt";
            this.clearButt.Size = new System.Drawing.Size(75, 23);
            this.clearButt.TabIndex = 14;
            this.clearButt.Text = "Clear";
            this.clearButt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 563);
            this.Controls.Add(this.clearButt);
            this.Controls.Add(this.addButt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.homeName);
            this.Controls.Add(this.homeScore);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.visitScore);
            this.Controls.Add(this.visitName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateBox);
            this.Name = "Form1";
            this.Text = "Sports Scores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox visitName;
        private System.Windows.Forms.TextBox visitScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox homeScore;
        private System.Windows.Forms.TextBox homeName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visit_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Visit_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Home_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Home_score;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Button clearButt;
    }
}

