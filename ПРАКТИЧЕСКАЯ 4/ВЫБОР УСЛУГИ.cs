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
    public partial class ВЫБОР_УСЛУГИ : Form
    {
        public ВЫБОР_УСЛУГИ()
        {
            InitializeComponent();
            ShowVibor();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                ViborUslugi ву = new ViborUslugi();
                ву.Nameusluga = comboBox1.Text;
                if (ву.Nameusluga == "РАЗРАБОТКА ЛЕНДИНГА")
                {
                    ву.Timework = "неделя";
                    ву.Price = "15000р";
                }
                else if (ву.Nameusluga == "УПАКОВКА СООБЩЕСТВА ВК")
                {
                    ву.Timework = "5 дней";
                    ву.Price = "7000р";
                }
                else if (ву.Nameusluga == "РЕКЛАМНЫЙ БАННЕР")
                {
                    ву.Timework = "2 часа";
                    ву.Price = "600р";
                }
                Program.DP.ViborUslugi.Add(ву);
                Program.DP.SaveChanges();
                ShowVibor();
            }
            if (listView1.SelectedItems.Count == 1)
            {
                ViborUslugi vu = listView1.SelectedItems[0].Tag as ViborUslugi;
                vu.Nameusluga = comboBox1.Text;
                if (vu.Nameusluga == "РАЗРАБОТКА ЛЕНДИНГА")
                {
                    vu.Timework = "неделя";
                    vu.Price = "15000р";
                }
                else if (vu.Nameusluga == "УПАКОВКА СООБЩЕСТВА ВК")
                {
                    vu.Timework = "5 дней";
                    vu.Price = "7000р";
                }
                else if (vu.Nameusluga == "РЕКЛАМНЫЙ БАННЕР")
                {
                    vu.Timework = "2 часа";
                    vu.Price = "600р";
                }
                Program.DP.SaveChanges();
                ShowVibor();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form or = new FormORDER();
            or.Show();
            
        }
        void ShowVibor()
        {
            listView1.Items.Clear();
            foreach (ViborUslugi vu in Program.DP.ViborUslugi)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    vu.Nameusluga, vu.Timework,
                    vu.Price
                });
                item.Tag = vu;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ViborUslugi vu = listView1.SelectedItems[0].Tag as ViborUslugi;
                comboBox1.Text = vu.Nameusluga;
            }
            else
            {
                comboBox1.Text = "";
            }
        }
    }
}
