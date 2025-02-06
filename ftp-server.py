from pyftpdlib.authorizers import DummyAuthorizer
from pyftpdlib.handlers import FTPHandler
from pyftpdlib.servers import FTPServer

# Crea un administrador de usuarios "virtuales"
authorizer = DummyAuthorizer()
# Agrega un usuario con permisos de lectura y escritura.
# Cambia 'user', '12345' y la ruta '/ruta/a/tu/directorio' por los que prefieras.
authorizer.add_user("CONFIDENTIAL", "", "C:/Users/Administracion/Documents/DatosZummy", perm="elradfmwMT")
# Opcionalmente, puedes habilitar un usuario anónimo (lectura, por ejemplo)
# authorizer.add_anonymous("/ruta/a/tu/directorio", perm="elr")

# Configura el manejador FTP y asigna el administrador de usuarios
handler = FTPHandler
handler.authorizer = authorizer

# Banner opcional que se muestra al conectar
handler.banner = "Bienvenido a mi servidor FTP de pruebas."

# Configura el servidor FTP en la dirección y puerto deseados
address = ("127.0.0.1", 2121)  # Utilizo 2121 para evitar problemas de permisos en el puerto 21
server = FTPServer(address, handler)

# Inicia el servidor
server.serve_forever()