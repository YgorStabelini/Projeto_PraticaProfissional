namespace Projeto_PraticaProfissional.View
{
    partial class FrmConsultaSubGrupo
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
            this.DgViewSubGrupo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewSubGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Click += new System.EventHandler(this.bt_Incluir_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // DgViewSubGrupo
            // 
            this.DgViewSubGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewSubGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewSubGrupo.Location = new System.Drawing.Point(12, 39);
            this.DgViewSubGrupo.Name = "DgViewSubGrupo";
            this.DgViewSubGrupo.Size = new System.Drawing.Size(776, 362);
            this.DgViewSubGrupo.TabIndex = 6;
            // 
            // FrmConsultaSubGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgViewSubGrupo);
            this.Name = "FrmConsultaSubGrupo";
            this.Load += new System.EventHandler(this.FrmConsultaSubGrupo_Load);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Excluir, 0);
            this.Controls.SetChildIndex(this.bt_Alterar, 0);
            this.Controls.SetChildIndex(this.bt_Incluir, 0);
            this.Controls.SetChildIndex(this.tb_Chave, 0);
            this.Controls.SetChildIndex(this.bt_Pesquisa, 0);
            this.Controls.SetChildIndex(this.DgViewSubGrupo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewSubGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewSubGrupo;
    }
}
