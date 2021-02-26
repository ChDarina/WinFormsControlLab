using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabControls
{
    public partial class RGBTextBox : TextBox
    {
        public bool IsDecimal = true;
        public RGBTextBox()
        {
            InitializeComponent();
        }

        public RGBTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (Text == "") Text = "0";
            if (Text != "")
            {
                if (IsDecimal)
                {
                    Text = Regex.Replace(Text.ToString(), @"[^\d]", "", RegexOptions.IgnoreCase);
                    if (int.Parse(Text) > 255) Text = 255.ToString();
                    else Text = int.Parse(Text).ToString();
                }
                else
                {
                    Text = Regex.Replace(Text.ToString(), @"([g-z]|[G-Z])", "", RegexOptions.IgnoreCase);
                    Text = Text.ToUpper();
                    if (Text.Length > 2) Text = "FF";
                    Text = Convert.ToString(Convert.ToInt32(Text, 16), 16).ToUpper();
                }
            }
            if (Focus()) SelectionStart = Text.Length;
            base.OnTextChanged(e);
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl((e.KeyChar)) && (IsDecimal))
                e.Handled = true;
            base.OnKeyPress(e);
        }

    }
}
