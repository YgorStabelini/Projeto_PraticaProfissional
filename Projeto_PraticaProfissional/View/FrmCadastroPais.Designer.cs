namespace Projeto_PraticaProfissional
{
    partial class FrmCadastroPais
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtsigla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // txtBox_Cod
            // 
            this.txtBox_Cod.Margin = new System.Windows.Forms.Padding(2);
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(90, 25);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(291, 20);
            this.txtdescricao.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição";
            // 
            // txtsigla
            // 
            this.txtsigla.Location = new System.Drawing.Point(394, 25);
            this.txtsigla.Margin = new System.Windows.Forms.Padding(2);
            this.txtsigla.Name = "txtsigla";
            this.txtsigla.Size = new System.Drawing.Size(92, 20);
            this.txtsigla.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sigla";
            // 
            // FrmCadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsigla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescricao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadastroPais";
            this.Load += new System.EventHandler(this.FrmCadastroPais_Load);
            this.Controls.SetChildIndex(this.txtBox_Cod, 0);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Salvar, 0);
            this.Controls.SetChildIndex(this.txtdescricao, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtsigla, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtdescricao;
        public System.Windows.Forms.TextBox txtsigla;
    }
}
