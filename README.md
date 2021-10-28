# II-Introduccion-a-los-scripts-en-Unity

![Foo]()

### 1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos fisicos en Unity. La escena debe tener un plano a mode de suelo, una esfera y un cubo

* Ninguno de los objetos sera fisico.


![Foo](https://i.gyazo.com/efa0c2072be08093aba42c45eb40a87f.png)


* La esfera tiene fisicas, el cubo no.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/1b.gif)

* La esfera y el cubo tienen fisicas.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/1c.gif)

* La esfera y el cubo son fisicos y la esfera tiene 10 veces la masa del cubo.
    
La velocidad de caida no se ve afectada por la masa del objeto.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/1d.gif)

* La esfera tiene fisicas y el cubo es de tipo IsTrigger.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/1e.gif)

* La esfera tiene fisicas, el cubo es de tipo IsTrigger y tiene fisicas.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/1f.gif)

* La esfera y el cubo son fisicos y la esfera tiene 10 veces la masa del cubo, se impide la rotacion del cubo sobre el plano XZ.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/1g.gif)

### 2. Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController. Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección que estos ejes indican.

* Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulacion fisica.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/2a.gif)

* Agregar un campo publico que permita graduar la velocidad del movimiento desde el inspector de objetos. 

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/2b.gif)

* Estar a la escucha de si el usuario ha utilizado los ejes virtuales. Elegir cuales se va a permitir utilizar: flechas, awsd.

![Foo](https://github.com/alu0101127163/II-Introduccion-a-los-scripts-en-Unity/blob/main/img/2c.gif)


