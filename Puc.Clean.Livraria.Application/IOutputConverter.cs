using System;
using System.Collections.Generic;
using System.Text;

namespace Puc.Clean.Livraria.Application
{
    public interface IOutputConverter
    {
        T Map<T>(object source);
    }
}
