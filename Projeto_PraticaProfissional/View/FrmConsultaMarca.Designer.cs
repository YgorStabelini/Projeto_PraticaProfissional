namespace Projeto_PraticaProfissional.View
{
    partial class FrmConsultaMarca
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
            this.DgViewMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewMarca)).BeginInit();
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
            this.tb_Chave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // DgViewMarca
            // 
            this.DgViewMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewMarca.Location = new System.Drawing.Point(16, 48);
            this.DgViewMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgViewMarca.Name = "DgViewMarca";
            this.DgViewMarca.RowHeadersWidth = 51;
            this.DgViewMarca.Size = new System.Drawing.Size(1035, 446);
            this.DgViewMarca.TabIndex = 6;
            // 
            // FrmConsultaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DgViewMarca);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmConsultaMarca";
            this.Load += new System.EventHandler(this.FrmConsultaMarca_Load);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Excluir, 0);
            this.Controls.SetChildIndex(this.bt_Alterar, 0);
            this.Controls.SetChildIndex(this.bt_Incluir, 0);
            this.Controls.SetChildIndex(this.tb_Chave, 0);
            this.Controls.SetChildIndex(this.bt_Pesquisa, 0);
            this.Controls.SetChildIndex(this.DgViewMarca, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewMarca;
    }
}
