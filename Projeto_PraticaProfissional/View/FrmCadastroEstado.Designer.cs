namespace Projeto_PraticaProfissional.View
{
    partial class FrmCadastroEstado
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
            this.txtNomeEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btPesquisaPais = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodPais = new System.Windows.Forms.TextBox();
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
            this.txt_UserCad.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // txtNomeEstado
            // 
            this.txtNomeEstado.Location = new System.Drawing.Point(111, 31);
            this.txtNomeEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeEstado.Name = "txtNomeEstado";
            this.txtNomeEstado.Size = new System.Drawing.Size(367, 22);
            this.txtNomeEstado.TabIndex = 4;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(483, 31);
            this.txtUF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(89, 22);
            this.txtUF.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "UF";
            // 
            // cbPais
            // 
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(111, 82);
            this.cbPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(463, 24);
            this.cbPais.TabIndex = 8;
            // 
            // btPesquisaPais
            // 
            this.btPesquisaPais.Location = new System.Drawing.Point(580, 77);
            this.btPesquisaPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPesquisaPais.Name = "btPesquisaPais";
            this.btPesquisaPais.Size = new System.Drawing.Size(91, 33);
            this.btPesquisaPais.TabIndex = 9;
            this.btPesquisaPais.Text = "Pesquisar";
            this.btPesquisaPais.UseVisualStyleBackColor = true;
            this.btPesquisaPais.Click += new System.EventHandler(this.btPesquisaPais_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Codigo Pais";
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(16, 82);
            this.txtCodPais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(89, 22);
            this.txtCodPais.TabIndex = 17;
            // 
            // FrmCadastroEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btPesquisaPais);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtNomeEstado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCadastroEstado";
            this.Load += new System.EventHandler(this.FrmCadastroEstado_Load);
            this.Controls.SetChildIndex(this.txtDataCad, 0);
            this.Controls.SetChildIndex(this.lbl_DataCad, 0);
            this.Controls.SetChildIndex(this.txtDataAlt, 0);
            this.Controls.SetChildIndex(this.lbl_DataAlt, 0);
            this.Controls.SetChildIndex(this.txt_UserCad, 0);
            this.Controls.SetChildIndex(this.lbl_UsuarioCad, 0);
            this.Controls.SetChildIndex(this.txtBox_Cod, 0);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Salvar, 0);
            this.Controls.SetChildIndex(this.txtNomeEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cbPais, 0);
            this.Controls.SetChildIndex(this.btPesquisaPais, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeEstado;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Button btPesquisaPais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodPais;
    }
}
