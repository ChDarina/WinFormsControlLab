
namespace TestControlsApplication
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rgb1 = new LabControls.RGB();
            this.filePathSelect1 = new LabControls.FilePathSelect();
            this.numberBox1 = new LabControls.NumberBox(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1 Упражнение: NumberBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2 Упражнение: FilePathSelect";
            // 
            // rgb1
            // 
            this.rgb1.Location = new System.Drawing.Point(12, 69);
            this.rgb1.Name = "rgb1";
            this.rgb1.Size = new System.Drawing.Size(248, 114);
            this.rgb1.TabIndex = 4;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "hello there";
            this.filePathSelect1.Location = new System.Drawing.Point(12, 39);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(221, 24);
            this.filePathSelect1.TabIndex = 2;
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(13, 13);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(100, 20);
            this.numberBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "3 Упражнение: RGB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 185);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rgb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filePathSelect1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabControls.NumberBox numberBox1;
        private System.Windows.Forms.Label label1;
        private LabControls.FilePathSelect filePathSelect1;
        private LabControls.RGB rgb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

