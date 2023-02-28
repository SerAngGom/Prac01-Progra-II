using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semáforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void permitirCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cambiaFaseB_Click(object sender, EventArgs e)
        {
            if (permitirCB.Checked)
            {
                if (rojoPB.BackColor == Color.Red)
                {
                    rojoPB.BackColor = Color.Black;
                    amarilloPB.BackColor = Color.Yellow;
                }
                else if (amarilloPB.BackColor==Color.Yellow)
                {
                    amarilloPB.BackColor = Color.Black;
                    verdePB.BackColor = Color.Green;
                }
                else
                {
                    verdePB.BackColor = Color.Black;
                    rojoPB.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("No se puede cambiar de fase hasta que no lo habilites.");
            }
        }
    }
}
