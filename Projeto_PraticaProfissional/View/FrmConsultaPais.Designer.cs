namespace Projeto_PraticaProfissional
{
    partial class FrmConsultaPais
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
            this.DgViewPais = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbCodigo = new System.Windows.Forms.RadioButton();
            this.RbNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPais)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // bt_Alterar
            // 
            this.bt_Alterar.Click += new System.EventHandler(this.bt_Alterar_Click);
            // 
            // tb_Chave
            // 
            this.tb_Chave.Margin = new System.Windows.Forms.Padding(4);
            // 
            // bt_Pesquisa
            // 
            this.bt_Pesquisa.Click += new System.EventHandler(this.bt_Pesquisa_Click);
            // 
            // DgViewPais
            // 
            this.DgViewPais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgViewPais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgViewPais.Location = new System.Drawing.Point(12, 39);
            this.DgViewPais.Margin = new System.Windows.Forms.Padding(2);
            this.DgViewPais.Name = "DgViewPais";
            this.DgViewPais.RowHeadersWidth = 51;
            this.DgViewPais.RowTemplate.Height = 24;
            this.DgViewPais.Size = new System.Drawing.Size(776, 362);
            this.DgViewPais.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbCodigo);
            this.groupBox1.Controls.Add(this.RbNome);
            this.groupBox1.Location = new System.Drawing.Point(418, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 33);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // RbCodigo
            // 
            this.RbCodigo.AutoSize = true;
            this.RbCodigo.Location = new System.Drawing.Point(66, 12);
            this.RbCodigo.Name = "RbCodigo";
            this.RbCodigo.Size = new System.Drawing.Size(58, 17);
            this.RbCodigo.TabIndex = 1;
            this.RbCodigo.TabStop = true;
            this.RbCodigo.Text = "Codigo";
            this.RbCodigo.UseVisualStyleBackColor = true;
            // 
            // RbNome
            // 
            this.RbNome.AutoSize = true;
            this.RbNome.Location = new System.Drawing.Point(7, 11);
            this.RbNome.Name = "RbNome";
            this.RbNome.Size = new System.Drawing.Size(53, 17);
            this.RbNome.TabIndex = 0;
            this.RbNome.TabStop = true;
            this.RbNome.Text = "Nome";
            this.RbNome.UseVisualStyleBackColor = true;
            // 
            // FrmConsultaPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgViewPais);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultaPais";
            this.Text = "Consulta Pais";
            this.Load += new System.EventHandler(this.FrmConsultaPais_Load);
            this.Controls.SetChildIndex(this.bt_Sair, 0);
            this.Controls.SetChildIndex(this.bt_Excluir, 0);
            this.Controls.SetChildIndex(this.bt_Alterar, 0);
            this.Controls.SetChildIndex(this.bt_Incluir, 0);
            this.Controls.SetChildIndex(this.tb_Chave, 0);
            this.Controls.SetChildIndex(this.bt_Pesquisa, 0);
            this.Controls.SetChildIndex(this.DgViewPais, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DgViewPais)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgViewPais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbCodigo;
        private System.Windows.Forms.RadioButton RbNome;
    }
}
