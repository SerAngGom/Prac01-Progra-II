using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(numericUpDown1.Text);
            decimal coste;
            if (n < 200) coste = n * 4.50m;
            else if (n >= 200 && n <= 500) coste = n * 3.75m;
            else coste = n * 3.25m;
            coste.ToString("c");
            precio.Text = coste.ToString("c");
        }
    }
}
