using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1- Elegir una cancion 
            

            Console.WriteLine("\n---PLAYLIST DE CANCIONES---");
            string [] playlist = {"After Love", "Crazy", "Kiss me", "Love me", "Gime me love"};
            foreach (string cancion in playlist)
            {

                Console.WriteLine("Que cancion es?: " + cancion);

            }

            Console.WriteLine("\nPresione ENTER Para cerrar");
            Console.ReadLine();

            //Ejercicio 2 - Elegir una fruta 
            string[] frutas = { "Manzana", "Banana", "Naranja", "Pera", "Uva" };
            double[] precios = { 100.00, 50.00, 25.00, 10.00, 5.00 };

            int i = 0;

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta + " cuesta $" + precios[i]);
                i++;
            }

                Console.WriteLine("\nPresione ENTER Para cerrar");
                Console.ReadLine();

                // Ejercicio 3 - Mostrar inventario 
                Console.WriteLine("\n---INVENTARIO---");

                string [] inventario = {"escudo", "espada", "casco", "armadura", "botas"};

                foreach (string item in inventario)
                {
                    Console.WriteLine("Item en inventario: " + item);

                }
                
                    Console.WriteLine("\nPresione ENTER Para cerrar");
                    Console.ReadLine();

                    //Ejercicio 4. Notas de alumnos. Sin aumentar if- else if- else

                    Console.WriteLine("\n---NOTAS DE ALUMNOS---");

                    double [] notas = {10.00, 6.55, 8.75, 9.00, 7.25, 5.50, 4.00, 3.25, 2.00, 1.00};

                    foreach (double nota in notas)
                    {
                        Console.WriteLine("Nota del alumno: " + nota);
                    }

                    Console.WriteLine("\nPresione ENTER Para cerrar"); 
                    Console.ReadLine();

                    //Ejercicio 5. Gol en un partido de futbol. Sin aumentar if- else if- else
                    Console.WriteLine("\n---GOLES EN UN PARTIDO DE FUTBOL---");

                    int [] goles = {6, 7, 2, 1, 0, 11, 4};

                    foreach (int gol in goles)
                    {
                        Console.WriteLine("Cantidad de goles: " + gol);
                    }

                    Console.WriteLine("\nPresione ENTER Para cerrar");
                    Console.ReadLine();

            }
        
        }
    }