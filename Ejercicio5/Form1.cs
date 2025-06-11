using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                label1.Text = "Hombre";

            if (radioButton2.Checked == true)
                label1.Text = "Mujer";

            if (radioButton3.Checked == true)
                label1.Text = "Prefiero no decirlo";


        }
        
    }
}
