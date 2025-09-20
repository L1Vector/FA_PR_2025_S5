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

            //Inicio de Condicional Doble (precio) y Múltiple (código)
            if (precio >= 0)
            {
                switch (código)
                {
                    case 1:
                        descuento = precio * 0.1;
                        break;
                    case 2:
                        descuento = precio * 0.15;
                        break;
                    case 3:
                        descuento = precio * 0.2;
                        break;
                    default:
                        Console.WriteLine("\nCÓDIGO INVÁLIDO.");
                        break;
                }

                monto_i = precio - descuento;

                if (precio > 500)
                    adicional = monto_i * 0.05;

                pago_f = monto_i - adicional;

                Console.WriteLine($"\nMonto final (con descuento): {pago_f:F2}");
            }
            else
            {
                Console.WriteLine("PRECIO INVÁLIDO");
            }
        }

    }
}
