using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouHungry.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Especialidade { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

    }
}
