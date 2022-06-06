# Programación Orientada a Objetos

¿En que consiste?
- Trasladar la naturaleza de un objeto de la vida real al código de programación.

¿Cual es esa naturaleza?
- Estado
- Comportamiento
- Propiedades

Ejemplo: El objeto coche
- Estado.- Parado, andando, aparcado etc.
- Comportamiento.- Arrancar, frenar, acelerar, girar, etc.
- Propiedades.- Color, peso, tamaño, etc.

Ventajas
- Programas divido en trozos, partes, módulos o clases.(Modularization)
- Código reutilizable. Herencias
- Si existe fallo en alguna línea de código el programa continua
- Encapsulamiento.

## Vocabulario de la POO

- clases
- objeto
- Ejemplar de clase, Instancia de clase, Ejemplarizar una clase, Instancia una clase
- Modularización
- Encapsulamiento / encapsulación
- Herencia
- Polimorfismo

## Clase
Es el modelo donde se redactan las características comunes de un grupo de objetos.

Podríamos considerar que es una plantilla de la cual se derivaran o crearan objetos

Por ejemplo la clase coche tiene características comunes que se comparten entre diferentes fabricante.

De ahí se crean nuevos coches (objeto)con propiedades diferentes o comportamientos

## Objeto
Tiene propiedades (atributos, características)
- color
- peso
- alto
- largo
Tiene un comportamiento (¿Que es capaz de hacer)
- Arrancar
- Acelerar
- Girar
- Frenar

Accediendo a propiedades de un objeto desde código
- Renualt.color = "rojo"

Accediendo a comportamientos de un objeto desde código
- Renual.arranca();


## Encapsulamiento
Por convención todos las propiedades y métodos deberían estar encapsulados con el modificador de acceso private a menos que se necesite estar publico. y solo sera modificado con un método de acceso.

## Convenciones a la hora de programar
Los identificadores "public" deben comenzar con la letra mayúscula.
- Notación "PascalCase".
public double CalculoArea();
 y los que no con la letra minúscula.
 - Notación "CamelCase"
 private double longitudRadio();

