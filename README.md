# Título 

Cibercafé "El Vicio"

*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

## Sobre mí

Mercedes Vera Sotelo

## Resumen


## Diagrama de clases


## Justificación técnica

### Clase 1 - Introducción a .NET y C

### Clase 2 - Clases y métodos estáticos

### Clase 3 - Programación orientada a objetos

### Clase 4 - Sobrecarga


### Clase 5 - Windows Forms

El proyecto es un proyecto de Windows Forms, el cual nos brinda un entorno gráfico para que sea más amigable para el usuario (también llamado "el pibe que atiende el ciber").
Para ello se utiliza todo tipo de controles y eventos.
Se eligió un Listbox para la visualizar la lista de clientes en espera.
Se utilizó un ComboBox para mostrar y seleccionar los puestos disponibles, y se fijó su propiedad DropdownList en DropDownStyle, para que no se puedan ingresar nuevos valores. Luego se busca la opción seleccionada con un foreach().
Se usaron RadioButton para seleccionar el tipo de sesión (Libre o Fija), ya que sólo se debe poder selecccionarse una, y se seteó la opción libre seleccionada por default para que no exista la opción de no seleccionar nada.
Si está seleccionada la opción Fija, se muestra un NumericUpDown con su correspondiente Label, para ingresar el tiempo solicitado en minutos. El valor mínimo e inciial es 30. Seleccionandolo con las flechas solo pueden ingresarse múltiplos de 30. Si se ingresa manualmente otro valor, al enviar el formulario con el boton Asignar se muestra un MessageBox indicando el error.


### Clase 6 - Colecciones

Se utilizaron tres tipos de colecciones genéricas: List, Dictionary y Queue.
- Las **List** se usaron para listar perifericos, juegos y software, para registrar los servicios de un puesto y los puestos del cibercafé. Se usó este tipo de colección porque no es necesario asignar una clave pero si es necesario poder acceder a los elementos con un foreach o un índice.
- El **Dictionary** se utilizó para las especificaciones del hardware, ya que se necesita asociar una clave (especificación) a un valor. Habrá una sola específicacion de cada tipo y va a tener un solo valor.
- Se usó una **Queue** para los clientes en espera, ya que siempre el próximo cliente en ser seleccionado va a ser el que llegó antes (orden FIFO), y hasta que no terminemos con ese cliente no trabajaramos con el resto.


### Clase 7 - Encapsulamiento

Los atributos se encuentran ocultos (privados), solo pudiendo acceder a ellos a través de propiedades (tanto de lectura como de lectura/escritura).
Tambien se oculta la implementación de algunos métodos que son de uso interno de la clase.

- Enumerados: Se utilizan diversos enumerados para definir los valores que le podemos dar a un atributo, algunos que son propios de una clase y otros que se utilizan en varias (EPerifericos, EJuegos y ESoftware), los cuales están declarados en una clase aparte Enumerados.cs.
- Indexadores: 


### Clase 8 - Herencia

**Herencia de clases**

En el proyecto se heredan varias clases, que tienen una relación semántica con la clase base.
Por ejemplo, las cabina y las computadora comparten varias carácterísticas (identificador, estado y lista de servicios) y métodos (calcular minutos de uso del puesto), por lo que heredan de la clase Puesto.
Lo mismo ocurre con sesión y llamada, que son tipos de Servicios, sobre los cuales podemos calcular el costo y agregarle IVA.

Tambien se heredan Formularios (FormIngreso define caracteristicas comunes para asignar un puesto a un cliente independiente al servicio que se solicite, como una label con los datos del cliente, un combobox para mostrar los puestos disponibles, botón cancelar y asignar). 
De él heredan FormIngresoPC y FormIngresoLlamada que, egún el servicio del que se trate, tiene controles y eventos específicos (íngresar número, seleccionar tipo de sesión, etc.)

**Principio de sustitución de Liskov**
Para listar los puestos (computadora o cabina) del cibercafé, se utiliza una lista de objetos tipo Puesto. Por el principio de Liskov, podemos agregar objetos de tipo Computadora o Cabina a esa lista de objetos Puesto, y castearlo de nuevo a su tipo cuando necesitamos utilizar miembros específicos de la clase.


### Clase 9 - Polimorfismo y clases abstractas

**Clases abstractas**
Se utilizan dos clases abstractas: Puesto y Servicio. Estas clases no tienen utilidad sin las características que se asignan en sus clases derivadas, por lo que no deben poder instanciarse. Son clases incompletas.
Contienen tanto métodos abstractos como métodos que son implementados por las clases derivada y métodos no abstractos, que son utilizados por estas.

**Clases selladas**
Llamada y Sesión son clases selladas. No se debe poder heredar de ellas, ya que contienen toda la información e implementación necesaria para su funcionamiento.


## Propuesta de valor agregado

**Instalación y uso de un paquete Nuget: Fluent Validation**
Se instaló y utilizó el paquete Fluent Validation. Con él, se valida que el código país, prefijo y número de teléfono ingresados por el usuario en los TextBox sean válidos.
Los datos deben ser numéricos, por lo que se utiliza la RegEx __^[0-9]*$__. También se valida la cantidad de caracteres y que el campo no sea null.