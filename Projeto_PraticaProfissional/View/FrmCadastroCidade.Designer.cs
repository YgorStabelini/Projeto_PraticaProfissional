namespace Projeto_PraticaProfissional.View
{
    partial class FrmCadastroCidade
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
            this.label5 = new System.Windows.Forms.Label();
            this.btConsultaEstado = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // txtBox_Cod
            // 
            this.txtBox_Cod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // txtDataCad
            // 
            this.txtDataCad.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // txt_UserCad
            // 
            this.txt_UserCad.Margin = new System.Windows.Forms.Padding(5);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Estado";
            // 
            // btConsultaEstado
            // 
            this.btConsultaEstado.Location = new System.Drawing.Point(585, 75);
            this.btConsultaEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConsultaEstado.Name = "btConsultaEstado";
            this.btConsultaEstado.Size = new System.Drawing.Size(91, 36);
            this.btConsultaEstado.TabIndex = 22;
            this.btConsultaEstado.Text = "Pesquisar";
            this.btConsultaEstado.UseVisualStyleBackColor = true;
            this.btConsultaEstado.Click += new System.EventHandler(this.btConsultaEstado_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(116, 82);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(463, 24);
            this.cbEstado.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(116, 31);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(367, 22);
            this.txtCidade.TabIndex = 17;
            // 
            // txtCodEstado
            // 
            this.txtCodEstado.Location = new System.Drawing.Point(15, 84);
            this.txtCodEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodEstado.Name = "txtCodEstado";
            this.txtCodEstado.Size = new System.Drawing.Size(95, 22);
            this.txtCodEstado.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Codigo Estado";
            // 
            // FrmCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btConsultaEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCadastroCidade";
            this.Load += new System.EventHandler(this.FrmCadastroCidade_Load);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lbl_DataCad, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.lbl_DataAlt, 0);
            this.Controls.SetChildIndex(this.txt_UserCad, 0);
            this.Controls.SetChildIndex(this.lbl_UsuarioCad, 0);
            this.Controls.SetChildIndex(this.txtBox_Cod, 0);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Salvar, 0);
            this.Controls.SetChildIndex(this.txtCidade, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cbEstado, 0);
            this.Controls.SetChildIndex(this.btConsultaEstado, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCodEstado, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btConsultaEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCodEstado;
        private System.Windows.Forms.Label label6;
    }
}
