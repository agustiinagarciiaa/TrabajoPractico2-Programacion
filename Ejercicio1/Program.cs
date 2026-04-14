using System;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1. Posicion de lugar en un juego
            Console.WriteLine("\n---POSICION DE LUGAR EN UN JUEGO ---");

            int [] posiciones = new int[5];

            posiciones[0] = 3;
            posiciones[1] = 5;
            posiciones[2] = 2;
            posiciones[3] = 1;
            posiciones[4] = 4;

            Console.WriteLine("Jugador 1 esta en posicion: " + posiciones[0]);
            Console.WriteLine("Jugador 2 esta en posicion: " + posiciones[1]);
            Console.WriteLine("Jugador 3 esta en posicion: " + posiciones[2]);
            Console.WriteLine("Jugador 4 esta en posicion: " + posiciones[3]);
            Console.WriteLine("Jugador 5 esta en posicion: " + posiciones[4]);  

            Console.WriteLine("\nPresione ENTER Para cerrar");
            Console.ReadLine();

            //Ejercicio 2. Notas de alumnos 

            Console.WriteLine("\n---NOTAS DE ALUMNOS---");

                int [] notas = new int[10];

                notas[0] = 10;
                notas[1] = 8;
                notas[2] = 9;
                notas[3] = 7;
                notas[4] = 6;
                notas[5] = 5;
                notas[6] = 4;
                notas[7] = 3;
                notas[8] = 2;
                notas[9] = 1;

                Console.WriteLine("Alumno 1 tiene una nota de: " + notas[0]);
                Console.WriteLine("Alumno 2 tiene una nota de: " + notas[1]);
                Console.WriteLine("Alumno 3 tiene una nota de: " + notas[2]);
                Console.WriteLine("Alumno 4 tiene una nota de: " + notas[3]);
                Console.WriteLine("Alumno 5 tiene una nota de: " + notas[4]);
                Console.WriteLine("Alumno 6 tiene una nota de: " + notas[5]);
                Console.WriteLine("Alumno 7 tiene una nota de: " + notas[6]);
                Console.WriteLine("Alumno 8 tiene una nota de: " + notas[7]);
                Console.WriteLine("Alumno 9 tiene una nota de: " + notas[8]);
                Console.WriteLine("Alumno 10 tiene una nota de: " + notas[9]);

                Console.WriteLine("\nPresione ENTER Para cerrar");
                Console.ReadLine();

                //Ejercicio 3. Buscar un numero 

                Console.WriteLine("\n---BUSCAR UN NUMERO---");

                int [] numeros = new int[5];

                numeros[0] = 40;
                numeros[1] = 20;
                numeros[2] = 10;
                numeros[3] = 0; 
                numeros[4] = 30;

                bool encontrado = false;

                //Utilice if- else if - else para seguir un poco del concepto. 
                Console.WriteLine("Ingrese un numero para buscar: ");
                int numeroBuscado = int.Parse(Console.ReadLine());

                if (numeroBuscado == numeros [0]) 
                {
                    encontrado = true;
                    Console.WriteLine("Numero encontrado en la posicion 0");
                }
                else if (numeroBuscado == numeros [1]) 
                {
                    encontrado = true;
                    Console.WriteLine("Numero encontrado en la posicion 1");
                }
                else if (numeroBuscado == numeros [2]) 
                {
                    encontrado = true;
                    Console.WriteLine("Numero encontrado en la posicion 2");
                }
                else if (numeroBuscado == numeros [3]) 
                {
                    encontrado = true;
                    Console.WriteLine("Numero encontrado en la posicion 3");
                }
                else if (numeroBuscado == numeros [4]) 
                {
                    encontrado = true;
                    Console.WriteLine("Numero encontrado en la posicion 4");
                } else 
                {
                 
                 encontrado = false;
                    Console.WriteLine("Numero no encontrado en el arreglo");

                }

                    Console.WriteLine("\nPresione ENTER Para cerrar");
                    Console.ReadLine();

                //Ejercicio 4 . Buscar inicial de apellido en un arreglo

                Console.WriteLine("\n---BUSCAR INICIAL DE APELLIDO EN UN ARREGLO---");

                string [] iniciales = new string[5];

                iniciales[0] = "A";
                iniciales[1] = "B";
                iniciales[2] = "C";
                iniciales[3] = "D"; 
                iniciales[4] = "E";

                bool encontradoInicial = false; 
                Console.WriteLine("Ingrese una inicial de apellido para buscar: ");
                string inicialBuscada = Console.ReadLine();
                
                //Utilice if- else if- else para familiriarizarse un poco mas con el concepto.
                    if (inicialBuscada == iniciales [0]) 
                    {
                        encontradoInicial = true;
                        Console.WriteLine("Inicial encontrada en la posicion 0");
                    }
                    else if (inicialBuscada == iniciales [1]) 
                    {
                        encontradoInicial = true;
                        Console.WriteLine("Inicial encontrada en la posicion 1");
                    }
                    else if (inicialBuscada == iniciales [2]) 
                    {
                        encontradoInicial = true;
                        Console.WriteLine("Inicial encontrada en la posicion 2");
                    }
                    else if (inicialBuscada == iniciales [3]) 
                    {
                        encontradoInicial = true;
                        Console.WriteLine("Inicial encontrada en la posicion 3");
                    }
                    else if (inicialBuscada == iniciales [4]) 
                    {
                        encontradoInicial = true;
                        Console.WriteLine("Inicial encontrada en la posicion 4");
                    } else 
                    {
                    
                     encontradoInicial = false;
                        Console.WriteLine("Inicial no encontrada en el arreglo");

                    } 
                    Console.WriteLine("\nPresione ENTER Para cerrar");
                    Console.ReadLine();

                    //Ejercicio 5. Buscar nombres en un arreglo

                    Console.WriteLine("\n---BUSCAR NOMBRES EN UN ARREGLO---");

                    string [] nombres = new string[3];

                    nombres[0] = "Franco";
                    nombres[1] = "Agustina";
                    nombres[2] = "Oscar";

                    bool encontradoNombre = false;
                    Console.WriteLine("Ingrese un nombre para buscar: ");
                    string nombreBuscado = Console.ReadLine();

                    //Utilice if- else if- else 
                    if (nombreBuscado == nombres [0]) 
                    {
                        encontradoNombre = true;
                        Console.WriteLine("Nombre encontrado en la posicion 0");
                    }
                    else if (nombreBuscado == nombres [1]) 
                    {
                        encontradoNombre = true;
                        Console.WriteLine("Nombre encontrado en la posicion 1");
                    }
                    else if (nombreBuscado == nombres [2]) 
                    {
                        encontradoNombre = true;
                        Console.WriteLine("Nombre encontrado en la posicion 2");
                    } else 
                    {
                    
                     encontradoNombre = false;
                        Console.WriteLine("Nombre no encontrado en el arreglo");

                    }

                    Console.WriteLine("\nPresione ENTER Para cerrar");
                    Console.ReadLine();
            
        }
    }
}

