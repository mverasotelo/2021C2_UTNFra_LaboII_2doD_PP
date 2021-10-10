# Título 

Cibercafé "El Vicio"

*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

## Sobre mí

Mi nombre es Mercedes Vera Sotelo, tengo 32 años y vivo en Congreso, CABA.
Hace varios años me recibí de Lic. en Relaciones Internacionales. El año pasado, al principio de la cuarentena, me anoté a un curso de programación que estaba gratis en EDX, porque me parecía muy interesante y desde ese momento seguí haciendo cursos relacionados, así que en febrero decidí anotarme en esta tecnicatura.
El trabajo fue un gran desafío. Más allá de conocer las herramientas y aplicar los conocimientos aprendidos, lo que más me costó fue pensar la lógica de negocios, planificar las entidades y sus relaciones.
También me obligó a investigar mucho en internet y ver varios videos para resolver algunas necesidades, por lo que termine aprendiendo muchas cosas nuevas.

## Resumen

La aplicación sirve para administrar un cibercafé que tiene computadoras y cabinas de los años 2000.
Hay una lista de clientes en espera que tienen algún servicio solicitado, y cuando le toca su turno el usuario de la aplicación (que es la persona que atiende el negocio) le debe asignar un puesto.
El estado de los puestos es visible todo el tiempo por el usuario y está identificado con rojo para ocupados y verde para disponibles. 
Al momento de asignar el puesto, el programa sólo da opción de seleccionar los puestos que están libres, y también los filtra dependiendo del servicio elegido y, en el caso de las PC, de las necesidades que tiene el cliente tanto de hardware como de software y juegos.
Sino existe un puesto compatible con la necesidad del cliente, este es asignado al final de la fila, para esperar a que se libere algun puesto. 
Cuando el cliente ha finalizado, el operador puede entrar al puesto utilizado y liberarlo, lo que genera automáticamente la información del servicio, tiempo de uso y el costo a pagar por el cliente, bruto y gravado con el IVA.
Tambien se cuenta con una sección de estadisticas, donde se visualiza información histórica del cibercafé, por ejemplo, lista de puestos ordenados por su uso, ganancias o qué requerimiento fue el más solicitado, lo que ayuda a tomar decisiones de negocios.

## Diagrama de clases

