using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Models.Posts
{
    public enum eStatusPost
    {
        [Description("Criação")]
        Criacao = 1,
        [Description("Pendente")]
        Pendente = 2,
        [Description("Adotado")]
        Adotado = 3,
        [Description("Cancelado")]
        Cancelado = 4,
    }
}
