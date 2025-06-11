using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            timer1.Interval = 100;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (barraProgreso.Value < 100)
                barraProgreso.Value += 1;
            else
                timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barraProgreso.Value = 0;
            timer1.Start();
        }

        private void barraProgreso_Click(object sender, EventArgs e)
        {
        }
           

        private void button2_Click(object sender, EventArgs e)

        {
            timer1.Stop();
        }
    }
    }
