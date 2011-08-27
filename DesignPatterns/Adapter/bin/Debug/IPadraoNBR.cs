using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public interface IPadraoNBR
    {
        string Nome { get; set; }
        void Conect();
        void Desconect();
    }
}
