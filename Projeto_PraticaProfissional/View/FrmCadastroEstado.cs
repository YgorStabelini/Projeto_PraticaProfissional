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
    public partial class FrmCadastroEstado : Projeto_PraticaProfissional.FrmCadastro
    {
        private uCtrlEstado ControllerEstados = new uCtrlEstado();
        public FrmCadastroEstado()
        {
            InitializeComponent();
        }

        private void FrmCadastroEstado_Load(object sender, EventArgs e)
        {
            PaisDAO paisDAO = new PaisDAO();

            cbPais.DataSource = paisDAO.ListarPais();
            cbPais.DisplayMember = "Nome_Pais";
            cbPais.ValueMember = "Cod_Pais";

            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;

        }

        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Estado obj = new Estado();
            obj.Descricao = txtNomeEstado.Text;
            obj.UF = txtUF.Text.ToUpper();
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);
            obj.IdPais = int.Parse(cbPais.SelectedValue.ToString());

            ControllerEstados.Salvar(obj);

            this.Close();
        }

        private void btPesquisaPais_Click(object sender, EventArgs e)
        {
            FrmConsultaPais frmConsPais = new FrmConsultaPais(); 
            frmConsPais.ShowDialog();
        }
    }
}
