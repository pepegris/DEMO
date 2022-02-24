import sqlite3

conn = sqlite3.connect('test.db')


cursor = conn.cursor()

#creando tabla en SQLITE con SQL y Python
cursor.execute("CREATE TABLE productos (id INTEGER PRIMARY KEY, nombre_articulo VARCHAR(50), precio INTEGER, seccion VARCHAR(20))")

####################################### insertando datos en SQLITE con SQL y Python#############################################################################################
cursor.execute("INSERT INTO productos VALUES(NULL, 'Bici', 150, 'Deportes')")
cursor.execute("INSERT INTO productos VALUES(NULL, 'Pelota', 10, 'Deportes')")
cursor.execute("INSERT INTO productos VALUES(NULL, 'Botella', 5, 'Cuidado Personal')")
cursor.execute("INSERT INTO productos VALUES(NULL, 'Jabon', 4, 'Cuidado Personal')")

#####################################insertando varios datos a la ves con EXECUTEMANY y una lista###################################################
    
varios_productos = [ ('Camiseta', 15, 'Deportes'),
                    ('Jarron', 90, 'Ceramicas'),
                    ('Camion', 500, 'Juguetes'),]

cursor.executemany("INSERT INTO productos VALUES(NULL, ?, ?, ?)", varios_productos)

######################################Consultando datos en SQLITE con SQL y Python#############################################################################################

cursor.execute("SELECT * FROM productos")

lista_productos = cursor.fetchall()


for i in lista_productos:
    print(   i[0], "Articulo:", i[1], i[2], i[3])

# Confirmar los cambios y querys
conn.commit()
conn.close()