
i=1

while i <=10:
    print(f"Ejecucion numero : {i}")
    i+=1
    try:
        if i == 50:
            raise Exception("Error")
    except Exception as e:
        print(e)
        break

numero=int(input("Ingrese un numero: "))
numero2=int(input("Ingrese otro numero: "))

opracion=input("Ingrese la operacion que desea realizar: ")

def operaciones(numero,numero2,opracion):
    if opracion == "+":
        return numero+numero2
    elif opracion == "-":
        return numero-numero2
    elif opracion == "*":
        return numero*numero2
    elif opracion == "/":
        try:
            return numero/numero2
        except ZeroDivisionError:
            return "No se puede dividir entre 0"
    else:
        return "Operacion no valida"

print (operaciones(numero,numero2,opracion))