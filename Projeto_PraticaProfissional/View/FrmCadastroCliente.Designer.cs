namespace Projeto_PraticaProfissional.View
{
    partial class FrmCadastroCliente
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(10, 69);
            this.txtNome.Size = new System.Drawing.Size(369, 20);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(383, 69);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(256, 25);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 53);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(381, 53);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 10);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(469, 92);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(291, 91);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 91);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(469, 108);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(293, 108);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 108);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(469, 138);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(291, 137);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 137);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(469, 153);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(293, 153);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 153);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(10, 181);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(12, 197);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 221);
            // 
            // txtCodPais
            // 
            this.txtCodPais.Location = new System.Drawing.Point(9, 238);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(79, 221);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 232);
            this.button1.Size = new System.Drawing.Size(68, 28);
            // 
            // cbCidade
            // 
            this.cbCidade.Location = new System.Drawing.Point(81, 237);
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(294, 197);
            // 
            // lb_cep
            // 
            this.lb_cep.Location = new System.Drawing.Point(294, 182);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(81, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Tipo Cliente";
            // 
            // FrmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmCadastroCliente";
            this.Load += new System.EventHandler(this.FrmCadastroCliente_Load);
            this.Controls.SetChildIndex(this.cbCidade, 0);
            this.Controls.SetChildIndex(this.txtCEP, 0);
            this.Controls.SetChildIndex(this.lb_cep, 0);
            this.Controls.SetChildIndex(this.txtBox_Cod, 0);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Salvar, 0);
            this.Controls.SetChildIndex(this.txtNome, 0);
            this.Controls.SetChildIndex(this.txtRG, 0);
            this.Controls.SetChildIndex(this.txtCPF, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtTelefone, 0);
            this.Controls.SetChildIndex(this.txtCelular, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtEndereco, 0);
            this.Controls.SetChildIndex(this.txtNumero, 0);
            this.Controls.SetChildIndex(this.txtComplemento, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtBairro, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label15;
    }
}
