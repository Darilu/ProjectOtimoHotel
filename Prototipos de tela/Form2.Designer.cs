
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TelaReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnConsultaDeReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRegistroDeReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExcluirReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaHospedes = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLogoff = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TelaReservas,
            this.TelaHospedes,
            this.TelaSair,
            this.BtnRelatorios,
            this.BtnOpcoes,
            this.BtnFuncionarios});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // TelaReservas
            // 
            resources.ApplyResources(this.TelaReservas, "TelaReservas");
            this.TelaReservas.AutoToolTip = true;
            this.TelaReservas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TelaReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnConsultaDeReservas,
            this.BtnRegistroDeReservas,
            this.BtnExcluirReservas});
            this.TelaReservas.ForeColor = System.Drawing.Color.Black;
            this.TelaReservas.Name = "TelaReservas";
            this.TelaReservas.Padding = new System.Windows.Forms.Padding(20);
            this.TelaReservas.Click += new System.EventHandler(this.TelaReservas_Click);
            // 
            // BtnConsultaDeReservas
            // 
            resources.ApplyResources(this.BtnConsultaDeReservas, "BtnConsultaDeReservas");
            this.BtnConsultaDeReservas.Name = "BtnConsultaDeReservas";
            // 
            // BtnRegistroDeReservas
            // 
            resources.ApplyResources(this.BtnRegistroDeReservas, "BtnRegistroDeReservas");
            this.BtnRegistroDeReservas.Name = "BtnRegistroDeReservas";
            // 
            // BtnExcluirReservas
            // 
            resources.ApplyResources(this.BtnExcluirReservas, "BtnExcluirReservas");
            this.BtnExcluirReservas.Name = "BtnExcluirReservas";
            // 
            // TelaHospedes
            // 
            resources.ApplyResources(this.TelaHospedes, "TelaHospedes");
            this.TelaHospedes.ForeColor = System.Drawing.Color.Black;
            this.TelaHospedes.Name = "TelaHospedes";
            this.TelaHospedes.Padding = new System.Windows.Forms.Padding(20);
            // 
            // TelaSair
            // 
            this.TelaSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TelaSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSair,
            this.BtnLogoff});
            this.TelaSair.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.TelaSair, "TelaSair");
            this.TelaSair.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.TelaSair.Name = "TelaSair";
            this.TelaSair.Padding = new System.Windows.Forms.Padding(20);
            // 
            // BtnSair
            // 
            resources.ApplyResources(this.BtnSair, "BtnSair");
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLogoff
            // 
            resources.ApplyResources(this.BtnLogoff, "BtnLogoff");
            this.BtnLogoff.Name = "BtnLogoff";
            this.BtnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // BtnRelatorios
            // 
            resources.ApplyResources(this.BtnRelatorios, "BtnRelatorios");
            this.BtnRelatorios.ForeColor = System.Drawing.Color.Black;
            this.BtnRelatorios.Name = "BtnRelatorios";
            this.BtnRelatorios.Padding = new System.Windows.Forms.Padding(20);
            // 
            // BtnOpcoes
            // 
            this.BtnOpcoes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.BtnOpcoes, "BtnOpcoes");
            this.BtnOpcoes.Checked = true;
            this.BtnOpcoes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BtnOpcoes.ForeColor = System.Drawing.Color.Black;
            this.BtnOpcoes.Name = "BtnOpcoes";
            this.BtnOpcoes.Padding = new System.Windows.Forms.Padding(20);
            // 
            // BtnFuncionarios
            // 
            resources.ApplyResources(this.BtnFuncionarios, "BtnFuncionarios");
            this.BtnFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Padding = new System.Windows.Forms.Padding(25, 20, 20, 20);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TelaReservas;
        private System.Windows.Forms.ToolStripMenuItem Tela;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem BtnSair;
        private System.Windows.Forms.ToolStripMenuItem BtnLogoff;
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
        private System.Windows.Forms.ToolStripMenuItem BtnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem BtnFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}