
namespace Prototipos_de_tela
{
    partial class TelaFuncionarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.BotaoXSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(562, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "TELA DE FUNCIONARIOS 1660x1080";
            // 
            // BotaoXSair
            // 
            this.BotaoXSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoXSair.AutoSize = true;
            this.BotaoXSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoXSair.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotaoXSair.Location = new System.Drawing.Point(1629, -1);
            this.BotaoXSair.Name = "BotaoXSair";
            this.BotaoXSair.Size = new System.Drawing.Size(30, 36);
            this.BotaoXSair.TabIndex = 1;
            this.BotaoXSair.Text = "x";
            this.BotaoXSair.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BotaoXSair.Click += new System.EventHandler(this.BotaoXSair_Click);
            // 
            // TelaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1660, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.BotaoXSair);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(260, 0);
            this.Name = "TelaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BotaoXSair;
    }
}