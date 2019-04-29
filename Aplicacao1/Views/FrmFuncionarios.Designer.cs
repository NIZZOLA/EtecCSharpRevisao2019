namespace Aplicacao1.Views
{
    partial class FrmFuncionarios
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
            this.gridFun = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuIncluir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridFun)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridFun
            // 
            this.gridFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFun.Location = new System.Drawing.Point(12, 27);
            this.gridFun.Name = "gridFun";
            this.gridFun.Size = new System.Drawing.Size(674, 237);
            this.gridFun.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuIncluir,
            this.mnuAbrir,
            this.mnuExcluir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuIncluir
            // 
            this.mnuIncluir.Name = "mnuIncluir";
            this.mnuIncluir.Size = new System.Drawing.Size(52, 20);
            this.mnuIncluir.Text = "Incluir";
            this.mnuIncluir.Click += new System.EventHandler(this.mnuIncluir_Click);
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.Size = new System.Drawing.Size(45, 20);
            this.mnuAbrir.Text = "Abrir";
            this.mnuAbrir.Click += new System.EventHandler(this.mnuAbrir_Click);
            // 
            // mnuExcluir
            // 
            this.mnuExcluir.Name = "mnuExcluir";
            this.mnuExcluir.Size = new System.Drawing.Size(53, 20);
            this.mnuExcluir.Text = "Excluir";
            this.mnuExcluir.Click += new System.EventHandler(this.mnuExcluir_Click);
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridFun);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmFuncionarios";
            this.Text = "FrmFuncionarios";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFun)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridFun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuIncluir;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripMenuItem mnuExcluir;
    }
}