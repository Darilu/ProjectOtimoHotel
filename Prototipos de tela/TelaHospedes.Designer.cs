﻿
namespace Prototipos_de_tela
{
    partial class TelaHospedes
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
            this.BotaoXSair = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoXSair
            // 
            this.BotaoXSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotaoXSair.AutoSize = true;
            this.BotaoXSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoXSair.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BotaoXSair.Location = new System.Drawing.Point(1629, 0);
            this.BotaoXSair.Name = "BotaoXSair";
            this.BotaoXSair.Size = new System.Drawing.Size(30, 36);
            this.BotaoXSair.TabIndex = 2;
            this.BotaoXSair.Text = "x";
            this.BotaoXSair.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(663, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tela Hospedes";
            // 
            // TelaHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1660, 1080);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoXSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(260, 0);
            this.Name = "TelaHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaHospedes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BotaoXSair;
        private System.Windows.Forms.Label label1;
    }
}