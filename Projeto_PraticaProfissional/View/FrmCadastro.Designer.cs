namespace Projeto_PraticaProfissional
{
    partial class FrmCadastro
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
            this.txtBox_Cod = new System.Windows.Forms.TextBox();
            this.lb_Codigo = new System.Windows.Forms.Label();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.lbl_DataAlt = new System.Windows.Forms.Label();
            this.txtDataAlt = new System.Windows.Forms.TextBox();
            this.lbl_DataCad = new System.Windows.Forms.Label();
            this.txtDataCad = new System.Windows.Forms.TextBox();
            this.txt_UserCad = new System.Windows.Forms.TextBox();
            this.lbl_UsuarioCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_Cod
            // 
            this.txtBox_Cod.Enabled = false;
            this.txtBox_Cod.Location = new System.Drawing.Point(12, 25);
            this.txtBox_Cod.Name = "txtBox_Cod";
            this.txtBox_Cod.Size = new System.Drawing.Size(67, 20);
            this.txtBox_Cod.TabIndex = 0;
            // 
            // lb_Codigo
            // 
            this.lb_Codigo.AutoSize = true;
            this.lb_Codigo.Location = new System.Drawing.Point(9, 9);
            this.lb_Codigo.Name = "lb_Codigo";
            this.lb_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lb_Codigo.TabIndex = 1;
            this.lb_Codigo.Text = "Codigo";
            // 
            // bt_Sair
            // 
            this.bt_Sair.Location = new System.Drawing.Point(697, 407);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(91, 31);
            this.bt_Sair.TabIndex = 2;
            this.bt_Sair.Text = "&Sair";
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(600, 407);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(91, 31);
            this.bt_Salvar.TabIndex = 3;
            this.bt_Salvar.Text = "&Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            // 
            // lbl_DataAlt
            // 
            this.lbl_DataAlt.AutoSize = true;
            this.lbl_DataAlt.Location = new System.Drawing.Point(500, 403);
            this.lbl_DataAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataAlt.Name = "lbl_DataAlt";
            this.lbl_DataAlt.Size = new System.Drawing.Size(93, 13);
            this.lbl_DataAlt.TabIndex = 30;
            this.lbl_DataAlt.Text = "Data de Alteração";
            // 
            // txtDataAlt
            // 
            this.txtDataAlt.Location = new System.Drawing.Point(503, 418);
            this.txtDataAlt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataAlt.Name = "txtDataAlt";
            this.txtDataAlt.Size = new System.Drawing.Size(92, 20);
            this.txtDataAlt.TabIndex = 29;
            // 
            // lbl_DataCad
            // 
            this.lbl_DataCad.AutoSize = true;
            this.lbl_DataCad.Location = new System.Drawing.Point(397, 403);
            this.lbl_DataCad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DataCad.Name = "lbl_DataCad";
            this.lbl_DataCad.Size = new System.Drawing.Size(88, 13);
            this.lbl_DataCad.TabIndex = 28;
            this.lbl_DataCad.Text = "Data de Inclusão";
            // 
            // txtDataCad
            // 
            this.txtDataCad.Location = new System.Drawing.Point(399, 418);
            this.txtDataCad.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataCad.Name = "txtDataCad";
            this.txtDataCad.Size = new System.Drawing.Size(92, 20);
            this.txtDataCad.TabIndex = 27;
            // 
            // txt_UserCad
            // 
            this.txt_UserCad.Location = new System.Drawing.Point(278, 418);
            this.txt_UserCad.Name = "txt_UserCad";
            this.txt_UserCad.Size = new System.Drawing.Size(116, 20);
            this.txt_UserCad.TabIndex = 31;
            // 
            // lbl_UsuarioCad
            // 
            this.lbl_UsuarioCad.AutoSize = true;
            this.lbl_UsuarioCad.Location = new System.Drawing.Point(275, 403);
            this.lbl_UsuarioCad.Name = "lbl_UsuarioCad";
            this.lbl_UsuarioCad.Size = new System.Drawing.Size(46, 13);
            this.lbl_UsuarioCad.TabIndex = 32;
            this.lbl_UsuarioCad.Text = "Usuario ";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_UsuarioCad);
            this.Controls.Add(this.txt_UserCad);
            this.Controls.Add(this.lbl_DataAlt);
            this.Controls.Add(this.txtDataAlt);
            this.Controls.Add(this.lbl_DataCad);
            this.Controls.Add(this.txtDataCad);
            this.Controls.Add(this.bt_Salvar);
            this.Controls.Add(this.bt_Sair);
            this.Controls.Add(this.lb_Codigo);
            this.Controls.Add(this.txtBox_Cod);
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Codigo;
        public System.Windows.Forms.Button bt_Salvar;
        public System.Windows.Forms.Button bt_Sair;
        public System.Windows.Forms.TextBox txtBox_Cod;
        public System.Windows.Forms.Label lbl_DataAlt;
        public System.Windows.Forms.TextBox txtDataAlt;
        public System.Windows.Forms.Label lbl_DataCad;
        public System.Windows.Forms.TextBox txtDataCad;
        public System.Windows.Forms.TextBox txt_UserCad;
        public System.Windows.Forms.Label lbl_UsuarioCad;
    }
}