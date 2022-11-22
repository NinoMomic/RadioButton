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

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRezerviraj_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (radioButtonAvion.Checked) textBox1.AppendText("Odabrali ste prijevoz avionom.");
            if (radioButtonAutobus.Checked) textBox1.AppendText("Odabrali ste prijevoz autobusom.");
            if (radioButtonVlastitiPrijevoz.Checked) textBox1.AppendText("Odabrali ste prijevoz vlastitim vozilom.");

        }
    }
}
