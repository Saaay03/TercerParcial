# TercerParcial
Repositorio del Tercer Parcial de Programación para Videojuegos II


## UnityDuolingo
Proyecto que consiste en un programa similar a la aplicación Duolingo, pero enfocado en ejercicios de programación.


### Escenas

**Main.** Escenario inicial que contiene un par de botones amarillos correspondientes a diversas lecciones que el jugador puede elegir para utilizar, además de un botón especial para ir a la ventana de créditos.

**Lessons.** Presenta la pantalla que contiene las preguntas en la parte superior de la pantalla, junto con sus respectivas opciones de respuestas y un botón para comprobar tu respuesta en la sección inferior de la pantalla, además por medio de un letrero verde o rojo el jugador sabrá la evaluación de sus respuestas.


### Scripts

**Leccion.** Contiene el identificador y el contenido de la lección, la lista de opciones disponibles y el identificador de la respuesta correcta.

**LessonContainer.** Administra el número total de lecciones y la lección actual. Configura el título y el texto de cada leccion en el interfaz del jugador. Activa y desactiva la pantalla de créditos.

**LevelManager.** Gestiona las preguntas y opciones de cada lección. Verifica si la respuesta del jugador es correcta. Avanza a la siguiente pregunta despues de que el jugador haya respondido.

**MainScript.** Gestiona el cambio de escenas entre el menú y las lecciones.

**Option.** Define las opciones de respuestas de cada pregunta.

**Subject.** Almacena los datos, facilitando así la organización y gestión del juego.

**SubjectContainer.** Agrupa y almacena los datos de las lecciones.

**SaveSystem.** Permite guardar archivos JSON, los cuales contienen las preguntas.


-Para instalar el ejecutable, puedes descargar el repositorio desde la sección "Code" y luego en "Download ZIP"


![ImagenDuolingo](https://github.com/Saaay03/TercerParcial/assets/156475348/8313bf15-6bfd-4019-a545-4027ed288f5e)

https://github.com/Saaay03/TercerParcial/assets/156475348/78ba832b-dae2-4ead-addf-0f49ffccbcb5

