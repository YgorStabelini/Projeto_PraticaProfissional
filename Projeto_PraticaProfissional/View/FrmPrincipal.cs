using Projeto_PraticaProfissional.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_PraticaProfissional
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPais frmConsPais = new FrmConsultaPais();
            frmConsPais.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaEstado frmConsEstado = new FrmConsultaEstado();
            frmConsEstado.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCidade frmConsCidade = new FrmConsultaCidade();
            frmConsCidade.ShowDialog();
        }

        private void unidaDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaUndMedida frmConsUndMedida = new FrmConsultaUndMedida();
            frmConsUndMedida.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMarca frmConsMarca = new FrmConsultaMarca();
            frmConsMarca.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente frmConsCliente = new FrmConsultaCliente();
            frmConsCliente.ShowDialog();
        }

        private void grupoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaGrupoProduto frmConsGrupoProduto = new FrmConsultaGrupoProduto();
            frmConsGrupoProduto.ShowDialog();
        }

        private void subGrupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaSubGrupo frmConsSubGrupo = new FrmConsultaSubGrupo();
            frmConsSubGrupo.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaFuncionario frmConsFuncionario = new FrmConsultaFuncionario();
            frmConsFuncionario.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor frmConsFuncionario = new FrmConsultaFornecedor();
            frmConsFuncionario.ShowDialog();
        }
    }
}
