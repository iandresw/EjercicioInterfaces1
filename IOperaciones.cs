using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    internal interface IOperaciones
    {
        /// <summary>
        /// Area del circulo
        /// </summary>
        /// <returns>double area del circulo</returns>
        public double AreaCirculo();
        /// <summary>
        /// calcula la longitud del circulo
        /// </summary>
        /// <returns>Longitud o perimetro del circulo</returns>
        public double longitudCirculo();
        /// <summary>
        /// calcula la area dela superficie de la esfera
        /// </summary>
        /// <returns>area de la superficie del esfera</returns>
        public double AreaSuperficie();
        /// <summary>
        /// calcula el volumen de la esfera
        /// </summary>
        /// <returns> volumen del esfera</returns>
        public double VolumenEsfera();
        /// <summary>
        /// calcula la longitud del arco del circulo
        /// </summary>
        /// <returns>longitud del arco del circulo</returns>
        public double LongitudArco();

    }
}
