using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5Ficheros.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuPrincipal()
        {
            int opcion;
            Console.WriteLine("################################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Modificar una linea especifica");
            Console.WriteLine("2. Modificar una posicion especifica");
            Console.WriteLine("################################");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}
