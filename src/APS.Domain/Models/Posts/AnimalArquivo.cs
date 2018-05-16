using APS.Domain.Core.Models.Common;
using APS.Domain.Models.Common.Anexos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public partial class AnimalArquivo:Entity
    {

        public long IdAnimal { get; private set; }

        public virtual Animal Animal { get; private set; }

        public ArquivoFisico Arquivo { get; private set; }

    }
}
