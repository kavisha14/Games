namespace Games
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
            this.math = new System.Windows.Forms.Button();
            this.comparison = new System.Windows.Forms.Button();
            this.mazerunner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Game World";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // math
            // 
            this.math.Location = new System.Drawing.Point(71, 153);
            this.math.Name = "math";
            this.math.Padding = new System.Windows.Forms.Padding(5);
            this.math.Size = new System.Drawing.Size(88, 47);
            this.math.TabIndex = 1;
            this.math.Text = "math game";
            this.math.UseVisualStyleBackColor = true;
            this.math.Click += new System.EventHandler(this.math_Click);
            // 
            // comparison
            // 
            this.comparison.Location = new System.Drawing.Point(187, 204);
            this.comparison.Name = "comparison";
            this.comparison.Padding = new System.Windows.Forms.Padding(5);
            this.comparison.Size = new System.Drawing.Size(100, 48);
            this.comparison.TabIndex = 2;
            this.comparison.Text = "comparison";
            this.comparison.UseVisualStyleBackColor = true;
            this.comparison.Click += new System.EventHandler(this.comparison_Click);
            // 
            // mazerunner
            // 
            this.mazerunner.Location = new System.Drawing.Point(319, 153);
            this.mazerunner.Name = "mazerunner";
            this.mazerunner.Padding = new System.Windows.Forms.Padding(5);
            this.mazerunner.Size = new System.Drawing.Size(104, 47);
            this.mazerunner.TabIndex = 3;
            this.mazerunner.Text = "maze runner";
            this.mazerunner.UseVisualStyleBackColor = true;
            this.mazerunner.Click += new System.EventHandler(this.mazerunner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(497, 318);
            this.Controls.Add(this.mazerunner);
            this.Controls.Add(this.comparison);
            this.Controls.Add(this.math);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button math;
        private System.Windows.Forms.Button comparison;
        private System.Windows.Forms.Button mazerunner;
    }
}

