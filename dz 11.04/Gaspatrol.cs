using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dz_11_04
{
    public partial class Gaspatrol : Form
    {
        public Gaspatrol()
        {
            InitializeComponent();

            benz.Items.Add("Diesel");
            benz.Items.Add("Benzin");
            benz.Items.Add("Gas");
            benz.SelectedItem = null;
        }

        public double sum_petrol = 0;

        private void benz_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = benz.SelectedItem;
            string op = obj.ToString();
            switch (op)
            {
                case "Diesel":
                    textBox1.Text = "1,59";
                    break;

                case "Benzin":
                    textBox1.Text = "1,49";
                    break;

                case "Gas":
                    textBox1.Text = "0,99";
                    break;
            }
            sum_petrol = Convert.ToDouble(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double result_petrol = 0;
                if (textBox2.Text.Length > 0)
                {
                    result_petrol = sum_petrol * Convert.ToDouble(textBox2.Text);
                }
                else
                {
                    result_petrol = 0;
                }
                textBox4.Text = result_petrol.ToString();
            }
            else if (!radioButton1.Checked)
            {
                textBox4.Text = null;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked && textBox3.Text.Length > 0)
            {
                textBox4.Text = textBox3.Text;
            }
            else
            {
                textBox4.Text = Convert.ToString(0);
            }
        }


    }
}