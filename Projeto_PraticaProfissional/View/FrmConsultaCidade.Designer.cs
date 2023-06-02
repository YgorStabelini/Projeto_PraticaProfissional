namespace Projeto_PraticaProfissional.View
{
    partial class FrmConsultaCidade
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
            this.DgViewCidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCidade)).BeginInit();
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
            // tb_Chave
            // 
            this.tb_Chave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // DgViewCidade
            // 
            this.DgViewCidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewCidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewCidade.Location = new System.Drawing.Point(16, 54);
            this.DgViewCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgViewCidade.Name = "DgViewCidade";
            this.DgViewCidade.RowHeadersWidth = 51;
            this.DgViewCidade.RowTemplate.Height = 24;
            this.DgViewCidade.Size = new System.Drawing.Size(1035, 446);
            this.DgViewCidade.TabIndex = 7;
            // 
            // FrmConsultaCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DgViewCidade);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConsultaCidade";
            this.Load += new System.EventHandler(this.FrmConsultaCidade_Load);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Excluir, 0);
            this.Controls.SetChildIndex(this.bt_Alterar, 0);
            this.Controls.SetChildIndex(this.bt_Incluir, 0);
            this.Controls.SetChildIndex(this.tb_Chave, 0);
            this.Controls.SetChildIndex(this.bt_Pesquisa, 0);
            this.Controls.SetChildIndex(this.DgViewCidade, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewCidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewCidade;
    }
}
