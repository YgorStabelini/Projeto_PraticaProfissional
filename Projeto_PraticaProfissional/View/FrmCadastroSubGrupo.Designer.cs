namespace Projeto_PraticaProfissional.View
{
    partial class FrmCadastroSubGrupo
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
            this.cb_GrupoProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.txtdescricao.Size = new System.Drawing.Size(256, 20);
            this.txtdescricao.TabIndex = 33;
            // 
            // cb_GrupoProduto
            // 
            this.cb_GrupoProduto.FormattingEnabled = true;
            this.cb_GrupoProduto.Location = new System.Drawing.Point(347, 25);
            this.cb_GrupoProduto.Name = "cb_GrupoProduto";
            this.cb_GrupoProduto.Size = new System.Drawing.Size(174, 21);
            this.cb_GrupoProduto.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Grupo de Produto";
            // 
            // FrmCadastroSubGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_GrupoProduto);
            this.Controls.Add(this.txtdescricao);
            this.Name = "FrmCadastroSubGrupo";
            this.Load += new System.EventHandler(this.FrmCadastroSubGrupo_Load);
            this.Controls.SetChildIndex(this.txtBox_Cod, 0);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Salvar, 0);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lbl_DataCad, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.lbl_DataAlt, 0);
            this.Controls.SetChildIndex(this.txt_UserCad, 0);
            this.Controls.SetChildIndex(this.lbl_UsuarioCad, 0);
            this.Controls.SetChildIndex(this.txtdescricao, 0);
            this.Controls.SetChildIndex(this.cb_GrupoProduto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.ComboBox cb_GrupoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
