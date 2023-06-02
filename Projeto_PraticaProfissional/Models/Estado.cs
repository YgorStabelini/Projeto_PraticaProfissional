using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Models
{
    public class Estado
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string UF { get; set; }

        public int IdPais { get; set; }

        public DateTime DataCad { get; set; }

        public DateTime DataAlt { get; set; }
    }
}
