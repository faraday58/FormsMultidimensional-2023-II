using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsMultidimensional_2023_II
{
    public partial class Form1 : Form
    {

        Multidimensional m1;
        Multidimensional m2;
        Multidimensional m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            m1 = Multidimensional.Leer(txtbDisplay.Text);
            lbMatriz1.Text = m1.ToString();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            m2 = Multidimensional.Leer(txtbDisplay.Text);
            lbMatriz2.Text = m2.ToString();
            m3 = m1 + m2;
            lbResultado.Text = m3.ToString();

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            if(rdbDeg.Checked)
            {
                MessageBox.Show("Estás en Grados Hexadecimales");
            }
            if(rdbRad.Checked)
            {
                MessageBox.Show(Math.Sin(3.1416).ToString());
            }
        }
    }
}
