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
    public partial class FrmConsultaPais : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaPais()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            PaisDAO dao = new PaisDAO();

            FrmCadastroPais frmCadPais = new FrmCadastroPais();
            frmCadPais.ShowDialog();

            DgViewPais.DataSource = dao.ListarPais();
        }

        private void FrmConsultaPais_Load(object sender, EventArgs e)
        {
            PaisDAO dao = new PaisDAO();
            DgViewPais.DataSource = dao.ListarPais();
            DgViewPais.Columns["Cod_Pais"].HeaderText = "Código";
            DgViewPais.Columns["Nome_Pais"].HeaderText = "Nome";
            DgViewPais.Columns["Sigla"].HeaderText = "Sigla";
            RbNome.Checked = true;
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            Pais obj = new Pais();

            obj.Id = Convert.ToInt32(DgViewPais.Rows[DgViewPais.CurrentCell.RowIndex].Cells["Cod_Pais"].Value);

            PaisDAO dao = new PaisDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirPais(obj);
                DgViewPais.DataSource = dao.ListarPais();
            }
        }

        private void bt_Alterar_Click(object sender, EventArgs e)
        {
            FrmCadastroPais FrmCadPais = new FrmCadastroPais();

            Pais obj = new Pais();
            obj.Id = Convert.ToInt32(DgViewPais.Rows[DgViewPais.CurrentCell.RowIndex].Cells["Cod_Pais"].Value);
            FrmCadPais.ShowDialog();

            PaisDAO dao = new PaisDAO();
            dao.AlterarPais(obj);

            DgViewPais.DataSource = dao.ListarPais();
            this.Close();
        }

        private void bt_Pesquisa_Click(object sender, EventArgs e)
        {
            string nome = "%" + tb_Chave.Text + "%";
            string id = tb_Chave.Text;
            PaisDAO dao = new PaisDAO();

            foreach (RadioButton rb in groupBox1.Controls)
            {
                if (RbNome.Checked)
                {
                    DgViewPais.DataSource = dao.PesquisarNome(nome);
                }
                else if (RbCodigo.Checked)
                {
                    DgViewPais.DataSource = dao.PesquisarID(id);
                }
                if (DgViewPais.Rows.Count == 0)
                {
                    DgViewPais.DataSource = dao.ListarPais();
                }
            }
        }
    }
}
