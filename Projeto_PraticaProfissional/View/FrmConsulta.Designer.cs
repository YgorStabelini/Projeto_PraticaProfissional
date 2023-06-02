namespace Projeto_PraticaProfissional
{
    partial class FrmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Excluir = new System.Windows.Forms.Button();
            this.bt_Alterar = new System.Windows.Forms.Button();
            this.bt_Incluir = new System.Windows.Forms.Button();
            this.tb_Chave = new System.Windows.Forms.TextBox();
            this.bt_Pesquisa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(929, 501);
            this.bt_Sair.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(121, 38);
            this.bt_Sair.TabIndex = 0;
            this.bt_Sair.Text = "&Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Excluir
            // 
            this.bt_Excluir.Location = new System.Drawing.Point(800, 501);
            this.bt_Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Excluir.Name = "bt_Excluir";
            this.bt_Excluir.Size = new System.Drawing.Size(121, 38);
            this.bt_Excluir.TabIndex = 1;
            this.bt_Excluir.Text = "&Excluir";
            this.bt_Excluir.UseVisualStyleBackColor = true;
            // 
            // bt_Alterar
            // 
            this.bt_Alterar.Location = new System.Drawing.Point(671, 501);
            this.bt_Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Alterar.Name = "bt_Alterar";
            this.bt_Alterar.Size = new System.Drawing.Size(121, 38);
            this.bt_Alterar.TabIndex = 2;
            this.bt_Alterar.Text = "&Alterar";
            this.bt_Alterar.UseVisualStyleBackColor = true;
            // 
            // bt_Incluir
            // 
            this.bt_Incluir.Location = new System.Drawing.Point(541, 501);
            this.bt_Incluir.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Incluir.Name = "bt_Incluir";
            this.bt_Incluir.Size = new System.Drawing.Size(121, 38);
            this.bt_Incluir.TabIndex = 3;
            this.bt_Incluir.Text = "&Incluir";
            this.bt_Incluir.UseVisualStyleBackColor = true;
            // 
            // tb_Chave
            // 
            this.tb_Chave.Location = new System.Drawing.Point(16, 15);
            this.tb_Chave.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Chave.Name = "tb_Chave";
            this.tb_Chave.Size = new System.Drawing.Size(403, 22);
            this.tb_Chave.TabIndex = 4;
            // 
            // bt_Pesquisa
            // 
            this.bt_Pesquisa.Location = new System.Drawing.Point(427, 14);
            this.bt_Pesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Pesquisa.Name = "bt_Pesquisa";
            this.bt_Pesquisa.Size = new System.Drawing.Size(121, 27);
            this.bt_Pesquisa.TabIndex = 5;
            this.bt_Pesquisa.Text = "&Pesquisa";
            this.bt_Pesquisa.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_Pesquisa);
            this.Controls.Add(this.tb_Chave);
            this.Controls.Add(this.bt_Incluir);
            this.Controls.Add(this.bt_Alterar);
            this.Controls.Add(this.bt_Excluir);
            this.Controls.Add(this.bt_Sair);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsulta";
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bt_Incluir;
        public System.Windows.Forms.Button bt_Sair;
        public System.Windows.Forms.Button bt_Excluir;
        public System.Windows.Forms.Button bt_Alterar;
        public System.Windows.Forms.TextBox tb_Chave;
        public System.Windows.Forms.Button bt_Pesquisa;
    }
}