#create class coche
class Coche():
    cosa="cosita"
    #init method constructor
    def __init__(self):
        self.__largoChasis=250
        self.__anchoChasis=120
        self.__ruedas=4
        self.__enmarcha=False

    #methods
    def estado(self):

        if self.__enmarcha:
            estado="En marcha"
        else:
            estado="Parado"

        print(f"El coche tiene {self.__ruedas} ruedas. Un ancho de {self.__anchoChasis} y un largo de {self.__largoChasis} y esta en un estado de {estado}")

    def arrancar(self):

        chequeo=self.__chequeo_interno()

        if chequeo==True:
            self.__enmarcha=True
            print("Arrancando coche", self.__enmarcha)
        else:
            print("El coche esta parado" ,self.__enmarcha)

    def __chequeo_interno(self):
        print("Realizando chequeo interno")
        self.gasolina="ok" 
        self.aceite="ok"
        self.puertas="cerradas"

        if (self.aceite== "ok" and self.aceite== "ok" and self.gasolina=="ok" and self.puertas=="cerradas"):
            return True
        else:
            return False


mi_Coche = Coche()
mi_Coche.arrancar()
mi_Coche.estado()


