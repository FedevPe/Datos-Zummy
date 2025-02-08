from pyftpdlib.authorizers import DummyAuthorizer
from pyftpdlib.handlers import FTPHandler
from pyftpdlib.servers import FTPServer


authorizer = DummyAuthorizer()

#Añade un usuario del servidor
authorizer.add_user("CONFIDENTIAL", "", "C:/Users/Administrador/Documents/DatosZummy", perm="elradfmwMT")


# Configura el manejador FTP y asigna el administrador de usuarios
handler = FTPHandler
handler.authorizer = authorizer

# Configura el servidor FTP en la dirección y puerto deseados
address = ("127.0.0.1", 2121)  # Utilizo 2121 para evitar problemas de permisos en el puerto 21
server = FTPServer(address, handler)

# Inicia el servidor
server.serve_forever()