# Ejercicios Scripts: Movimento

## Ejercicio 1: Esfera de colores

Para hacer este ejercicio, se creó una esfera y se le asoció el script `Activity1.cs`. Este comprobará que el valor de fotogramas dado mediante el inspector es válido y modifcará la posición y el color de la esfera en dicho periodo de frames, utilizando el `Renderer` que se obtiene al inicio.

![Ejercicio 1](gifs/actividad1.gif)

## Ejercicio 2: Vectores

En este caso se creo otro script `Activity2.cs` con los `Vector3` y se añadieron una serie de métodos para mostrar los datos solicitados. Se usó la `struct` `VectorData` para poder pasar más fácilmente los datos de cada vector (su nombre y su valor).

## Ejercicio 3: Visualización de la posición de la esfera

En este caso simplemente se creo un script `Activity3.cs` que muestra al inicio la posición de la esfera usando su atributo `transform.position`.

![Ejercicios 2 y 3](gifs/actividad2-3.gif)

## Ejercicio 4: Distancia entre esfera, cubo y cilindro

Para completar esto, se creo el cubo y el cilindro, y mediante sus nombres se obtuvieron sus referencias, para luego calcular la distancia entre ellos y la esfera.

![Ejercicio 4](gifs/actividad4.gif)

## Ejercicio 5: Desplazamiento al pusar espacio

En este caso se añadió el script `Activity5.cs` y un objecto vacío al que modificaremos su componente Position. Se comprueba si se ha pulsado la barra espaciadora y si es así, se mueve el objeto según el desplazamiento indicado en el inspector.

![Ejercicio 5](gifs/actividad5.gif)

## Ejercicio 6: Detección de input y movimiento de cubo

Para esta actividad se creó el script correspondiente y simplemente se comprueba que tecla se ha pulsado para mover el cubo en la dirección correspondiente basándose en el parámetro configurable velocidad.

![Ejercicio 6](gifs/actividad6.gif)

## Ejercicio 8: Movimiento del cubo mediante parámetros

En este caso se usó el método `Translate` para mover el cubo usando tanto la variable `MoveDirection` como la `Speed`. A continuación se comentan los resultados al realizar las siguientes modificaciones:

- duplicas las coordenadas de la dirección del movimiento. El cubo se mueve el doble de rápido en esa dirección.
- duplicas la velocidad manteniendo la dirección del movimiento. Similar al anterior.
- la velocidad que usas es menor que 1. El cubo se mueve más lento.
- la posición del cubo tiene y>0. El cubo se mueve igual, simplemente empieza en una posición más alta.
- intercambiar movimiento relativo al sistema de referencia local y el mundial. Lo que cambia esto es la dirección del movimiento. En local, el cubo se mueve según su orientación, mientras que en mundial se mueve según los ejes globales.

![Ejercicio 8](gifs/actividad8.gif)

## Ejercicio 9: Movimiento del cubo con flechas

Similar a lo hecho en el ejercicio 6, pero usando en este caso el método `Translate`.

![Ejercicio 9](gifs/actividad9.gif)

## Ejercicio 10: Movimiento constante independiente de los FPS

Al hacer este apartado se ve una diferencia bastante notable. Al usar `Time.deltaTime`, el cubo se mueve mucho más lento (pues antes la escena iba a muchos FPS). Además, el movimiento es mucho más suave y constante.

![Ejercicio 10](gifs/actividad10.gif)

## Ejercicio 11: Mover esfera hacia el cubo

Para completar esta actividad, se creó el script correspondiente y en cada frame se calcula la dirección y se mueve la esfera hacia el cubo usando `Translate`.

![Ejercicio 11](gifs/actividad11.gif)

## Ejercicio 12: Rotación del cubo

En este ejercicio se hizo que el cubo orbitase alrededor de la esfera constantemente, siempre orientando su frente hacia ella. Para ello se usó el método `LookAt` junto con senos y cosenos para calcular la posición del cubo en cada frame.

![Ejercicio 12](gifs/actividad12.gif)

## Ejercicio 13: Movimiento de la esfera mediante giros

En este caso se usó el método `Rotate` para hacer que la esfera girase sobre sí misma en cada frame mientras se movía hacia adelante usando el vector `forward`, ambos movimientos parametrizados y controlados mediante el inspector. Al igual que el ejercicio anterior el cubo siempre mira a la esfera y orbita alrededor de ella.

![Ejercicio 13](gifs/actividad13.gif)
