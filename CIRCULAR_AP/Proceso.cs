using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCULAR_AP
{
    class Proceso
    {
        Random rt = new Random(DateTime.Now.Second);

        public int ProcesoSan ()
        {
            return rt.Next(4,15);
        }
    }
}
