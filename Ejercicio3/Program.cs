using System;
using System.Data;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Ejercicio 1 - Puntos de un juego 
       Console.WriteLine("\n---PUNTOS DE UN JUEGO---");

        int [] puntos = {250, 300, 350, 400, 450};
        int cantidadPuntos = puntos.Length;

        Console.WriteLine("Cantidad de elementos en el array: " + cantidadPuntos);
        Console.WriteLine("_______________________");
        for (int i = 0; i < puntos.Length; i++)
        {
            Console.WriteLine("Puntos del jugador " + (i + 1) + ": " + puntos[i]);
        }

        //Ejercicio 2 - Nombres de ciudades 
        Console.WriteLine("\n---CIUDADES---");

        string [] ciudades = {"Buenos Aires", "Córdoba", "Rosario", "Mendoza", "La Plata"};
        int cantidadCiudades = ciudades.Length;

        Console.WriteLine("Cantidad de elementos en el array: " + cantidadCiudades);
        Console.WriteLine("_______________________");

        for (int i = 0; i < ciudades.Length; i++)
        {
            Console.WriteLine("Ciudad " + (i + 1) + ": " + ciudades[i]);
        }


        //Ejercicio 3 - Edades
        Console.WriteLine("\n---EDADES---");

        int [] edades = {25, 30, 35, 40, 45};
        int cantidadElementos = edades.Length;

        Console.WriteLine("Cantidad de elementos en el array: " + cantidadElementos);
        Console.WriteLine("_______________________");
        for (int i = 0; i < edades.Length; i++)
        {
            Console.WriteLine("Edad " + (i + 1) + ": " + edades[i]);

        }
    
        //Ejercicio 4 - Libreria 
        Console.WriteLine("\n---LIBRERIA---");

        string [] libros = {"El Quijote", "Cien años de soledad", "El Principito", "Matar a un ruiseñor", "1984"};

        Console.WriteLine("Cantidad de elementos en el array: " + libros.Length);
        Console.WriteLine("_______________________");
        
        for (int i = 0; i < libros.Length; i++)
        {
            Console.WriteLine("Libro " + (i + 1) + ": " + libros[i]);

        }

        //Ejercicio 5 - Precios de productos

        Console.WriteLine("\n---PRECIOS DE PRODUCTOS---");

        double [] precios = {19.99, 29.99, 39.99, 49.99, 59.99};
        int cantidadPrecios = precios.Length;

        Console.WriteLine("Cantidad de elementos en el array: " + cantidadPrecios);
        Console.WriteLine("_______________________");

        for (int i = 0; i < precios.Length; i++)
        {
            Console.WriteLine("Precio del producto " + (i + 1) + ": $" + precios[i]);
        }

        Console.WriteLine("\nPresione ENTER Para cerrar");
        Console.ReadLine();
       
    }
  }
}