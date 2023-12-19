using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasTecnicas
{
    public class ResultadoMaxArea()
    {
        public int SuperficieContenedor { get; set; } = 0;
    }
    internal class MaxArea
    {
        private int[] height { get; }

        public MaxArea(int[] height)
        {
            this.height = height;
        }

        public ResultadoMaxArea Contenedor()
        {
            ResultadoMaxArea resultadoMaxArea = new ResultadoMaxArea();
            /*
             * Si tenemos que hacer un contenedor con un array
             * necesitamos dos paredes una izquierda y una derecha
             * la derecha tenemos que añadir -1 ya que el array 
             * empieza en 0
             */
            int _izquierda = 0;
            int _derecha = height.Length - 1;
            /*
             * El ancho de puede calcular restando derecha y izquieda
             */
            int _base = 0;
            /*
             * Base*Altura
             */
            int _alturaContenedor = 0;
            while (_izquierda < _derecha)
            {
                _base = _derecha - _izquierda;
                /*
                 * Para determinar la altura del contenedor, debemos coger
                 * la que tenga menor altura, ya que si usamos Math.Max
                 * la barra mas pequeña hará que se desborde, desaprovechando
                 * la altura de la barra mas grande
                 */
                _alturaContenedor = Math.Min(height[_izquierda], height[_derecha]);
                resultadoMaxArea.SuperficieContenedor = Math.Max(resultadoMaxArea.SuperficieContenedor, _base * _alturaContenedor);

                /*
                 * Cambiamos las posiciones del array
                 * Debemos tener en cuenta que
                 * _izquierda empieza en la posicion 0
                 * mientras que _derecha empieza en
                 * la posicion tamaño array -1
                 */
                if (height[_izquierda] < height[_derecha])
                {
                    _izquierda++;
                }
                else
                {
                    _derecha--;
                }
            }
            return resultadoMaxArea;
        }
    }
}
