
namespace LabControls
{
    partial class RGB
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RGBColor = new System.Windows.Forms.PictureBox();
            this.Dec = new System.Windows.Forms.RadioButton();
            this.Hex = new System.Windows.Forms.RadioButton();
            this.Blue = new LabControls.RGBTextBox(this.components);
            this.Green = new LabControls.RGBTextBox(this.components);
            this.Red = new LabControls.RGBTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RGBColor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Красный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зелёный";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Синий";
            // 
            // RGBColor
            // 
            this.RGBColor.BackColor = System.Drawing.Color.Black;
            this.RGBColor.Location = new System.Drawing.Point(122, 4);
            this.RGBColor.Name = "RGBColor";
            this.RGBColor.Size = new System.Drawing.Size(105, 105);
            this.RGBColor.TabIndex = 6;
            this.RGBColor.TabStop = false;
            // 
            // Dec
            // 
            this.Dec.AutoSize = true;
            this.Dec.Checked = true;
            this.Dec.Enabled = false;
            this.Dec.Location = new System.Drawing.Point(8, 82);
            this.Dec.Name = "Dec";
            this.Dec.Size = new System.Drawing.Size(45, 17);
            this.Dec.TabIndex = 7;
            this.Dec.TabStop = true;
            this.Dec.Text = "Dec";
            this.Dec.UseVisualStyleBackColor = true;
            this.Dec.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // Hex
            // 
            this.Hex.AutoSize = true;
            this.Hex.Location = new System.Drawing.Point(63, 82);
            this.Hex.Name = "Hex";
            this.Hex.Size = new System.Drawing.Size(44, 17);
            this.Hex.TabIndex = 8;
            this.Hex.Text = "Hex";
            this.Hex.UseVisualStyleBackColor = true;
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(63, 56);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(42, 20);
            this.Blue.TabIndex = 3;
            this.Blue.Text = "0";
            this.Blue.TextChanged += new System.EventHandler(this.RGBTextBox_TextChanged);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(63, 30);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(42, 20);
            this.Green.TabIndex = 2;
            this.Green.Text = "0";
            this.Green.TextChanged += new System.EventHandler(this.RGBTextBox_TextChanged);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(63, 4);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(42, 20);
            this.Red.TabIndex = 1;
            this.Red.Text = "0";
            this.Red.TextChanged += new System.EventHandler(this.RGBTextBox_TextChanged);
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Hex);
            this.Controls.Add(this.Dec);
            this.Controls.Add(this.RGBColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.label1);
            this.Name = "RGB";
            this.Size = new System.Drawing.Size(234, 117);
            ((System.ComponentModel.ISupportInitialize)(this.RGBColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RGBTextBox Red;
        private RGBTextBox Green;
        private RGBTextBox Blue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox RGBColor;
        private System.Windows.Forms.RadioButton Dec;
        private System.Windows.Forms.RadioButton Hex;
    }
}
