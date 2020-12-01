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
    public partial class FormORDER : Form
    {
        
        public FormORDER()
        {
            InitializeComponent();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Clients cl = new Clients();
                cl.Name = textBox1.Text;
                cl.Surname = textBox2.Text;
                cl.Number = textBox3.Text;
                if (cl.Name == "" || cl.Surname == "" || cl.Number == "")
                {
                    throw new Exception("Не заполнены поля имени, фамилии или номера");
                }
                Program.DP.Clients.Add(cl);
                Program.DP.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormORDER_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
