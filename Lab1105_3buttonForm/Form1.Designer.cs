namespace Lab1105_3buttonForm
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
            this.tbForResults = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnWriteToFile = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbForResults
            // 
            this.tbForResults.Location = new System.Drawing.Point(247, 103);
            this.tbForResults.Multiline = true;
            this.tbForResults.Name = "tbForResults";
            this.tbForResults.Size = new System.Drawing.Size(237, 144);
            this.tbForResults.TabIndex = 0;
            this.tbForResults.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(351, 250);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(55, 17);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Results";
            // 
            // btnWriteToFile
            // 
            this.btnWriteToFile.Location = new System.Drawing.Point(82, 361);
            this.btnWriteToFile.Name = "btnWriteToFile";
            this.btnWriteToFile.Size = new System.Drawing.Size(97, 43);
            this.btnWriteToFile.TabIndex = 2;
            this.btnWriteToFile.Text = "Write Data To File";
            this.btnWriteToFile.UseVisualStyleBackColor = true;
            this.btnWriteToFile.Click += new System.EventHandler(this.btnWriteToFile_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(354, 361);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(102, 43);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(604, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWriteToFile);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.tbForResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbForResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnWriteToFile;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
    }
}

