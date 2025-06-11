using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double celsius;
            if (double.TryParse(textBox1.Text, out celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                label1.Text = $"{celsius} °C = {fahrenheit:F2} °F";
            }
            else
            {
                label1.Text = "Ingresar un numero valido.";
            }
        }
    }
    }