![Diagrama de Clases](https://github.com/mverasotelo/2021C2_UTNFra_LaboII_2doD_PP/blob/master/VeraSotelo.Mercedes.PrimerParcial/Biblioteca/DiagramaClases.png)

## Justificación técnica

### Clase 1 - Introducción a .NET y C#

La aplicación está desarollada en el lenguaje C# utilizando el IDE Visual Studio 2019, respetando las reglas de estilo establecidas por el lenguaje y la cátedra. También se han documentado las clases y sus miembros con la herramienta de documentación xml.


### Clase 2 - Clases y métodos estáticos

Se utilizó la clase estática Cibercafé, ya que por la naturaleza de la aplicación no es necesario crear una instancia de la misma. En esta clase se manejan las relaciones entre distintos objetos/clases.
Todos los métodos y atributos de esa clase son estáticos. 


### Clase 3 - Programación orientada a objetos

El proyecto está diseñado bajo el paradigma de la Programación Orientada a Objetos (POO), teniendo en cuenta sus cuatro pilares:
- Abstracción: Se identicaron entidades en base a las necesidades del cliente, se seleccionaron sus características más relevantes y se descartaron  características no relevantes para la lógica de negocios.
- Encapsulamiento: Se ocultaron los detalles de la implementación, pudiendo acceder a los atributos solamente a traves de propiedades o métodos.
- Herencia: Se buscaron características y comportaminetos en común y se crearon clases más especializadas a partir de clases más generales.
- Polimorfismo: 


### Clase 4 - Sobrecarga

- **Sobrecarga de métodos**:Se aplica la sobrecarga del método EstaDisponible() de la clase Computadora. Así se puede le puede pasar por parámetro tanto un juego, un software o un periferico, y devuelve un booleano indicando si está disponible en esa instancia o no.
- **Sobrecarga de constructores**: La clase Computadora tiene una sobrecarga de constructor: En el primero, que es privado, no se recibe parámetros y se crean las listas de juegos, perifericos y software, así como el diccionario de especificaciones de hardware. En el segundo constructor, que llama al primero a través de :this(), se reciben todos esos atributos como parámetros.
- **Sobrecarga de operadores**: En todas las jerarquías de herencia se utiliza la sobrecarga del operador de igualdad y su opuesto para redefinir su comportamiento al comparar dos objetos.


### Clase 5 - Windows Forms

La aplicación es un proyecto de **Windows Forms**, el cual nos brinda un entorno gráfico para que sea más amigable para el usuario (también llamado "el pibe que atiende el ciber").
Para ello, se separó físicamente la capa de presentación (proyecto VeraSotelo.Mercedes.PrimerParcial) de la lógica de negocio (proyecto Biblioteca).

Para ello se utiliza todo tipo de controles y eventos:
- Se eligió un Listbox para la visualizar la lista de clientes en espera.
- Se utilizó un ComboBox para mostrar y seleccionar los puestos disponibles, y se fijó su propiedad DropdownList en DropDownStyle, para que no se puedan ingresar nuevos valores. Luego se busca la opción seleccionada con un foreach().
- Se usaron RadioButton para seleccionar el tipo de sesión (Libre o Fija), ya que sólo se debe poder selecccionarse una, y se seteó la opción libre seleccionada por default para que no exista la opción de no seleccionar nada.
- Si está seleccionada la opción Fija, se muestra un NumericUpDown con su correspondiente Label, para ingresar el tiempo solicitado en minutos. El valor mínimo e inciial es 30. Seleccionandolo con las flechas solo pueden ingresarse múltiplos de 30. Si se ingresa manualmente otro valor, al enviar el formulario con el boton Asignar se muestra un MessageBox indicando el error.


### Clase 6 - Colecciones

Se utilizaron tres tipos de colecciones genéricas: List, Dictionary y Queue.
- Las **List** se usaron para listar perifericos, juegos y software, para registrar los servicios de un puesto y los puestos del cibercafé. Se usó este tipo de colección porque no es necesario asignar una clave pero si es necesario poder acceder a los elementos con un foreach o un índice.
- El **Dictionary** se utilizó para las especificaciones del hardware, ya que se necesita asociar una clave (especificación) a un valor. Habrá una sola específicacion de cada tipo y va a tener un solo valor.
- Se usó una **Queue** para los clientes en espera, ya que siempre el próximo cliente en ser seleccionado va a ser el que llegó antes (orden FIFO), y hasta que no terminemos con ese cliente no trabajaramos con el resto.


### Clase 7 - Encapsulamiento

Los atributos se encuentran ocultos (con modificador de visibilidad private o protected), solo pudiendo acceder a ellos a través de propiedades (tanto de lectura como de lectura/escritura).
Tambien se oculta la implementación de algunos métodos que son de uso interno de la clase.

- **Enumerados**: Se utilizan diversos enumerados para definir los valores que le podemos dar a un atributo, algunos que son propios de una clase y otros que se utilizan en varias (EPerifericos, EJuegos y ESoftware), los cuales están declarados en una clase aparte Enumerados.cs.
- **Indexadores**: 


### Clase 8 - Herencia

**Herencia de clases**

En el proyecto se heredan varias clases, que tienen una relación semántica con la clase base.
Por ejemplo, las cabinas y las computadoras comparten varias carácterísticas (identificador, estado y lista de servicios) y métodos (calcular minutos de uso del puesto), por lo que heredan de la clase Puesto.
Lo mismo ocurre con sesión y llamada, que son tipos de Servicios, sobre los cuales podemos calcular el costo y agregarle IVA.

Tambien se heredan Formularios (FormIngreso define caracteristicas comunes para asignar un puesto a un cliente independiente al servicio que se solicite, como una label con los datos del cliente, un combobox para mostrar los puestos disponibles, botón cancelar y asignar). 
De él heredan FormIngresoPC y FormIngresoLlamada que, egún el servicio del que se trate, tiene controles y eventos específicos (íngresar número, seleccionar tipo de sesión, etc.)

**Principio de sustitución de Liskov**
Para listar los puestos (computadoras o cabinas) del cibercafé, se utiliza una lista de objetos tipo Puesto. Por el principio de Liskov, podemos agregar objetos de tipo Computadora o Cabina a esa lista de objetos Puesto, y castearlo de nuevo a su tipo cuando necesitamos utilizar miembros específicos de la clase.


### Clase 9 - Polimorfismo y clases abstractas

** Poliformismo**
Se utiliza el poliformismo en el método MostrarPuestosPorMinutosDeUso(). Si bien solo manejamos variables de tipo Puesto, cuando en tiempo de ejecución el tipo del objeto sea Cabina, se van a mostrar las cabinas con su correspondiente implementación del método ToString(), y cuando se trate de Computadoras, se va a llamar al implementación de ToString() de esa clase. 

**Clases abstractas**
Se utilizan dos clases abstractas: Puesto y Servicio. Estas clases no tienen utilidad sin las características que se asignan en sus clases derivadas, por lo que no deben poder instanciarse. Son clases incompletas.
Contienen tanto métodos abstractos como métodos que son implementados por las clases derivadas y métodos no abstractos, que son utilizados por estas.

**Clases selladas**
Llamada y Sesión son clases selladas. No se debe poder heredar de ellas, ya que contienen toda la información e implementación necesaria para su funcionamiento.


## Propuesta de valor agregado

**Instalación y uso de un paquete Nuget: Fluent Validation**
Se instaló y utilizó el paquete Fluent Validation. Con él, se valida que el código país, prefijo y número de teléfono ingresados por el usuario en los TextBox sean válidos.
Los datos deben ser numéricos, por lo que se utiliza la RegEx __^[0-9]*$__. También se valida la cantidad de caracteres y que el campo no sea null.