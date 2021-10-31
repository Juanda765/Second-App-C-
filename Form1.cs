using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EstudiantesCalif1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter(@"C:\Users\ana\Desktop\Recursos App Taxco\EstudiantesCalif1\archivo.txt",true);
            try 
            {
                escribir.WriteLine("Nombre: "+textBox1.Text);
                escribir.WriteLine("Calificaciones: " + textBox2.Text);
                escribir.WriteLine("\n");
            }
            catch 
            {
                MessageBox.Show("Error");
            }
            escribir.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader leer = new StreamReader(@"C:\Users\ana\Desktop\Recursos App Taxco\EstudiantesCalif1\archivo.txt");
            string linea;
            try 
            {
                linea = leer.ReadLine();
                while (linea != null)
                {
                    richTextBox1.AppendText(linea + "\n");
                    linea = leer.ReadLine();
                }
            }

            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
