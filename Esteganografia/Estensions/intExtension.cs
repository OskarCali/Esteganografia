using System;
using System.Linq;

namespace Esteganografia.Estensions
{
    public static class intExtension
    {
        /// <summary>
        ///     Cambia una secuencia de bit al reves
        /// </summary>
        /// <param name="num">Numero a cambiar secuencia</param>
        /// <returns>Nuevo numero con la secuencia al reves</returns>
        public static int ReverseBits(this int num)
        {
            var bins = Convert.ToString(num, 2);
            var bins2 = bins.Reverse().ToArray();
            var res = new string(bins2).PadRight(8, '0');

            return Convert.ToInt32(res, 2);
        }
    }
}