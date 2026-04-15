Solucion de clase - 14/04/2024

using System;

namespace Programa
{
    class Program
    {
        static void Main (string [] args)
        {

            //Ejercicio
            Console.WriteLine("\n---Entrada de un boliche");

            //Estos son los arrays con los que almaceno los nombre y las edades de las personas 
            string [] nombres = new string [20];
            int [] edad = new int [20];

            //Utilice un for para recorrer los arrays y asi vayan cargando los datos
            for(int i = 0; i < 20; i++)
            {

            //No vuelvo a crear variables, pongo directamente los arrays que hice al principio.

            //Tambien quiero aclarar que utilizo el en los "Console.ReadLine!" para decirle al codigo que no es null pero podria serlo
                Console.WriteLine("Ingrese su nombre, porfavor!");
                nombres[i]=Console.ReadLine()!;

                Console.WriteLine("Ingrese su edad: ");
                edad[i] = int.Parse(Console.ReadLine()!);
            /*Utilizo un if y else para darle una condicion de que si el array de mi edad es menor de 20 
            pero 
            no puede ingresar al boliche pero si es mayor de 20 puede ingresar */
                if (edad[i] < 20) 
                {
                    Console.WriteLine(nombres[i] + "  Porfavor vuelva a su casa, cuidese! <3");
        
                } else if (edad[i] > 60)
                {
                    Console.WriteLine(nombres[i] + "  Porfavor vuelva a su casa o al cajon! <3");
                }
                 else
                {
                    Console.WriteLine(nombres[i] + "  Disfrute de la noche!");
                }

            }

                Console.WriteLine("\nPresione ENTER para cerrar");
                Console.ReadLine();
        }
    }
}
