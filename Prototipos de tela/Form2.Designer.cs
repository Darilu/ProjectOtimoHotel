
namespace Prototipos_de_tela
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TelaReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConsultaDeReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRegistroDeReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExcluirReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaHospedes = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TelaReservas,
            this.TelaHospedes,
            this.TelaFuncionarios,
            this.TelaSair,
            this.BtnOpcoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(187, 639);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // TelaReservas
            // 
            this.TelaReservas.AutoToolTip = true;
            this.TelaReservas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TelaReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TelaReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConsultaDeReservas,
            this.BtnRegistroDeReservas,
            this.BtnExcluirReservas});
            this.TelaReservas.ForeColor = System.Drawing.Color.Black;
            this.TelaReservas.Image = ((System.Drawing.Image)(resources.GetObject("TelaReservas.Image")));
            this.TelaReservas.Name = "TelaReservas";
            this.TelaReservas.Padding = new System.Windows.Forms.Padding(20, 20, 15, 20);
            this.TelaReservas.Size = new System.Drawing.Size(186, 68);
            this.TelaReservas.Text = "&Reservas";
            this.TelaReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TelaReservas.Click += new System.EventHandler(this.TelaReservas_Click);
            this.TelaReservas.MouseEnter += new System.EventHandler(this.TelaReservas_MouseEnter);
            this.TelaReservas.MouseLeave += new System.EventHandler(this.TelaReservas_MouseLeave);
            // 
            // BtnConsultaDeReservas
            // 
            this.BtnConsultaDeReservas.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultaDeReservas.Image")));
            this.BtnConsultaDeReservas.Name = "BtnConsultaDeReservas";
            this.BtnConsultaDeReservas.Size = new System.Drawing.Size(270, 28);
            this.BtnConsultaDeReservas.Text = "Consultar Reservas";
            // 
            // BtnRegistroDeReservas
            // 
            this.BtnRegistroDeReservas.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistroDeReservas.Image")));
            this.BtnRegistroDeReservas.Name = "BtnRegistroDeReservas";
            this.BtnRegistroDeReservas.Size = new System.Drawing.Size(270, 28);
            this.BtnRegistroDeReservas.Text = "Registrar Reservas";
            // 
            // BtnExcluirReservas
            // 
            this.BtnExcluirReservas.Image = ((System.Drawing.Image)(resources.GetObject("BtnExcluirReservas.Image")));
            this.BtnExcluirReservas.Name = "BtnExcluirReservas";
            this.BtnExcluirReservas.Size = new System.Drawing.Size(270, 28);
            this.BtnExcluirReservas.Text = "Excluir Reservas";
            // 
            // TelaHospedes
            // 
            this.TelaHospedes.ForeColor = System.Drawing.Color.Black;
            this.TelaHospedes.Image = ((System.Drawing.Image)(resources.GetObject("TelaHospedes.Image")));
            this.TelaHospedes.Name = "TelaHospedes";
            this.TelaHospedes.Padding = new System.Windows.Forms.Padding(20);
            this.TelaHospedes.Size = new System.Drawing.Size(186, 68);
            this.TelaHospedes.Text = "&Hospedes";
            // 
            // TelaFuncionarios
            // 
            this.TelaFuncionarios.AutoSize = false;
            this.TelaFuncionarios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TelaFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TelaFuncionarios.Checked = true;
            this.TelaFuncionarios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TelaFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.TelaFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("TelaFuncionarios.Image")));
            this.TelaFuncionarios.Name = "TelaFuncionarios";
            this.TelaFuncionarios.Padding = new System.Windows.Forms.Padding(20);
            this.TelaFuncionarios.Size = new System.Drawing.Size(190, 68);
            this.TelaFuncionarios.Text = "&Funcionarios";
            this.TelaFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TelaSair
            // 
            this.TelaSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TelaSair.AutoSize = false;
            this.TelaSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSair,
            this.BtnLogoff});
            this.TelaSair.ForeColor = System.Drawing.Color.Black;
            this.TelaSair.Image = ((System.Drawing.Image)(resources.GetObject("TelaSair.Image")));
            this.TelaSair.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.TelaSair.Name = "TelaSair";
            this.TelaSair.Padding = new System.Windows.Forms.Padding(20);
            this.TelaSair.Size = new System.Drawing.Size(183, 68);
            this.TelaSair.Text = "&Sair";
            // 
            // BtnSair
            // 
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(202, 28);
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLogoff
            // 
            this.BtnLogoff.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogoff.Image")));
            this.BtnLogoff.Name = "BtnLogoff";
            this.BtnLogoff.Size = new System.Drawing.Size(202, 28);
            this.BtnLogoff.Text = "Fazer Logoff";
            this.BtnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // BtnOpcoes
            // 
            this.BtnOpcoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnOpcoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnOpcoes.Checked = true;
            this.BtnOpcoes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BtnOpcoes.ForeColor = System.Drawing.Color.Black;
            this.BtnOpcoes.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpcoes.Image")));
            this.BtnOpcoes.Name = "BtnOpcoes";
            this.BtnOpcoes.Padding = new System.Windows.Forms.Padding(20);
            this.BtnOpcoes.Size = new System.Drawing.Size(186, 68);
            this.BtnOpcoes.Text = "Opções";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototipos_de_tela.Properties.Resources.Hotel_bed_room_window_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 639);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TelaReservas;
        private System.Windows.Forms.ToolStripMenuItem Tela;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem BtnSair;
        private System.Windows.Forms.ToolStripMenuItem BtnLogoff;
        private System.Windows.Forms.ToolStripMenuItem TelaFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem TelaOpcoes1;
        private System.Windows.Forms.ToolStripMenuItem TelaSair;
        private System.Windows.Forms.ToolStripMenuItem TelaHospedes;
        private System.Windows.Forms.ToolStripMenuItem TelaRegistroDeReservas;
        private System.Windows.Forms.ToolStripMenuItem TelaDeExcluir;
        private System.Windows.Forms.ToolStripMenuItem TelaConsultaDeReservas;
        private System.Windows.Forms.ToolStripMenuItem BtnConsultaDeReservas;
        private System.Windows.Forms.ToolStripMenuItem BtnRegistroDeReservas;
        private System.Windows.Forms.ToolStripMenuItem BtnExcluirReservas;
        private System.Windows.Forms.ToolStripMenuItem BtnOpcoes;
    }
}