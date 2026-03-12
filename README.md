MEMORIA PRÁCTICA 1 PROGRAMACIÓN VIDEOJUEGOS

Lo primero que hice fue cargar los assets de la muñeca y los bloques creando una escalera en el mapa. Ponemos la cámara en primera persona en el player y asignamos el tag player.
A los bloques les asignamos un tag ground. 
Los colliders se asignan a los bloques y a la muñeca para no traspasar los bloques y el rigidbody a la muñeca para que tenga gravedad.
Creamos un código de movimiento y salto que añadimos al player para moverse.
Se crean dos códigos más para que no todos los bloques funcionen igual, uno al tocarlo se cae y otro baja hasta el suelo y al segundo vuelve a su origen.
Por último cambiamos los colores de la placa suelo y de los bloques con la gama de colores aportada al inicio de la práctica.

MEMORIA PRÁCTICA 2 PROGRAMACIÓN VIDEOJUEGOS

Primero cargamos los assets dados en el campus virtual. Introducimos las monedas y las bolas de pinchos y las situamos sobre los bloques. A partir de ahi, le añadimos las funcionalidades de recoger monedas y perder vidas con el canvas creado. 
Despues realizamos el checkpoint, que al pasar sobre él, sobre la mitad del nivel si tocamos una bola de pinchos volvemos a ese punto. 
Con el canvas llevamos el contador de monedas recogidas y perdiendo vidas, si perdemos todas volvemos al inicio. 
Despues creamos otra escena de pantalla principal en la que cree una imagen con la IA, para que fuese más visual y ademas le cree un boton que lo vinculaba con el nivel1.
Despues cree un punto final en la partida que al tocarlo nos llevaba a una escena nueva que nos ponia que el nivel habia sido completado y nos daba dos opciones con dos botones de volver a jugar o volver a la pantalla principal
