# UsuariosDelCampo

 
Crear una base de datos que lleve por nombre EjemploBD.
Dentro de la base EjemploBD crear una Tabla con nombre Usuarios.
La tabla Usuarios tendrá las siguientes columnas:
-	ID: INT IDENTITY (autoincrementable)
-	Nombre: nvarchar(50)
-	FechaNacimiento: DateTime
-	Direccion: nvarchar(100)
-	Nacionalidad: nvarchar(30)
-	Sexo: nvarchar(1)
-	RutaImagen: nvarchar(100)
-	Activo: bit
-	FechaActualizacion: DateTime

Al iniciar pantalla
Al iniciar la pantalla deberá aparecer el CheckBox de Activo de forma seleccionada, el combo Nacionalidad deberá tener precargados las siguientes nacionalidades: Mexicana, Estadounidense, Canadiense, Otro. Para el RadioButton de Sexo deberá aparecer seleccionado el de Masculino y los demás campos deberán estar vacíos.
Al dar clic en el botón Limpiar deberá inicializar los campos igual que al iniciar pantalla.

Dar de Alta nuevo usuario
Al dar de alta un nuevo usuario no será necesario capturar un “ID”, sin embargo, todos los demás campos serán obligatorios excepto la “ruta de la imagen”.
Al dar clic en el botón de Subir Imagen se deberá abrir una pantalla de Selección de Archivo (OpenFileDialog), al seleccionar el archivo de imagen deseado se deberá mostrar en el control PictureBox, la ruta del archivo seleccionado se guardará en el campo “RutaImagen” de la tabla “Usuarios”.
Al presionar el botón Guardar se deberá guardar en la tabla “Usuarios” los datos capturados, el “ID” se generará automáticamente al insertar el registro, para el campo “Sexo” guardar solamente la letra M para masculino o F para femenino, el campo “FechaActualizacion” se guardará la fecha actual con la función GETDATE().
Después de guardar el registro deberá retornar el “ID” que se generó con un mensaje  y después limpiar la pantalla al estado de inicio.
 


Consulta de Usuario
Para consultar un Usuario existente se capturará un “ID” y se presionará el botón Buscar, se deberá consultar a la tabla “Usuario” y mediante el “ID” obtener el registro para después cargar la información obtenida en los controles de la pantalla e inhabilitar el control del “ID”, en caso de que el “ID” capturado no exista se deberá informar con un Mensaje de “ID no encontrado”.
 


Actualización de Usuario
Después de Consultar un Usuario podrá ser posible modificar cualquier campo excepto el “ID” y al presionar el botón Guardar deberá actualizar la información en la tabla “Usuarios” mediante el “ID”, actualizar el campo “FechaActualizacion” con GetDate(), después de actualizar el registro deberá mostrar un Mensaje con “ID: {ID} Información Actualizada” y limpiar la pantalla al estado de inicio.
 

Borrar Usuario
Se tiene que agregar un botón que permita eliminar un usuario capturado anteriormente y validar si realmente existe el usuario que se desea eliminar.
