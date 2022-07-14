namespace Myren_Sutton_M5P11
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
            this.g_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ng = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess A Number 1-100";
            // 
            // g_tb
            // 
            this.g_tb.Location = new System.Drawing.Point(85, 79);
            this.g_tb.Name = "g_tb";
            this.g_tb.Size = new System.Drawing.Size(113, 20);
            this.g_tb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ng
            // 
            this.ng.AutoSize = true;
            this.ng.Location = new System.Drawing.Point(190, 9);
            this.ng.Name = "ng";
            this.ng.Size = new System.Drawing.Size(64, 13);
            this.ng.TabIndex = 3;
            this.ng.Text = "# Guesses: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.ng);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.g_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox g_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ng;
    }
}

