using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class empresa : cliente
    {
        Boolean autorizacion;

        public empresa(string mitipo, Boolean miautorizacion)
            : base(mitipo)
        {
            miautorizacion = autorizacion;
        }
    }
}
