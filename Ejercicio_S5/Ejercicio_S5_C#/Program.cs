using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_S5_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey();
        }
        static void ejer1()
        {
            double precio, descuento = 0, pago_f, monto_i, adicional = 0;

            //Solicitamos al usuario precio y código de descuento
            Console.WriteLine("*********BIENVENIDO USUARIO*********");
            Console.Write("\nIngrese el precio unitario del producto: ");
            precio = double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese su código de descuento:\n[1] Estudiante \n[2] Empleado \n[3] Cliente Frecuente ");
            Console.Write("\nOpción: ");
            int código = int.Parse(Console.ReadLine());

            //Inicio de Condicional Doble (precio y código)
            if (precio >= 0)
            {
                if (código >= 1 && código <= 3)
                {
                    if (código == 1)
                    {
                        descuento = precio * 0.1;
                    }
                    else if (código == 2)
                    {
                        descuento = precio * 0.15;
                    }
                    else 
                    {
                        descuento = precio * 0.2;
                    }
                }
                else
                {
                    Console.WriteLine("\nCÓDIGO INVÁLIDO.");
                }

                monto_i = precio - descuento;

                if (precio > 500)
                    adicional = monto_i * 0.05;

                pago_f = monto_i - adicional;

                Console.WriteLine($"\nMonto final (con descuento): {pago_f:F2}");
            }
            else
            {
                Console.WriteLine("\nPRECIO INVÁLIDO");
            }
        }
        static void ejer2()
        {
            Console.Write("Ingrese una nota (0-20): ");
            int nota = int.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 20)
            {
                switch (nota)
                {
                    case int n when (nota >= 0 && nota <= 10):
                        Console.WriteLine("\nClasificación: Desaprobado.");
                        break;
                    case int n when (nota >= 11 && nota <= 13):
                        Console.WriteLine("\nClasificación: Regular.");
                        break;
                    case int n when (nota >= 14 && nota <= 17):
                        Console.WriteLine("\nClasificación: Bueno.");
                        break;
                    default:
                        Console.WriteLine("\nClasificación: Excelente.");
                        break;
                }
                if (nota >= 14 && nota % 2 == 0)
                    Console.WriteLine("\nCondición: Buen desempeño con nota par");

                if (nota < 11 || nota % 2 != 0)
                    Console.WriteLine("\nCondición: Necesita reforzar");

                Console.WriteLine($"\nRaíz cuadrada de nota: {Math.Sqrt(nota):F1}");
                Console.WriteLine("Potencia elevada al cubo: " + Math.Pow(nota, 3));
            }
            else { Console.WriteLine("\n RANGO DE NOTA INVÁLIDO"); }
        }
    }
}