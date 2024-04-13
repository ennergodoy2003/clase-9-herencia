using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9_herencia.ClaseHija
{
    internal class PlayStation : ClsConsola

    
    {
        public string ModeloControlador { get; set; }
        public string MostrarDetallesPS ()

        {
            MostrarDetalles();
            return $"Modelo de Controlador:{ModeloControlador}";
        }

    }

}
