﻿using APS.Domain.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Interfaces.Service
{
    public interface IUsuarioService: IServiceCRUD<Models.Usurios.Usuario>
    {
        string Mensagem();
    }
}
