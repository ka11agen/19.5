namespace WindowsFormsApp3
{
    partial class Form2
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
            this.Volume = new System.Windows.Forms.CheckBox();
            this.Mass = new System.Windows.Forms.CheckBox();
            this.rad = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.Density = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(351, 78);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(61, 17);
            this.Volume.TabIndex = 0;
            this.Volume.Text = "Объем";
            this.Volume.UseVisualStyleBackColor = true;
            // 
            // Mass
            // 
            this.Mass.AutoSize = true;
            this.Mass.Location = new System.Drawing.Point(351, 119);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(59, 17);
            this.Mass.TabIndex = 1;
            this.Mass.Text = "Масса";
            this.Mass.UseVisualStyleBackColor = true;
            // 
            // rad
            // 
            this.rad.AutoSize = true;
            this.rad.Location = new System.Drawing.Point(69, 82);
            this.rad.Name = "rad";
            this.rad.Size = new System.Drawing.Size(43, 13);
            this.rad.TabIndex = 2;
            this.rad.Text = "Радиус";
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.Location = new System.Drawing.Point(69, 120);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(45, 13);
            this.Height.TabIndex = 3;
            this.Height.Text = "Высота";
            // 
            // Density
            // 
            this.Density.AutoSize = true;
            this.Density.Location = new System.Drawing.Point(69, 159);
            this.Density.Name = "Density";
            this.Density.Size = new System.Drawing.Size(61, 13);
            this.Density.TabIndex = 4;
            this.Density.Text = "Плотность";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(351, 155);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.UseWaitCursor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 285);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Density);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.rad);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.Volume);
            this.Name = "Form2";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Volume;
        private System.Windows.Forms.CheckBox Mass;
        private System.Windows.Forms.Label rad;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Density;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button OK;
    }
}