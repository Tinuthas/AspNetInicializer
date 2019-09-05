using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetInicializar.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Nome { get; set; }
        public bool Carnivoro { get; set; }
        public TipoAnimal Tipo { get; set; }
    }
}
