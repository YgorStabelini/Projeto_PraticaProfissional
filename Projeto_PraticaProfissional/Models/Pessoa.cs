using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_PraticaProfissional.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Cep { get; set; }

        public string Endereco { get; set; }

        public int numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public int Id_Cidade { get; set; }

        public DateTime DataCad { get; set; }

        public DateTime DataAlt { get; set; }
    }
}
