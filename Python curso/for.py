
name_tuples=("Juan", "Pedro", "Maria", "Jose", "Luis", "Carlos")
correo="prueba@gmail.com"

for i in correo:
    if i == "@":
        print("El correo es: ", correo)
        break
    else:
        print("El correo no es valido")
        break


#for i in range(1, len(name_tuples)):
#    print(name_tuples[i])