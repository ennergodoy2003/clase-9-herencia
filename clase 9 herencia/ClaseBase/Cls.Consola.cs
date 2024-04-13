
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_9_herencia.ClaseBase
{
    internal class Cls
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine{$"Marca:{Marca},anio de lanzamiento:{AnioLanzamiento}")};

    }
}
