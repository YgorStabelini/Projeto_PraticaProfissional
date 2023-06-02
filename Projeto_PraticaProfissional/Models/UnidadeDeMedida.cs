using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Models
{
    public class UnidadeDeMedida
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Abreviacao { get; set; }

        public DateTime DataCad { get; set; }

        public DateTime DataAlt { get; set; }
    }
}
