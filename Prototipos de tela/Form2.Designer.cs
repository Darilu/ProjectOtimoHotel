
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
            this.TelaRegistroDeReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaConsultaDeReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaDeExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaHospedes = new System.Windows.Forms.ToolStripMenuItem();
            this.TelaSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLogoff = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TelaReservas,
            this.TelaFuncionarios,
            this.TelaHospedes,
            this.TelaSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(164, 608);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // TelaReservas
            // 
            this.TelaReservas.AutoToolTip = true;
            this.TelaReservas.BackColor = System.Drawing.Color.Transparent;
            this.TelaReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TelaReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TelaRegistroDeReservas,
            this.TelaConsultaDeReservas,
            this.TelaDeExcluir});
            this.TelaReservas.ForeColor = System.Drawing.Color.Black;
            this.TelaReservas.Image = ((System.Drawing.Image)(resources.GetObject("TelaReservas.Image")));
            this.TelaReservas.Name = "TelaReservas";
            this.TelaReservas.Padding = new System.Windows.Forms.Padding(20, 20, 15, 20);
            this.TelaReservas.Size = new System.Drawing.Size(163, 68);
            this.TelaReservas.Text = "&Reservas";
            this.TelaReservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TelaRegistroDeReservas
            // 
            this.TelaRegistroDeReservas.Name = "TelaRegistroDeReservas";
            this.TelaRegistroDeReservas.Size = new System.Drawing.Size(266, 28);
            this.TelaRegistroDeReservas.Text = "Registrar Reservas";
            // 
            // TelaConsultaDeReservas
            // 
            this.TelaConsultaDeReservas.AutoSize = false;
            this.TelaConsultaDeReservas.Margin = new System.Windows.Forms.Padding(10);
            this.TelaConsultaDeReservas.Name = "TelaConsultaDeReservas";
            this.TelaConsultaDeReservas.Padding = new System.Windows.Forms.Padding(10, 10, 20, 20);
            this.TelaConsultaDeReservas.Size = new System.Drawing.Size(173, 22);
            this.TelaConsultaDeReservas.Text = "Consultar Reservas";
            // 
            // TelaDeExcluir
            // 
            this.TelaDeExcluir.Name = "TelaDeExcluir";
            this.TelaDeExcluir.Size = new System.Drawing.Size(266, 28);
            this.TelaDeExcluir.Text = "Excluir Reservas";
            // 
            // TelaFuncionarios
            // 
            this.TelaFuncionarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TelaFuncionarios.Checked = true;
            this.TelaFuncionarios.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TelaFuncionarios.ForeColor = System.Drawing.Color.Black;
            this.TelaFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("TelaFuncionarios.Image")));
            this.TelaFuncionarios.Name = "TelaFuncionarios";
            this.TelaFuncionarios.Padding = new System.Windows.Forms.Padding(20);
            this.TelaFuncionarios.Size = new System.Drawing.Size(163, 68);
            this.TelaFuncionarios.Text = "&Funcionarios";
            this.TelaFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TelaHospedes
            // 
            this.TelaHospedes.ForeColor = System.Drawing.Color.Black;
            this.TelaHospedes.Image = ((System.Drawing.Image)(resources.GetObject("TelaHospedes.Image")));
            this.TelaHospedes.Name = "TelaHospedes";
            this.TelaHospedes.Padding = new System.Windows.Forms.Padding(20);
            this.TelaHospedes.Size = new System.Drawing.Size(163, 68);
            this.TelaHospedes.Text = "&Hospedes";
            // 
            // TelaSair
            // 
            this.TelaSair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TelaSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSair,
            this.BtnLogoff});
            this.TelaSair.ForeColor = System.Drawing.Color.Black;
            this.TelaSair.Image = ((System.Drawing.Image)(resources.GetObject("TelaSair.Image")));
            this.TelaSair.Name = "TelaSair";
            this.TelaSair.Padding = new System.Windows.Forms.Padding(20);
            this.TelaSair.Size = new System.Drawing.Size(163, 68);
            this.TelaSair.Text = "&Sair";
            // 
            // BtnSair
            // 
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(198, 28);
            this.BtnSair.Text = "Sair";
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnLogoff
            // 
            this.BtnLogoff.Name = "BtnLogoff";
            this.BtnLogoff.Size = new System.Drawing.Size(198, 28);
            this.BtnLogoff.Text = "Fazer Logoff";
            this.BtnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prototipos_de_tela.Properties.Resources.Hotel_bed_room_window_1920x1080;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1151, 608);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.UseWaitCursor = true;
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
        private System.Windows.Forms.ToolStripMenuItem TelaConsultaDeReservas;
        private System.Windows.Forms.ToolStripMenuItem TelaDeExcluir;
    }
}