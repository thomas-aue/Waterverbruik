using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Waterverbruik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxVerbruik.Text, "  ^ [0-9]"))
            {
                textBoxVerbruik.Text = "";
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && textBoxVerbruik.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "0")
            {
                labelUitleg.Text = "Meest voordelig";
            }
            if (comboBox1.Text == "1")
            {
                labelUitleg.Text = "€100 + €0.25 per m3";
            }
            if (comboBox1.Text == "2")
            {
                labelUitleg.Text = "€75 + €0.38 per m3";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double verbruik = double.Parse(textBoxVerbruik.Text);
            double tarief1 = 100 + (0.25 * verbruik);
            double tarief2 = 75 + (0.38 * verbruik);

            if (comboBox1.Text == "")
            {
                comboBox1.Text = "0";
            }

            if (comboBox1.Text == "0")
            {
                double tarief0 = Math.Min(tarief1, tarief2);
                textBoxTotaal.Text = tarief0.ToString();
            }
            if (comboBox1.Text == "1")
            {
                textBoxTotaal.Text = tarief1.ToString();
            }
            if (comboBox1.Text == "2")
            {
                textBoxTotaal.Text = tarief2.ToString();
            }
        }
    }
}