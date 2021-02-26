using System;
using System.Drawing;
using System.Windows.Forms;

namespace LabControls
{
    public partial class RGB : UserControl
    {
        public RGB()
        {
            InitializeComponent();
        }
        private void RGBTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Dec.Checked)
                {
                    RGBColor.BackColor = Color.FromArgb(
                        int.Parse(Red.Text),
                        int.Parse(Green.Text),
                        int.Parse(Blue.Text)
                    );
                }
                else
                {
                    RGBColor.BackColor = Color.FromArgb(
                        Convert.ToInt32(Red.Text, 16),
                        Convert.ToInt32(Green.Text, 16),
                        Convert.ToInt32(Blue.Text, 16)
                    );
                }
            }
            catch (Exception) { }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Dec.Enabled = !Dec.Checked;
            Hex.Enabled = !Hex.Checked;
            Red.IsDecimal = Dec.Checked;
            Green.IsDecimal = Dec.Checked;
            Blue.IsDecimal = Dec.Checked;
            if (Dec.Checked)
            {
                Red.Text = Red.Text != "" ? Convert.ToInt32(Red.Text, 16).ToString() : "";
                Green.Text = Green.Text != "" ? Convert.ToInt32(Green.Text, 16).ToString() : "";
                Blue.Text = Blue.Text != "" ? Convert.ToInt32(Blue.Text, 16).ToString() : "";
            }
            else
            {
                Red.Text = Red.Text != "" ? Convert.ToString(int.Parse(Red.Text), 16) : "";
                Green.Text = Green.Text != "" ? Convert.ToString(int.Parse(Green.Text), 16) : "";
                Blue.Text = Blue.Text != "" ? Convert.ToString(int.Parse(Blue.Text), 16) : "";
            }
        }
    }
}
