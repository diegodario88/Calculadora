namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarArquivo = new System.Windows.Forms.OpenFileDialog();
            this.lblNotas = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNota2 = new System.Windows.Forms.MaskedTextBox();
            this.txtNota3 = new System.Windows.Forms.MaskedTextBox();
            this.txtNota4 = new System.Windows.Forms.MaskedTextBox();
            this.lbl1Bimestre = new System.Windows.Forms.Label();
            this.lbl2Bimestre = new System.Windows.Forms.Label();
            this.lbl3Bimestre = new System.Windows.Forms.Label();
            this.lbl4Bimestre = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnResultado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            resources.ApplyResources(this.arquivoToolStripMenuItem, "arquivoToolStripMenuItem");
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            resources.ApplyResources(this.abrirToolStripMenuItem, "abrirToolStripMenuItem");
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            resources.ApplyResources(this.salvarToolStripMenuItem, "salvarToolStripMenuItem");
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            resources.ApplyResources(this.sairToolStripMenuItem, "sairToolStripMenuItem");
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            resources.ApplyResources(this.exibirToolStripMenuItem, "exibirToolStripMenuItem");
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            resources.ApplyResources(this.listaToolStripMenuItem, "listaToolStripMenuItem");
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            resources.ApplyResources(this.ferramentasToolStripMenuItem, "ferramentasToolStripMenuItem");
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            resources.ApplyResources(this.ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            // 
            // sobreToolStripMenuItem
            // 
            resources.ApplyResources(this.sobreToolStripMenuItem, "sobreToolStripMenuItem");
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // selecionarArquivo
            // 
            this.selecionarArquivo.FileName = "selecionar Arquivo";
            resources.ApplyResources(this.selecionarArquivo, "selecionarArquivo");
            // 
            // lblNotas
            // 
            resources.ApplyResources(this.lblNotas, "lblNotas");
            this.lblNotas.Name = "lblNotas";
            // 
            // txtNota1
            // 
            this.txtNota1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtNota1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            resources.ApplyResources(this.txtNota1, "txtNota1");
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNota2
            // 
            this.txtNota2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.txtNota2, "txtNota2");
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNota3
            // 
            this.txtNota3.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.txtNota3, "txtNota3");
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNota4
            // 
            this.txtNota4.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.txtNota4, "txtNota4");
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lbl1Bimestre
            // 
            resources.ApplyResources(this.lbl1Bimestre, "lbl1Bimestre");
            this.lbl1Bimestre.Name = "lbl1Bimestre";
            // 
            // lbl2Bimestre
            // 
            resources.ApplyResources(this.lbl2Bimestre, "lbl2Bimestre");
            this.lbl2Bimestre.Name = "lbl2Bimestre";
            // 
            // lbl3Bimestre
            // 
            resources.ApplyResources(this.lbl3Bimestre, "lbl3Bimestre");
            this.lbl3Bimestre.Name = "lbl3Bimestre";
            // 
            // lbl4Bimestre
            // 
            this.lbl4Bimestre.AutoEllipsis = true;
            resources.ApplyResources(this.lbl4Bimestre, "lbl4Bimestre");
            this.lbl4Bimestre.Name = "lbl4Bimestre";
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            // 
            // lblMedia
            // 
            resources.ApplyResources(this.lblMedia, "lblMedia");
            this.lblMedia.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblMedia.Name = "lblMedia";
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.btnResultado, "btnResultado");
            this.btnResultado.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lbl4Bimestre);
            this.Controls.Add(this.lbl3Bimestre);
            this.Controls.Add(this.lbl2Bimestre);
            this.Controls.Add(this.lbl1Bimestre);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog selecionarArquivo;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.MaskedTextBox txtNota1;
        private System.Windows.Forms.MaskedTextBox txtNota2;
        private System.Windows.Forms.MaskedTextBox txtNota3;
        private System.Windows.Forms.MaskedTextBox txtNota4;
        private System.Windows.Forms.Label lbl1Bimestre;
        private System.Windows.Forms.Label lbl2Bimestre;
        private System.Windows.Forms.Label lbl3Bimestre;
        private System.Windows.Forms.Label lbl4Bimestre;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnResultado;
    }
}

