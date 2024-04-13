using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9_herencia.ClaseHija
{
    internal class Nintendo :Cls
    {
        public bool EsPortatil { get; set; }

        public string MostrarDetallesNintendo()
        {
            MostrarDetalle();
            return $"Es portatil: {EsPortatil}";

        }
    }   
}
