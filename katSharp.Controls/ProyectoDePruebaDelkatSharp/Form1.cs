using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using katSharp;

namespace ProyectoDePruebaDelkatSharp
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

        private void button1_Click(object sender, EventArgs e)
        {
            string mostrar = Convert.ToString(katnumberBox1.INT32()+katnumberBox1.INT32());
            MessageBox.Show(mostrar);
        }

        private void katnumberBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void katnumberBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
