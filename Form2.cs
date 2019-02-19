using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFEFWFV05221018
{
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
            tbF1Tb.Text =  form1.extraTbNombre();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbF1Tb.Text = form1.extraTbNombre();
        }

        private void btExtDatosTB_Click(object sender, EventArgs e)
        {
            tbF1Tb.Text = form1.extraTbNombre();
        }

        public void updateTb(string str)
        {
            this.tbF1Tb.Text = str;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
