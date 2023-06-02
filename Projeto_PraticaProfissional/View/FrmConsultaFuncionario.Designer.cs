namespace Projeto_PraticaProfissional.View
{
    partial class FrmConsultaFuncionario
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
            this.DgViewFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewFuncionario)).BeginInit();
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
            // DgViewFuncionario
            // 
            this.DgViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewFuncionario.Location = new System.Drawing.Point(16, 48);
            this.DgViewFuncionario.Name = "DgViewFuncionario";
            this.DgViewFuncionario.RowHeadersWidth = 51;
            this.DgViewFuncionario.RowTemplate.Height = 24;
            this.DgViewFuncionario.Size = new System.Drawing.Size(1034, 446);
            this.DgViewFuncionario.TabIndex = 6;
            // 
            // FrmConsultaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DgViewFuncionario);
            this.Name = "FrmConsultaFuncionario";
            this.Load += new System.EventHandler(this.FrmConsultaFuncionario_Load);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Excluir, 0);
            this.Controls.SetChildIndex(this.bt_Alterar, 0);
            this.Controls.SetChildIndex(this.bt_Incluir, 0);
            this.Controls.SetChildIndex(this.tb_Chave, 0);
            this.Controls.SetChildIndex(this.bt_Pesquisa, 0);
            this.Controls.SetChildIndex(this.DgViewFuncionario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewFuncionario;
    }
}
