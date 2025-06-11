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

namespace Ejercicio6
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colorseleccionado = comboBox1.SelectedItem.ToString();

            switch (colorseleccionado)
            {
                case "Rojo":
                    this.BackColor = Color.Red; break;

                case "Verde":
                    this.BackColor = Color.Green; break;

                case "Azul":
                    this.BackColor = Color.Blue; break;

            }
        }

        private string GetDebuggerDisplay() => ToString();
    }
}