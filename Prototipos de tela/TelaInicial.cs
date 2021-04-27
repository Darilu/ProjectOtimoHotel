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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
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



        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            //aaaaaaaaaaaaaaaaaaa
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("HH:mm:ss");//Horario

            this.label2.Text = DateTime.Now.ToString("d");//Data
        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<TelaFuncionarios>().Count() > 0)
            {
                Application.OpenForms["TelaFuncionarios"].BringToFront();
                Application.OpenForms["TelaFuncionarios"].Close();
            }
            else
            {
                TelaFuncionarios frmForm1 = new TelaFuncionarios();
                frmForm1.Show();
            }
        }

        private void BtnRelatorios_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<TelaRelatorios>().Count() > 0)//Faz com que a aplicacao permita apenas uma janela de cada botao.
            {
                Application.OpenForms["TelaRelatorios"].BringToFront();
                Application.OpenForms["TelaRelatorios"].Close();
            }
            else
            {
                TelaRelatorios TelaRelatorios1vez = new TelaRelatorios();
                TelaRelatorios1vez.Show();
            }
        }

        private void TelaHospedes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TelaHospedes>().Count() > 0)
            {
                Application.OpenForms["TelaHospedes"].BringToFront();
                Application.OpenForms["TelaHospedes"].Close();
            }
            else
            {
                TelaHospedes TelaHospedes1vez = new TelaHospedes();
                TelaHospedes1vez.Show();
            }

        }

        private void BtnQuartos_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.OfType<TelaQuartos>().Count() > 0)
            {
                Application.OpenForms["TelaQuartos"].BringToFront();
                Application.OpenForms["TelaQuartos"].Close();
            }
            else
            {
                TelaQuartos TelaQuartos1vez = new TelaQuartos();
                TelaQuartos1vez.Show();
            }

        }

        private void BtnReservas_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TelaReservas>().Count() > 0)
            {
                Application.OpenForms["TelaReservas"].BringToFront();
                Application.OpenForms["TelaReservas"].Close();
            }
            else
            {
                TelaReservas TelaReservas1vez = new TelaReservas();
                TelaReservas1vez.Show();
            }

        }

        private void BtnOpcoes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TelaOpcoes>().Count() > 0)//Faz com que a aplicacao permita apenas uma janela de cada botao.
            {
                Application.OpenForms["TelaOpcoes"].BringToFront();
                Application.OpenForms["TelaOpcoes"].Close();
            }
            else
            {
                TelaOpcoes TelaOpcoes1vez = new TelaOpcoes();
                TelaOpcoes1vez.Show();
            }
        }
    }




}
