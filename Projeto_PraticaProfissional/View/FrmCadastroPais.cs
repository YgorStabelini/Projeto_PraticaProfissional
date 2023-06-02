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
        public int id_selecionado;
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
            obj.DDI = TxtDDI.Text;
            obj.Status = int.Parse(cbStatus.SelectedValue.ToString());

            if (obj.Id != id_selecionado)
            {
                obj.Id = id_selecionado;
                ControllerPaises.Alterar(obj);
            }
            else
            {
                ControllerPaises.Salvar(obj);
            }
            this.Close();
        }

        private void FrmCadastroPais_Load(object sender, EventArgs e)
        {
            txtDataCad.Text = DateTime.Now.ToString();
            txtDataAlt.Text = DateTime.Now.ToString();
            txtDataCad.Enabled = false;
            txtDataAlt.Enabled = false;


            //popula ComboBox
            Dictionary<int, string> st = new Dictionary<int, string>();
            st.Add(1, "Ativo");
            st.Add(2, "Desativado");
            cbStatus.Items.Clear();
            cbStatus.DataSource = new BindingSource(st, null);
            cbStatus.DisplayMember= "Value";
            cbStatus.ValueMember = "Key";
        }
    }
}
