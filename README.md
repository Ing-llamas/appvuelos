*Entornos en los que se desarrollo la Aplicacion

- Visual Studio 2019
- SQL SERVER 2019

*Pasos Para Ejecutar La Aplicacion

Paso 1. Descargar el proyecto

Paso 2. Restaurar el backup de la Base de Datos

Paso 3. Abrir ejecutar el archivo .sln del proyecto

Paso 4. Ir a la capa de Datos => seleccionar la clase CONEXIONMAESTRA => Luego buscar la variable conexión del tipo SqlConnection que se muestra a continuación.

public static SqlConnection conexion = new SqlConnection(@"Data Source=ING-LLAMAS;Initial Catalog=Areopuerto;Persist Security Info=True;User ID=sa;Password=oscar1012");

Aquí modificar los siguientes parámetros(servidor, usuario, contraseña) de Acuerdo a su sql server management studio: Source=" " , ID=" " y Password=" "

Pase 5. Depurar el el proyecto

Paso 6. Para poder ingresar a la aplicación primero se mostrara una ventada de Login en el cual podemos acceder con cualquiera de los siguientes Usuarios.

Usuarios Permitidos

1) user1: Admin1 password: 123
2) user2: Admin2 password: 1234
3) user3: Admin3 password: 12345

paso 7. Después de iniciar sesión se mostrará una ventana inicial con un saludo de bienvenida y con dos Botones(Vuelos y Administrador).

-Si Damos click en botón Vuelos este nos llevara al módulo de vuelo.
-Si Damos click en botón Administrador este nos llevara al módulo del Administrador.

Paso 8. Modulo Administrador: En este se puede ingresar los datos de un vuelo, editarlo, eliminarlo y ademas pudemos buscar un determinado registro por su numero de vuelo.
Proceso de Registro: Se da click en el botón con el icono +, luego se despliega un formulario y se procede a llenar los campos.
Proceso de Editar: Se da click en el icono que tiene cada registro y luego se despliega el formulario con todos los campos que se pueden modificar.
Proceso de Eliminar: Para este proceso hay que hacer doble click sobre el registro que deseemos eliminar, Después nos pedirá que confirmemos si en realidad queremos eliminar el registro.
Proceso de buscar. Se puede Buscar un registro por su número de vuelo (Filtro sensitivo), solo tenemos que ingresar el número de vuelo que deseamos buscar en el TexBox que se encuentra en la parte superior, a medida que se escriba una letra la aplicación ira filtrando Ira filtrando.

Paso 7: Modulo Vuelos: En este módulo se podrá visualizar los vuelos que se hallan registrados desde el administrador solo realizamos click sobre el botón Vuelos y nos mostrara los datos.

Nota: Al siguiente correo claudia.giraldo@carvajal.com fue enviado un video con el funcionamiento de la aplicación, en este también se adjuntó un archivo txt donde se resalta aspectos relevantes a tener en cuenta en el video.

 *******  Entidades  ********
 Areolineas
 Ciudades
 Estado
 Usuario
 Vuelos





 






