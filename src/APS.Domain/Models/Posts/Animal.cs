using APS.Domain.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class Animal:Entity
    {
        protected Animal() { }

        public Animal(long id) { Id = id; }

        public string Nome { get; private set; }

        public string Tipo { get; private set; }

        public string Raca { get; private set; }

        public string Descricao { get; private set; }

        public decimal Kilos { get; private set; }

        public virtual ICollection<AnimalArquivo> ImagensAnimal { get; private set; }
    }
}
