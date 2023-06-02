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
    public partial class FrmConsultaCliente : Projeto_PraticaProfissional.FrmConsulta
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void bt_Incluir_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente frmCadCliente = new FrmCadastroCliente();
            frmCadCliente.ShowDialog();
        }

        private void bt_Excluir_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.Id = Convert.ToInt32(DgViewCliente.Rows[DgViewCliente.CurrentCell.RowIndex].Cells["Cod_Cliente"].Value);

            ClienteDAO dao = new ClienteDAO();
            if (MessageBox.Show("Tem certeza que deseja Excluir este Cadastro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dao.ExcluirCliente(obj);
                DgViewCliente.DataSource = dao.ListaCliente();
            }
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            DgViewCliente.DataSource = dao.ListaCliente();
        }
    }
}
