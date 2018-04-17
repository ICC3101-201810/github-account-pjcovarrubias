using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class persona : cliente
    {
        Boolean licenciaconducir;

        public persona(string mitipo, Boolean milicenciaconducir)
            : base(mitipo)
        {
            milicenciaconducir = licenciaconducir;
        }
    }
}
