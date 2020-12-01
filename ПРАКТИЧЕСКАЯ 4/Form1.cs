using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПРАКТИЧЕСКАЯ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form zd = new ВЫБОР_УСЛУГИ();
            zd.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form p = new FormPortfolio();
            p.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cl = new FormClients();
            cl.Show();
            
        }
    }
}
