namespace excel1
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
            this.readExcel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeToExcel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // readExcel
            // 
            this.readExcel.Location = new System.Drawing.Point(103, 13);
            this.readExcel.Name = "readExcel";
            this.readExcel.Size = new System.Drawing.Size(123, 55);
            this.readExcel.TabIndex = 0;
            this.readExcel.Text = "read excel";
            this.readExcel.UseVisualStyleBackColor = true;
            this.readExcel.Click += new System.EventHandler(this.readExcel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 35);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // writeToExcel
            // 
            this.writeToExcel.Location = new System.Drawing.Point(665, 690);
            this.writeToExcel.Name = "writeToExcel";
            this.writeToExcel.Size = new System.Drawing.Size(197, 71);
            this.writeToExcel.TabIndex = 3;
            this.writeToExcel.Text = "write To Excel";
            this.writeToExcel.UseVisualStyleBackColor = true;
            this.writeToExcel.Click += new System.EventHandler(this.writeToExcelClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 839);
            this.Controls.Add(this.writeToExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.readExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.Button readExcel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button writeToExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

