using APS.Application.ViewModel.Usuario;
using MvcMusicStore.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Application.Interfaces
{
    public interface IUsuarioAppService:IDisposable
    {
        void Cadastrar(CadastroViewModel cadastroViewModel);
        string OlaPutedo();
    }
}
