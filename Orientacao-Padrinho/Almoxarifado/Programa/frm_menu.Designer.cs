namespace Programa
{
    partial class frm_menu
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
            this.insumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaFerramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçãoFerrmanetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitaçãoFerramentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioExpecificoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cad_funcionario = new System.Windows.Forms.Button();
            this.btn_cad_Obra = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionárioToolStripMenuItem,
            this.obraToolStripMenuItem,
            this.ferramentaToolStripMenuItem,
            this.insumoToolStripMenuItem,
            this.materiaisToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionárioToolStripMenuItem
            // 
            this.funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            this.funcionárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionárioToolStripMenuItem.Text = "Funcionários";
            this.funcionárioToolStripMenuItem.Click += new System.EventHandler(this.funcionárioToolStripMenuItem_Click);
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.obraToolStripMenuItem.Text = "Obras";
            this.obraToolStripMenuItem.Click += new System.EventHandler(this.obraToolStripMenuItem_Click);
            // 
            // ferramentaToolStripMenuItem
            // 
            this.ferramentaToolStripMenuItem.Name = "ferramentaToolStripMenuItem";
            this.ferramentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ferramentaToolStripMenuItem.Text = "Ferramentas";
            this.ferramentaToolStripMenuItem.Click += new System.EventHandler(this.ferramentaToolStripMenuItem_Click);
            // 
            // insumoToolStripMenuItem
            // 
            this.insumoToolStripMenuItem.Name = "insumoToolStripMenuItem";
            this.insumoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insumoToolStripMenuItem.Text = "Insumos";
            this.insumoToolStripMenuItem.Click += new System.EventHandler(this.insumoToolStripMenuItem_Click);
            // 
            // materiaisToolStripMenuItem
            // 
            this.materiaisToolStripMenuItem.Name = "materiaisToolStripMenuItem";
            this.materiaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiaisToolStripMenuItem.Text = "Materiais";
            this.materiaisToolStripMenuItem.Click += new System.EventHandler(this.materiaisToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferênciaFerramentaToolStripMenuItem,
            this.devoluçãoFerrmanetaToolStripMenuItem,
            this.solicitaçãoFerramentaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // transferênciaFerramentaToolStripMenuItem
            // 
            this.transferênciaFerramentaToolStripMenuItem.Name = "transferênciaFerramentaToolStripMenuItem";
            this.transferênciaFerramentaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.transferênciaFerramentaToolStripMenuItem.Text = "Transferência Ferramenta";
            // 
            // devoluçãoFerrmanetaToolStripMenuItem
            // 
            this.devoluçãoFerrmanetaToolStripMenuItem.Name = "devoluçãoFerrmanetaToolStripMenuItem";
            this.devoluçãoFerrmanetaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.devoluçãoFerrmanetaToolStripMenuItem.Text = "Devolução Ferrmaneta";
            // 
            // solicitaçãoFerramentaToolStripMenuItem
            // 
            this.solicitaçãoFerramentaToolStripMenuItem.Name = "solicitaçãoFerramentaToolStripMenuItem";
            this.solicitaçãoFerramentaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.solicitaçãoFerramentaToolStripMenuItem.Text = "Solicitação Ferramenta";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioGeralToolStripMenuItem,
            this.relatórioExpecificoToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // relatórioGeralToolStripMenuItem
            // 
            this.relatórioGeralToolStripMenuItem.Name = "relatórioGeralToolStripMenuItem";
            this.relatórioGeralToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.relatórioGeralToolStripMenuItem.Text = "Relatório Geral";
            // 
            // relatórioExpecificoToolStripMenuItem
            // 
            this.relatórioExpecificoToolStripMenuItem.Name = "relatórioExpecificoToolStripMenuItem";
            this.relatórioExpecificoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
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
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btn_cad_funcionario
            // 
            this.btn_cad_funcionario.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_funcionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_funcionario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_funcionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_funcionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_funcionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_funcionario.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_funcionario.Image = global::Programa.Properties.Resources.trabalhador_2;
            this.btn_cad_funcionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_funcionario.Location = new System.Drawing.Point(12, 41);
            this.btn_cad_funcionario.Name = "btn_cad_funcionario";
            this.btn_cad_funcionario.Size = new System.Drawing.Size(85, 80);
            this.btn_cad_funcionario.TabIndex = 1;
            this.btn_cad_funcionario.Text = "Cadastrar Funcionário";
            this.btn_cad_funcionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_funcionario.UseVisualStyleBackColor = false;
            this.btn_cad_funcionario.Click += new System.EventHandler(this.btn_cad_funcionario_Click_1);
            // 
            // btn_cad_Obra
            // 
            this.btn_cad_Obra.BackColor = System.Drawing.Color.Transparent;
            this.btn_cad_Obra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cad_Obra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_Obra.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cad_Obra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_cad_Obra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cad_Obra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_Obra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cad_Obra.ForeColor = System.Drawing.Color.Transparent;
            this.btn_cad_Obra.Image = global::Programa.Properties.Resources.trabalhador_2;
            this.btn_cad_Obra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_Obra.Location = new System.Drawing.Point(113, 41);
            this.btn_cad_Obra.Name = "btn_cad_Obra";
            this.btn_cad_Obra.Size = new System.Drawing.Size(85, 80);
            this.btn_cad_Obra.TabIndex = 2;
            this.btn_cad_Obra.Text = "Cadastrar Obra";
            this.btn_cad_Obra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_Obra.UseVisualStyleBackColor = false;
            this.btn_cad_Obra.Click += new System.EventHandler(this.btn_cad_Obra_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Programa.Properties.Resources.OAllpaper0031;
            this.ClientSize = new System.Drawing.Size(570, 325);
            this.Controls.Add(this.btn_cad_Obra);
            this.Controls.Add(this.btn_cad_funcionario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btn_cad_funcionario;
        private System.Windows.Forms.Button btn_cad_Obra;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciaFerramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devoluçãoFerrmanetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitaçãoFerramentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioExpecificoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

