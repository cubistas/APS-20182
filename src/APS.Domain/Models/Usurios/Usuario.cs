using APS.Domain.Core.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Usurios
{
    public sealed class Usuario : Entity
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
    }
}
