using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Models
{
    public class Funcionario: Pessoa
    {
        public DateTime DataAdmissao { get; set; }

        public DateTime DataDemissao { get; set; }

        public DateTime DataNasc { get; set; }

        public Char Sexo { get; set; }
    }
}
