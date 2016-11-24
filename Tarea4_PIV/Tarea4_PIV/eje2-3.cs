using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_PIV
{
    public partial class eje2_3 : Form
    {
        public eje2_3()
        {
            InitializeComponent();
            caja.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isNullOrEmpty = (caja.Image == null);

            if (isNullOrEmpty == true)
            {
                caja.Image = Image.FromFile("paisajirri.jpg");
            }
            else
            {
                MessageBox.Show("La foto ya esta colocada.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isNullOrEmpty = (caja.Image == null);

            if (isNullOrEmpty == false)
            {
                caja.Image = null;
            }
            else
            {
                MessageBox.Show("La foto ya esta eliminada");
            }
        }

        private void caja_Click(object sender, EventArgs e)
        {

        }
    }
}
