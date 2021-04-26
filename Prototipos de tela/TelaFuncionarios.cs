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
    public partial class TelaFuncionarios : Form
    {
        public TelaFuncionarios()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            

        }

        

        private void BotaoXSair_Click(object sender, EventArgs e)
        {
            Close();
            TelaInicial TelaInicial;
            TelaInicial = new TelaInicial();
            TelaInicial.Show();

        }
    }
}
