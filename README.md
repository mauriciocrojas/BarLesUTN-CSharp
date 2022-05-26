Bienvenido al Bar Les UTN.

Al mismo se puede ingresar a través de un Login principal, en el cual el usuario, sea este tipo Empleado o Administrador, podrá cargar sus datos a través del botón que corresponda.
Una vez cargados los datos, y apretado el botón de ingresar (pasando una validación de datos de por medio), se llamará a un constructor al cual se le pasará un tipo de usuario, y a partir del tipo que sea este, se mostrará un formulario de Acceso, el cual acorde al tipo de usuario, tendrá distintas funcionalidades.

Ya en el formulario de Acceso, este tendrá las ubicaciones disponibles en color naranja, y las ocupadas en color beige, logrado gracias a crear dos diccionarios, uno para botonera de mesas, y otro de la barra. Al ingresar a determinada ubicación se abrirá de manera distinta si es mesa o barra. En mesa te dejará elegir entre comida y/o bebida, y en barra sólo elegir bebidas. Al hacer el pedido se mostrará el mismo a través de un MessageBox.Show, informando todo el detalle del consumo, método de pago, uso de estacionamiento, etc.
Si entramos como Administrador, tendremos acceso a ver los empleados cargados en el sistema, y también al botón de control de stock, donde podrán agregar un nuevo producto, ya sea bebida o comida, el cual se agregará a su lista correspondiente, y luego se podrá visualizar también a la hora de entrar a una mesa/barra y ver la lista de productos a seleccionar. 
Los empleados también tienen acceso al botón control de stock, pero de una manera restringida, sólo podrán ver el stock, y no podrán ver a los empleados que trabajan en el bar.

De la clase usuario derivan Administrador y Empleado, de Pedido, deriva Barra y Mesa, de Stock, Comida y Bebida. En todos estos casos se aplica herencia.
Polimorfismo observamos en: Usuario clase abstracta, tiene un método abstracto MostrarDatos, el cual se implementará en sus dos clases derivadas. Y tiene un método virtual MostrarDato, que sobrescribí su implementación en su derivadas.
Uso Propiedades para mostrar el nombre completo del usuario.
Uso colecciones en listas y diccionarios, como los de comida y bebida, botoneras.
Etc.

--Programa y README.md a terminar--
