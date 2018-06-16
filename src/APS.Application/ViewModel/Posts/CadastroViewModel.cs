using APS.Domain.Models.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.ViewModel.Posts
{
    public class CadastroViewModel
    {
        public long Id { get; set; }

        public int Latitude { get; set; }

        public int Longitude { get; set; }

        public DateTime DataCriacao { get; set; }

        public long IdUsuario { get; set; }

        public eStatusPost Status { get; set; }

        public string[] ListaTags { get; set; }

        public AnimalViewModel Animal { get; set; }

        public ICollection<CurtidaViewModel> Curtidas { get; set; }
    }
}
