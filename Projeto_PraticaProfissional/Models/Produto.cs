using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int Id_Marca { get; set; }

        public int Id_GrupoProduto { get; set; }

        public int Id_SubGrupo { get; set; }

        public int Id_UndMedida { get; set; }

        public int Id_Fornecedor { get; set; }

        public double PrecoCompra { get; set; }

        public double PrecoVenda { get; set; }

        public DateTime DataCad { get; set; }

        public DateTime DataAlt { get; set; }
    }
}
