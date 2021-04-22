using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipos_de_tela
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        public void button1_Click_2(object sender, EventArgs e)
        {
            Close();
            Login _f1;
            _f1 = new Login();
            _f1.Show();

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            
            
            
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogoff_Click(object sender, EventArgs e)
        {
            Close();
            Login _f1;
            _f1 = new Login();
            _f1.Show();
        }

        private void TelaReservas_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            //aaaaaaaaaaaaaaaaaaa
        }

        private void TelaReservas_MouseLeave(object sender, EventArgs e)
        {
            TelaReservas.BackColor = Color.WhiteSmoke;
        }

        private void TelaReservas_MouseEnter(object sender, EventArgs e)
        {
            TelaReservas.BackColor = Color.Black;
        }
    }




}
