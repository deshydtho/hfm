namespace Myren_Sutton_M5P13
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
            this.num_tb = new System.Windows.Forms.TextBox();
            this.list = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many random numbers would you like written in this file?";
            // 
            // num_tb
            // 
            this.num_tb.Location = new System.Drawing.Point(126, 63);
            this.num_tb.Name = "num_tb";
            this.num_tb.Size = new System.Drawing.Size(100, 20);
            this.num_tb.TabIndex = 1;
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(105, 106);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(138, 43);
            this.list.TabIndex = 2;
            this.list.Text = "Write and Save";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // save
            // 
            this.save.Title = "Save File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 161);
            this.Controls.Add(this.list);
            this.Controls.Add(this.num_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ramdom Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num_tb;
        private System.Windows.Forms.Button list;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

