using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class MaxMinTextBox : TextBox
    {
        public bool Min { get; set; }
        public float Value { get; set; }

        public float minv=0;
        public float maxv=9999999;
        public MaxMinTextBox()
        {
            InitializeComponent();
        }

        public MaxMinTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void OnTextChanged(EventArgs e)
        {
            if (this.Text.Length == 0)
            {
                if (Min) Text = "От";
                else Text = "До";
            }
            else if (Text.Length > 2|| Text.Length >= 2&&(char.IsDigit(Text[0])|| char.IsDigit(Text[1])))
            {
                string s = Text;
                string after = new string(s.Where(r => char.IsDigit(r)).ToArray());
                Text = after;
            }

                
                else if (Text == "От") { Value = minv; }
                else if (Text == "До") { Value = maxv;  }

                    double x = 0;
                    if (!double.TryParse(Text, out x))
                    {
                        ForeColor = Color.Red;
                        if (Min) Value = minv;
                        else Value = maxv;
                    }
                    else
                    {
                        ForeColor = Color.Black;
                        Value = (float)x;
                    }


            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
            base.OnKeyPress(e);
        }

    }
}
