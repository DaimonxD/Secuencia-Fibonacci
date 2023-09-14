using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secuencia_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (int.TryParse(textBox1.Text, out int limite) && limite >= 0)
            {
                int a = 0;
                int temp = 0;
                int i = 0;
                int b = 1;

                while (a <= limite)
                {
                    listBox1.Items.Add(a);
                    temp = a;
                    a = b;
                    b = temp + a;
                    i++;
                }
                if (limite == temp)
                {
                    MessageBox.Show("Se hicieron un total de " + i + " iteraciones y el número si existe en la secuencia", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se hicieron un total de " + i + " iteraciones y el número no existe en la secuencia, el número más cercano es " + temp, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("ingresa un numero entero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
