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
    public partial class FrmConsultaFuncionario : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaFuncionario()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            FrmCadastroFuncionario FrmCadFuncionario = new FrmCadastroFuncionario();
            FrmCadFuncionario.ShowDialog();

            DgViewFuncionario.DataSource = dao.ListaFuncionario();
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario();

            obj.Id = Convert.ToInt32(DgViewFuncionario.Rows[DgViewFuncionario.CurrentCell.RowIndex].Cells["Cod_Funcionario"].Value);

            FuncionarioDAO dao = new FuncionarioDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirFuncionario(obj);
                DgViewFuncionario.DataSource = dao.ListaFuncionario();
            }
        }

        private void FrmConsultaFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();
            DgViewFuncionario.DataSource = dao.ListaFuncionario();
        }
    }
}
