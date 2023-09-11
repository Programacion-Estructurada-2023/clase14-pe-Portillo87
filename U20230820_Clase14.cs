using System;

namespace MyApp// Note: EJERCICIO PRACTICO CLASE 14.
{
    internal class Program
    {
         static void Main(string[] args)
        {
          //DECLARACION DE VARIABLE INT PARA OPCIONES.

          int Opciónes;

          do
          {
            Console.WriteLine("\n**************Menú de opciones:****************");
            Console.WriteLine("\n1.Realizar mediante un for, una función que sume los números pares hasta el 75");
            Console.WriteLine("\n2.Realizar mediante un foreach el recorrido de una lista de 9 números enteros y que encuentre el número más grande.");
            Console.WriteLine("\n3.Realizar un programa mediante un for, la representación de una tabla demultiplicar de un numero n, del 1 al 12 y que al valor de “n x i” le sume 2.");
            Console.WriteLine("\n4.Opción para salir del programa.");
            Console.Write("\n************Ingrese su eleccion [1,4]************\n");
        
            if (int.TryParse(Console.ReadLine(), out Opciónes))
                {
                    switch (Opciónes)
                    {
                        case 1:
                            int suma = 0;
                            for (int i = 2; i <= 75; i += 2)
                            {
                                suma += i;
                            }
                            Console.WriteLine($"\nSuma de todos los numeros pares es: {suma}");
                            break;
                        case 2:
                            List<int> numeros = new List<int> { 5, 10, 25, 8, 2, 30, 15, 40, 12, };
                            int maximos = numeros[0];
                            foreach (int num in numeros)
                            {
                                if (num > maximos)
                                {
                                    maximos = num;
                                }
                            }
                            Console.WriteLine("\nEncontrar el numero mas grande de la lista  > " + maximos);
                            break;
                        case 3:
                            Console.WriteLine("\nIngrese un numero para elaborar la tabala de multiplicar");
                            int numero = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= 12; i++)
                            {
                                int multiplicacion = numero * i;
                                Console.WriteLine($"{numero} x {i} = {multiplicacion} + {2} = {multiplicacion + 2}");
                            }
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("\nOpcion no valida. Por favor ingrese una opcion valida");
                            break;
                    }
                 
                }
                else
                {
                    Console.WriteLine("\nEntrada no valida. Debe ingresar un numero (1-4)\n");
                }

            } while (Opciónes != 4);
        
        }
    }
}