def ejer1():
    print("******BIENVENIDO USUARIO******")
    precio = float(input("\nIngrese el precio unitario del producto: "))
    
    print("\nIngrese su código de descuento:\n[1] Estudiante \n[2] Empleado \n[3] Cliente Frecuente ")
    código = int(input("\nOpción: "))

    if (precio >= 0):
        match código:
            case 1:
                descuento = precio * 0.1
            case 2:
                descuento = precio * 0.15
            case 3:
                descuento = precio * 0.2
            case _:
                print("\nCÓDIGO INVÁLIDO.")

        monto_i = precio - descuento

        if(precio >500):
            adicional = monto_i *0.05

        pago_f = monto_i - adicional

        print(f"\nMonto final (con descuento): {pago_f:.2f}")
    else:
        print("PRECIO INVÁLIDO")

ejer1()
