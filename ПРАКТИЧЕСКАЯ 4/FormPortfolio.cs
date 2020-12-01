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
    public partial class FormPortfolio : Form
    {
        public FormPortfolio()
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form cl = new FormClients();
            cl.Show();
            
        }
        int clickeditem = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            if (++clickeditem > 3) clickeditem = 1;
            change();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (--clickeditem <= 0) clickeditem = 3;
            change();
        }
        void change()
        {

            switch (clickeditem)
            {
                case 1:
                    pictureBox3.Image = Properties.Resources.РАБОТА1;
                    break;
                case 2:
                    pictureBox3.Image = Properties.Resources.РАБОТА2;
                    break;
                case 3:
                    pictureBox3.Image = Properties.Resources.РАБОТА3;
                    break;
            }
        }
    }
}
