using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.ViewModel.Posts
{
    public class AnimalViewModel
    {
        

        public AnimalViewModel() {  }
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Tipo { get; set; }

        public string Raca { get; set; }

        public string Descricao { get; set; }

        public decimal Kilos { get; set; }

        public virtual ICollection<AnimalArquivoViewModel> ImagensAnimal { get; set; }

    }
}
