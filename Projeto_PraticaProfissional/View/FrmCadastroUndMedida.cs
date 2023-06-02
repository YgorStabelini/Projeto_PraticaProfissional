using Projeto_PraticaProfissional.Dao;
using Projeto_PraticaProfissional.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto_PraticaProfissional.View
{
    public partial class FrmCadastroUndMedida : Projeto_PraticaProfissional.FrmCadastro
    {
        public FrmCadastroUndMedida()
        {
            InitializeComponent();
        }

        private void FrmCadastroUndMedida_Load(object sender, EventArgs e)
        {
            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            UnidadeDeMedida obj = new UnidadeDeMedida();
            obj.Descricao = txtDescricao.Text;
            obj.Abreviacao = txtAbreviacao.Text.ToUpper();
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);

            UndMedidaDAO dao = new UndMedidaDAO();
            dao.CadastrarUndMedida(obj);

            this.Close();
        }
    }
}
