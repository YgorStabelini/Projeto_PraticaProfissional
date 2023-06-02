namespace Projeto_PraticaProfissional.View
{
    partial class FrmConsultaEstado
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
            this.DgViewEstado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Click += new System.EventHandler(this.bt_Incluir_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Click += new System.EventHandler(this.bt_Excluir_Click);
            // 
            // tb_Chave
            // 
            this.tb_Chave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // DgViewEstado
            // 
            this.DgViewEstado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewEstado.Location = new System.Drawing.Point(16, 54);
            this.DgViewEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgViewEstado.Name = "DgViewEstado";
            this.DgViewEstado.RowHeadersWidth = 51;
            this.DgViewEstado.RowTemplate.Height = 24;
            this.DgViewEstado.Size = new System.Drawing.Size(1035, 446);
            this.DgViewEstado.TabIndex = 7;
            // 
            // FrmConsultaEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DgViewEstado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmConsultaEstado";
            this.Load += new System.EventHandler(this.FrmConsultaEstado_Load_1);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Excluir, 0);
            this.Controls.SetChildIndex(this.bt_Alterar, 0);
            this.Controls.SetChildIndex(this.bt_Incluir, 0);
            this.Controls.SetChildIndex(this.tb_Chave, 0);
            this.Controls.SetChildIndex(this.bt_Pesquisa, 0);
            this.Controls.SetChildIndex(this.DgViewEstado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewEstado;
    }
}
