using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouHungry.Models
{
    public class Prato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public string Tempo { get; set; }
        public string Imagem { get; set; }
        public int RestauranteId { get; set; }
        public Restaurante Restaurante { get; set; }
    }
}
