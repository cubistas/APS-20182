﻿using APS.Application.ViewModel.Posts;
using MvcMusicStore.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.Interfaces
{
    public interface IPostAppService:IDisposable
    {
        void Cadastrar(CadastroViewModel cadastroViewModel);
        void Remover(long id);
        ICollection<CadastroViewModel> BuscarTodos();
        void Atualizar(CadastroViewModel cadastroViewModel);
        CadastroViewModel BuscarPorId(long id);
    }
}
