using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        private string rutaArchivoActual = "";
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    rutaArchivoActual = openFileDialog1.FileName;
                    textBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo" + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
           if (!string.IsNullOrEmpty(rutaArchivoActual))
            {
                System.IO.File.WriteAllText(rutaArchivoActual, textBox1.Text);
                MessageBox.Show("Archivo guardado correctamente");
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoActual = saveFileDialog1.FileName;
                    System.IO.File.WriteAllText(rutaArchivoActual, textBox1.Text);
                    MessageBox.Show("Archivo guardado correctamente");
                }
            }
        }
                catch (Exception ex)
                {
                MessageBox.Show("Error al guardar el archivo" + ex.Message);
            }
        }

}
            }
    

