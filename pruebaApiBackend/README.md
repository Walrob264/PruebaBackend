
# ESTA APLICACIÓN ES UNA API RESTful

Los pasos para que funcione correctamente son los siguientes pasos:

--Tiens que tener SQL funcionando en todo momento

PASOS: 

# 1. Actualizar el archivo appsettings.json:
 - Abre el archivo appsettings.json en tu proyecto.
 - Localiza el apartado "ConnectionStrings".
 - Cambia el valor de "PruebaDB" por la cadena de conexión a tu base de datos SQL Server.  

# 2. Migraciones y Actualización de la Base de Datos:
  - En tu consola de administrador de paquetes(que si no lo ves, Se encuentra en la parte superior donde dice "Ver" luego "Otras Ventanas" y buscas la opción)










```bash
  add-migration "Create Products Table"
```

- cuando todo de ok, seguimos con la siguiente linea de codigo 


```bash
  Update-Database -Verbose
```

# 3. Ejecuta la aplicacion 

  - Puedes ejecutar la aplicacion en Visual studio con "F5"

