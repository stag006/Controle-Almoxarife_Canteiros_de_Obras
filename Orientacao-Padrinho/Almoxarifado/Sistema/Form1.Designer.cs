namespace Sistema
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaFerramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoFerramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçãoFerramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioExpecificoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_funcionario = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.obraToolStripMenuItem,
            this.ferramentaToolStripMenuItem,
            this.insumosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obraToolStripMenuItem.Text = "Obra";
            // 
            // ferramentaToolStripMenuItem
            // 
            this.ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            this.ferramentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ferramentaToolStripMenuItem.Text = "Ferramenta";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferenciaFerramentaToolStripMenuItem,
            this.devoluçãoFerramentasToolStripMenuItem,
            this.solicitaçãoFerramentasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // transferenciaFerramentaToolStripMenuItem
            // 
            this.transferenciaFerramentaToolStripMenuItem.Name = "transferenciaFerramentaToolStripMenuItem";
            this.transferenciaFerramentaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.transferenciaFerramentaToolStripMenuItem.Text = "Transferencia Ferramenta";
            // 
            // devoluçãoFerramentasToolStripMenuItem
            // 
            this.devoluçãoFerramentasToolStripMenuItem.Name = "devoluçãoFerramentasToolStripMenuItem";
            this.devoluçãoFerramentasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.devoluçãoFerramentasToolStripMenuItem.Text = "Devolução ferramentas";
            this.devoluçãoFerramentasToolStripMenuItem.Click += new System.EventHandler(this.devoluçãoFerramentasToolStripMenuItem_Click);
            // 
            // solicitaçãoFerramentasToolStripMenuItem
            // 
            this.solicitaçãoFerramentasToolStripMenuItem.Name = "solicitaçãoFerramentasToolStripMenuItem";
            this.solicitaçãoFerramentasToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.solicitaçãoFerramentasToolStripMenuItem.Text = "Solicitação Ferramentas";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioGeralToolStripMenuItem,
            this.relatórioExpecificoToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioGeralToolStripMenuItem
            // 
            this.relatórioGeralToolStripMenuItem.Name = "relatórioGeralToolStripMenuItem";
            this.relatórioGeralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioGeralToolStripMenuItem.Text = "Relatório Geral";
            // 
            // relatórioExpecificoToolStripMenuItem
            // 
            this.relatórioExpecificoToolStripMenuItem.Name = "relatórioExpecificoToolStripMenuItem";
            this.relatórioExpecificoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.relatórioExpecificoToolStripMenuItem.Text = "Relatório Expecifico";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btn_cad_funcionario
            // 
            this.btn_cad_funcionario.BackColor = System.Drawing.Color.White;
            this.btn_cad_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cad_funcionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_funcionario.ForeColor = System.Drawing.Color.Black;
            this.btn_cad_funcionario.Location = new System.Drawing.Point(12, 200);
            this.btn_cad_funcionario.Name = "btn_cad_funcionario";
            this.btn_cad_funcionario.Size = new System.Drawing.Size(91, 74);
            this.btn_cad_funcionario.TabIndex = 2;
            this.btn_cad_funcionario.Text = "Cadastrar Funcionário";
            this.btn_cad_funcionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_funcionario.UseVisualStyleBackColor = false;
            this.btn_cad_funcionario.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(533, 286);
            this.Controls.Add(this.btn_cad_funcionario);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaFerramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoFerramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitaçãoFerramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioExpecificoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.Button btn_cad_funcionario;
    }
}

