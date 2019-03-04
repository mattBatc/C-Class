namespace Assignment4
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
            this.LblMessage = new System.Windows.Forms.Label();
            this.TBAnswer = new System.Windows.Forms.TextBox();
            this.BtnGetAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(64, 81);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(413, 72);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Your answer is:";
            // 
            // TBAnswer
            // 
            this.TBAnswer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.TBAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBAnswer.Location = new System.Drawing.Point(75, 170);
            this.TBAnswer.Name = "TBAnswer";
            this.TBAnswer.ReadOnly = true;
            this.TBAnswer.Size = new System.Drawing.Size(372, 35);
            this.TBAnswer.TabIndex = 1;
            // 
            // BtnGetAnswer
            // 
            this.BtnGetAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnGetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGetAnswer.Location = new System.Drawing.Point(139, 259);
            this.BtnGetAnswer.Name = "BtnGetAnswer";
            this.BtnGetAnswer.Size = new System.Drawing.Size(245, 73);
            this.BtnGetAnswer.TabIndex = 2;
            this.BtnGetAnswer.Text = "Get Answer";
            this.BtnGetAnswer.UseVisualStyleBackColor = true;
            this.BtnGetAnswer.Click += new System.EventHandler(this.BtnGetAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 412);
            this.Controls.Add(this.BtnGetAnswer);
            this.Controls.Add(this.TBAnswer);
            this.Controls.Add(this.LblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.TextBox TBAnswer;
        private System.Windows.Forms.Button BtnGetAnswer;
    }
}

