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
    public partial class TelaOpcoes : Form
    {
        public TelaOpcoes()
        {
            InitializeComponent();
        }

        private void TelaOpcoes_Load(object sender, EventArgs e)
        {

        }

        private void BotaoXSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
