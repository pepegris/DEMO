#create class vehiculo
class Vehiculo():
    def __init__(self, color, ruedas):
        self.color=color
        self.ruedas=ruedas
        self.__enmarcha=False
    
    def estado(self):
        if self.__enmarcha:
            estado="En marcha"
        else:
            estado="Parado"
        print(f"El vehiculo tiene {self.ruedas} ruedas. Un color de {self.color} y esta en un estado de {estado}")
    
    def arrancar(self):
        self.__enmarcha=True
        print("Arrancando vehiculo", self.__enmarcha)
    
    def estacionar(self):
        self.__enmarcha=False
        print("Estacionando vehiculo", self.__enmarcha)

class Moto(Vehiculo):
    pass

mi_Moto = Moto("Rojo", 2)
mi_Moto.arrancar()