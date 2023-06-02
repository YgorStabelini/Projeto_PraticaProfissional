namespace Projeto_PraticaProfissional.View
{
    partial class FrmCadastroGrupoProduto
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
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txt_NomeGrupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(85, 25);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(257, 20);
            this.txtdescricao.TabIndex = 4;
            // 
            // txt_NomeGrupo
            // 
            this.txt_NomeGrupo.AutoSize = true;
            this.txt_NomeGrupo.Location = new System.Drawing.Point(82, 9);
            this.txt_NomeGrupo.Name = "txt_NomeGrupo";
            this.txt_NomeGrupo.Size = new System.Drawing.Size(55, 13);
            this.txt_NomeGrupo.TabIndex = 5;
            this.txt_NomeGrupo.Text = "Descrição";
            // 
            // FrmCadastroGrupoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_NomeGrupo);
            this.Controls.Add(this.txtdescricao);
            this.Name = "FrmCadastroGrupoProduto";
            this.Load += new System.EventHandler(this.FrmCadastroGrupoProduto_Load);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lbl_DataCad, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.lbl_DataAlt, 0);
            this.Controls.SetChildIndex(this.txt_UserCad, 0);
            this.Controls.SetChildIndex(this.lbl_UsuarioCad, 0);
            this.Controls.SetChildIndex(this.txtBox_Cod, 0);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Salvar, 0);
            this.Controls.SetChildIndex(this.txtdescricao, 0);
            this.Controls.SetChildIndex(this.txt_NomeGrupo, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label txt_NomeGrupo;
    }
}
