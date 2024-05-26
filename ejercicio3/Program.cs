// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("calculadora!");

        double a;
        int b;
        double resultado;
        int operacion;
        bool continuar = true;


        while (continuar)
        {
            Console.WriteLine("Que operacion desea realizar: ?");
            Console.WriteLine("1: sumar 2: restar 3: multiplicar 4: dividir 5: valor absoluto 6: el cuadrado del numero 7: seno 8: coseno");

            string entrada = Console.ReadLine();

            operacion = int.Parse(entrada);

            Console.WriteLine("ingrese el primer numero: ");
            string entrada1 = Console.ReadLine();
            a = int.Parse(entrada1);

            Console.WriteLine("ingrese el segundo numero: ");
            string entrada2 = Console.ReadLine();
            b = int.Parse(entrada2);

            switch (operacion)
            {
                case 1:
                    resultado = a + b;
                    Console.WriteLine($"El resultado de sumar {a} y {b} es {resultado}");
                    break;

                case 2:
                    resultado = a - b;
                    Console.WriteLine($"El resultado de restar {a} y {b} es {resultado}");
                    break;
                case 3:
                    resultado = a * b;
                    Console.WriteLine($"El resultado de multiplicar {a} y {b} es {resultado}");
                    break;
                case 4:
                    if (b != 0)
                    {
                        resultado = a / b;
                        Console.WriteLine($"El resultado de dividir {a} por {b} es {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                    }

                    break;
                case 5:
                    if (a > 0)
                    {
                        resultado = a;
                        Console.WriteLine($"El valor absoluto de  {a} es {resultado}");
                        break;
                    }
                    else
                    {
                        resultado = -1 * a;
                        Console.WriteLine($"El el valor absoluto de  {a} es {resultado}");
                        break;
                    }

                case 6:
                    resultado = a * a;
                    Console.WriteLine($"El cuadrado de  {a} es {resultado}");
                    break;

                case 7:
                    resultado = Math.Sin(a * (Math.PI / 180)); // Convertir el ángulo a radianes
                    Console.WriteLine($"El seno de {a} grados es {resultado}");
                    break;
                case 8:
                    resultado = Math.Cos(a * (Math.PI / 180)); // Convertir el ángulo a radianes
                    Console.WriteLine($"El seno de {a} grados es {resultado}");
                    break;
                default:
                    Console.WriteLine("Operación no válida. Elige una opción entre 1 y 4.");
                    break;

            }
            Console.WriteLine("desea hacer otra operacion? [1:si] [2:no]");
            string entrada3 = Console.ReadLine();
            int respuesta = int.Parse(entrada3);

            if (respuesta == 2)
            {
                continuar = false;
            }

        }
        Console.WriteLine("¡Gracias por usar la calculadora! Hasta luego.");
    }
}
