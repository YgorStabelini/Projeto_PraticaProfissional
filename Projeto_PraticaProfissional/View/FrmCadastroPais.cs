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

namespace Projeto_PraticaProfissional
{
    public partial class FrmCadastroPais : Projeto_PraticaProfissional.FrmCadastro
    {
        private uCtrlPaises ControllerPaises = new uCtrlPaises();
        public FrmCadastroPais()
        {
            InitializeComponent();
        }
        private void bt_Salvar_Click(object sender, EventArgs e)
        {
            Pais obj = new Pais();
            obj.Descricao = txtdescricao.Text;
            obj.Sigla = txtsigla.Text.ToUpper();
            obj.DataCad = DateTime.Parse(txtDataCad.Text);
            obj.DataAlt = DateTime.Parse(txtDataAlt.Text);

            ControllerPaises.Salvar(obj);

            this.Close();
        }

        private void FrmCadastroPais_Load(object sender, EventArgs e)
        {
            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;
        }
    }
}
