﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS.Domain.Core.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        bool Commit();
    }
}
