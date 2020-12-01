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
    public partial class FormClients : Form
    {
        
        public FormClients()
        {
            InitializeComponent();
            ShowClient();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clients cl = listView1.SelectedItems[0].Tag as Clients;
                cl.Status = comboBox1.Text;
                Program.DP.SaveChanges();
                ShowClient();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count == 1)
                {
                    Clients cl = listView1.SelectedItems[0].Tag as Clients;
                    Program.DP.Clients.Remove(cl);
                    Program.DP.SaveChanges();
                    ShowClient();
                }
                comboBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowClient()
        {
            listView1.Items.Clear();
            foreach (Clients cl in Program.DP.Clients)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    cl.Name, cl.Surname,
                    cl.Number, cl.Status
                });
                item.Tag = cl;
                listView1.Items.Add(item);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Clients cl = listView1.SelectedItems[0].Tag as Clients;
                comboBox1.Text = cl.Status;
            }
            else
            {
                comboBox1.Text = "";
            }
        }
    }
}
