def ejer1():
    print("******BIENVENIDO USUARIO******")
    precio = float(input("\nIngrese el precio unitario del producto: "))
    
    print("\nIngrese su código de descuento:\n[1] Estudiante \n[2] Empleado \n[3] Cliente Frecuente ")
    código = int(input("\nOpción: "))

    if (precio >= 0):
        if (código >= 1 and código <= 3):
            if (código == 1):
                descuento = precio * 0.1
            elif (código == 2):
                descuento = precio * 0.15;
            else:
                descuento = precio * 0.2;
        else:
            print("\nCÓDIGO INVÁLIDO.");
            descuento = 0

        monto_i = precio - descuento

        if(precio >500):
            adicional = monto_i *0.05
        else:
            adicional = 0

        pago_f = monto_i - adicional

        print(f"\nMonto final (con descuento): {pago_f:.2f}")
    
    else:
        print("\nPRECIO INVÁLIDO")

import math
def ejer2():
    nota = int(input("Ingrese una nota (0-20): "))

    if (nota >= 0 and nota <= 20):
        match nota:
            case n if 0 <= n <= 10:
                print("\nDesaprobado")
            case n if 11 <= n <= 13:
                print("\nRegular")
            case n if 14 <= n <= 17:
                print("\nBueno")
            case _:
                print("\nExcelente")
        
        if (nota >= 14 and nota % 2 == 0):
            print("\nBuen desempeño con nota par")
        
        if (nota < 11 or nota % 2 != 0):
            print("\nNecesita reforzar")

        print(f"\nRaíz cuadrada de nota: {math.sqrt(nota):.1f}")
        print(f"Potencia elevada al cubo: ", math.pow(nota, 3))

    else:
       print("\n RANGO DE NOTA INVÁLIDO")

ejer1()
