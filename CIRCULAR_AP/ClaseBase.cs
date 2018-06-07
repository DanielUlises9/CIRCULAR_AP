using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCULAR_AP
{
    class ClaseBase
    {
        private int dato;

        public int Dato
        {
            get { return dato; }
            set => dato = value;
        }
        ClaseBase siguiente;
        public ClaseBase Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        ClaseBase anterior;
        public ClaseBase Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public ClaseBase (int dato)
        {
            this.dato = dato;
        }

    }
}
