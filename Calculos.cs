using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal class Calculos : IOperaciones
    {
        public double radio;
        public double angulo;
        public double AreaCirculo()
        {
            return radio * radio * 3.14;
        }
        public double longitudCirculo()
        {
            return 2*radio*3.14;
        }

        public double AreaSuperficie()
        {
            return 4 * 3.13 * radio * radio;
        }

        public double VolumenEsfera()
        {
            return (4 / 3) * 3.14 * radio * radio * radio;
        }
        public double LongitudArco()
        {
            return (angulo / 360) * 2 * 3.14 * radio;
        }

        public void Imprimir()
        {
            Console.WriteLine($"-------COMENZAMOS---------");
            Console.WriteLine($"El Area del circulo con  radio: {radio} es:{AreaCirculo()}");
            Console.WriteLine($"La longitud del circulo con radio: {radio} es:{longitudCirculo()}");
            Console.WriteLine($"El Area de la superficie de la esfera con radio: {radio} es:{AreaSuperficie()}");
            Console.WriteLine($"La Longitud del Arco del circulo con radio: {radio} y angulo : {angulo} es:{AreaCirculo()}");
            Console.WriteLine($"El Volumen de la esfera con {radio} es:{VolumenEsfera()}");
            Console.WriteLine($"-------ESO ES TODO---------");
        }
    }
}
