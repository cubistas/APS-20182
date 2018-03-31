using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Core.Exception
{
    public class ServiceException:SystemException
    {

        public IEnumerable<string> Mesagens { get; protected set; }

        public ServiceException(string mensagem):base(mensagem)
        {
            this.Mesagens = Enumerable.Empty<string>(); 
        }
    }
}
