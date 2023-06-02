using Projeto_PraticaProfissional.Controller;
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
    public partial class FrmCadastroCidade : Projeto_PraticaProfissional.FrmCadastro
    {
        private uCtrlCidade ControllerCidades = new uCtrlCidade();
        public FrmCadastroCidade()
        {
            InitializeComponent();
        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Cidade obj = new Cidade();
            obj.Descricao = txtCidade.Text;
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);
            obj.IdEstado = int.Parse(cbEstado.SelectedValue.ToString());

            ControllerCidades.Salvar(obj);

            this.Close();
        }

        private void FrmCadastroCidade_Load(object sender, EventArgs e)
        {
            EstadoDAO EstadoDAO = new EstadoDAO();

            cbEstado.DataSource = EstadoDAO.ListarEstado();
            cbEstado.DisplayMember = "Nome_Estado";
            cbEstado.ValueMember = "Cod_Estado";

            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }

        private void btConsultaEstado_Click(object sender, EventArgs e)
        {
            FrmConsultaEstado frmConsEstado = new FrmConsultaEstado();
            frmConsEstado.ShowDialog();
        }
    }
}
