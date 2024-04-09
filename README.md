# TEORIA CURSO PÍLDORAS INFORMÁTICAS C# y otros


## Enumerados
Conmjunto de valores fijos para una variable, estos tienen un valor int internamente

## Delegados
Funciones que delegan en otras funciones -> referencia a un metodo

### Delegados predicados devuelven un valor booleano (true o false)

## Eventos


## HERENCIA

### Mini explicacion
Reutilizar codigo para no repetirlo adquiriendo propiedades y comportamientos de otras clases relacionadas<br>

Ej1: Jerarquia -> 1ºAbuelo 2ºPadre 3ºHijos<br>
Ej2: de "Es-un"-> Empleado, Jefe, Director<br>
Director es un empleado y es un jefe<br>
Jefe es un empleado<br>
Más abajo en la jerarquia mas específico<br>

Ej3: Mamíferos-> Caballo, Humano, Gorila

### Clase object
Todas las clases heredan de object<br>
Tiene metodos que tienen todas las clases

## Instruccion base
Contructor de la clase padre, es necesario hacer un constructor en los hijos y usar el :base si el padre tiene un contructor
Esto porque siempre se usa el base al instanciar pero no se ve

## Principio de sustitucion
"es siempre un" se puede instanciar una clase hijo en su clase padre pero no al reves
caballo es siempre un mamifero pero mamifero no es siempre un caballo

## Polimorfismo
Muchas formas de comportarse cada comportamiento las clases

### Virtual (padre) y override (hijo)
tiene un metodo llamado igual que el padre pero este modifica su comportamiento

### Protected
Accesible desde la clase y las que lo hereden




## POO (Programación Orientada a Objetos)

### Mini explicación 
Antes era en procedimientos, como lo programas se van complicando surgen dificultades a la hora de escalar.<br>
Soluciones?<br>
Simplificar en objetos -> estado, propiedades y comportamiento<br>
Se dividen en módulos (clases) -> modularización<br>
Ej en la vida: equipo IFI -> clases reproductor cd, radio, controladores, etc<br>

### Clase
Modelo donde se redactan las caracterísiticas comunes de un grupo de objetos
Ej: coche

#### Instaciacion de una clase/objeto
Se crea una variable de una clase en la que se pueden cambiar sus propiedades
ej: Circulo circ1= new Cirulo();
	circ1.radio=12;

#### Contructores
Dan un estado inicial a un objeto

### Objeto
Derivados de una clase con diferentes propiedades y comportamientos
- Una variable de una clase puede ser llamada propiedad o campo de clase.
- Un método de una clase es su comportamiento

Ej: Coche rojo y coche azul

### Modularización

### Encapsulación
Determinar qué datos de una clase son visibles y modificables.


### Herencia

### Polimorfismo


## V12

### Ambito/Alcance
Variables dentro de los corchetes {}.
Esto incluyen métodos, condicionales, bucles, etc. 


### Sobrecarga
Métodos con el mismo nombre, pero, con distinto número de parámetros o distinto tipo.


## V9
### Método
Grupo de linias de código que se agrupan
Se realiza en un momento determinado.
Admite parámetros.
Devuelven un valor si no es un void.

## V2

### Clases
Predefinidas -> biblioteca de clases (API)


### Namespace (nombre de espacios)
Son como carpetas. 
Son diferentes espacios así se puede organizar teniendo varias clases llamadas igual pero en distintos name spaces


