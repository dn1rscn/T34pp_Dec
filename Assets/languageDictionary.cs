using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class languageDictionary//: MonoBehaviour
{	
	public static Dictionary<string, string> stringList = new Dictionary<string, string>();
	//public static string[] DadoEN = {"Strawberry","Pear","Banana","Cup", "Lamp", "Key", "Hanger", "Bowl", "glass", "Sun", "Moon", "Star"};
	//public static string[] PruebaArray2;
	public static string lang;
	//static static ControlDatosGlobales_PICTOGRAMAS CDGD;

	public static void Lenguaje ()
	{
		//stringList = new Dictionary<string, string>();
		//stringList.Clear();

		if(lang=="Spanish"||lang==null)
		{
			stringList.Add("Seleccion de Idioma", "SELECCIÓN DE IDIOMA");

			stringList.Add ("Español", "ESPAÑOL");
			stringList.Add ("Ingles", "INGLÉS");
			stringList.Add ("Euskera", "EUSKERA");
			stringList.Add ("FRANCES", "FRANCÉS");

			stringList.Add ("Fallos:", "FALLOS:");

			stringList.Add ("Cargando...", "CARGANDO...");

			stringList.Add ("¿SEGURO QUE QUIERES BORRAR LA PARTIDA?", "¿SEGURO QUE QUIERES BORRAR LA PARTIDA?");
			stringList.Add ("SI", "SI");
			stringList.Add ("NO", "NO");
			
			//intro
			stringList.Add ("Empezar", "EMPEZAR");
			stringList.Add ("Continuar", "CONTINUAR");
			stringList.Add ("Nuevo", "NUEVO");
			
			//personalizacion
			stringList.Add ("Crea tu avatar", "CREA TU AVATAR");
			
			//selec isla
			stringList.Add ("Selección de isla", "SELECCIÓN DE ISLA");
			
			//Tutorial
			stringList.Add ("Tutorial", "TUTORIAL");
			stringList.Add ("Haz click en el suelo para moverte", "HAZ CLICK EN EL SUELO PARA MOVERTE");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "INTERACTUA CON LAS MASCOTAS HACIENDO CLICK EN ELLAS");
			stringList.Add ("¡Hola!", "¡HOLA!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "PAUSA LA PARTIDA PARA ACCEDER A MAPA Y PERSONALIZACIÓN");
			stringList.Add ("Accede a los portales para completar los ejercicios", "ACCEDE A LOS PORTALES PARA COMPLETAR LOS EJERCICIOS");
			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "¡BIENVENIDO A LA ISLA BOSQUE!");
			stringList.Add ("He perdido uno de mis:", "HE PERDIDO UNO DE MIS:");
			stringList.Add ("Ayúdame a encontrarlo", "AYÚDAME A ENCONTRARLO");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "¡GRACIAS POR AYUDARME A RECUPERARLO!");
			
			//Menu
			stringList.Add ("Objetivos", "OBJETIVOS");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "CONSIGUE 3 ESTRELLAS EN TODOS LOS EJERCICIOS DE ISLA BOSQUE");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "CONSIGUE 3 ESTRELLAS EN TODOS LOS EJERCICIOS DE ISLA FANTASMA");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "CONSIGUE 3 ESTRELLAS EN TODOS LOS EJERCICIOS DE ISLA MECANICA");
			stringList.Add ("Dado nivel 1", "DADO NIVEL 1");
			stringList.Add ("Dado nivel 2", "DADO NIVEL 2");
			stringList.Add ("Sonidos nivel 1", "SONIDOS NIVEL 1");
			stringList.Add ("Sonidos nivel 2", "SONIDOS NIVEL 2");
			stringList.Add ("Sonidos nivel 3", "SONIDOS NIVEL 3");
			stringList.Add ("Empatia nivel 1", "EMPATIA NIVEL 1");
			stringList.Add ("Empatia nivel 2", "EMPATIA NIVEL 2");
			stringList.Add ("Empatia nivel 3", "EMPATIA NIVEL 3");
			stringList.Add ("Emociones nivel 1", "EMOCIONES NIVEL 1");
			stringList.Add ("Emociones nivel 2", "EMOCIONES NIVEL 2");
			stringList.Add ("Emociones nivel 3", "EMOCIONES NIVEL 3");
			
			//DAdo
			stringList.Add ("Ejercicio dado", "EJERCICIO DADO");
			stringList.Add ("Entrar", "ENTRAR");
			stringList.Add ("Selección de nivel", "SELECCIÓN DE NIVEL");
			stringList.Add ("Haz click en el dado para lanzarlo", "HAZ CLICK EN EL DADO PARA LANZARLO");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "¡EMPAREJA LA IMAGEN CON EL DADO PARA GANAR PUNTOS!");
			stringList.Add ("Nivel 2 desbloqueado", "NIVEL 2 DESBLOQUEADO");
			stringList.Add ("Nivel 3 desbloqueado", "NIVEL 3 DESBLOQUEADO");
			stringList.Add ("Nivel 1 Completado", "NIVEL 1 COMPLETADO");
			stringList.Add ("Nivel 2 Completado", "NIVEL 2 COMPLETADO");
			stringList.Add ("Nivel 3 Completado", "NIVEL 3 COMPLETADO");
			stringList.Add ("Aciertos:", "ACIERTOS: ");
			stringList.Add ("Combos:", "COMBOS: ");
			stringList.Add ("Monedas:", "MONEDAS: ");
			stringList.Add ("Nivel 2 completado", "NIVEL 2 COMPLETADO");
			
			stringList.Add ("TIRA", "TIRA");
			stringList.Add ("EL", "EL");
			stringList.Add ("DADO", "DADO");
			
			stringList.Add ("Fresa", "FRESA");
			stringList.Add ("Pera", "PERA");
			stringList.Add ("Platano", "PLÁTANO");
			stringList.Add ("Copa", "COPA");
			stringList.Add ("Bombilla", "BOMBILLA");
			stringList.Add ("LLave", "LLAVE");
			stringList.Add ("Percha", "PERCHA");
			stringList.Add ("Taza", "TAZA");
			stringList.Add ("Vaso", "VASO");
			stringList.Add ("Sol", "SOL");
			stringList.Add ("Luna", "LUNA");
			stringList.Add ("Estrella", "ESTRELLA");
			
			//SOnidos
			stringList.Add ("Ejercicio sonidos","EJERCICIO SONIDOS");
			stringList.Add ("Pulsa PLAY para escuchar un sonido", "PULSA PLAY PARA ESCUCHAR UN SONIDO");
			stringList.Add ("y REPLAY para repetirlo", "Y REPLAY PARA REPETIRLO");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "HAZ CLICK EN LA IMAGEN QUE CORRESPONDA AL SONIDO");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "PULSA PLAY DE NUEVO PARA SEGUIR JUGANDO");
			stringList.Add ("Isla Fantasma desbloqueada", "ISLA FANTASMA DESBLOQUEADA");
			
			stringList.Add ("Isla Fantasma", "ISLA FANTASMA");
			
			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "¡BIENVENIDO A LA ISLA FANTASMA!");
			stringList.Add ("Mis:", "MIS:");
			stringList.Add ("se han ro...ro..roto...", "SE HAN RO...RO..ROTO...");
			stringList.Add ("Ayúdame a encontrar las piezas", "AYÚDAME A ENCONTRAR LAS PIEZAS");
			
			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "EJERCICIO SECUENCIAS");
			stringList.Add ("Lavarse los dientes", "LAVARSE LOS DIENTES");
			stringList.Add ("Llamar por teléfono", "LLAMAR POR TELÉFONO");
			stringList.Add ("Comprar el pan", "COMPRAR EL PAN");
			stringList.Add ("Cruzar la calle", "CRUZAR LA CALLE");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "COLOCA LAS IMAGENES EN EL MARCO EN EL ORDEN CORRECTO");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "¡HAZ CLICK EN ELLAS PARA COLOCARLAS!");
			stringList.Add ("¿Quieres salir?", "¿QUIERES SALIR?");
			stringList.Add ("Secuencia desbloqueada", "SECUENCIA DESBLOQUEADA");
			stringList.Add ("Isla Mecanica Desbloqueada", "ISLA MECANICA DESBLOQUEADA");
			stringList.Add ("Secuencia completada", "SECUENCIA COMPLETADA");
			
			//CANASTA
			stringList.Add ("Juego canasta", "JUEGO CANASTA");
			stringList.Add ("Canasta Completada", "CANASTA COMPLETADA");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "¡CONSIGUE MÁS PUNTOS QUE EL FANTASMA ENCESTANDO!");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "HAZ CLICK EN LA BARRA CUANDO PASE LA BARRA AMARILLA");
			stringList.Add ("¡Hazlo tres veces para encestar!", "¡HAZLO TRES VECES PARA ENCESTAR!");
			stringList.Add ("Has perdido", "HAS PERDIDO");
			stringList.Add ("Has ganado", "HAS GANADO");
			stringList.Add ("Espera tu turno...", "ESPERA TU TURNO...");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "¡GRACIAS! ¡HAS LOGRADO ENCONTRAR MIS GAFAS!");
			
			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "ISLA MECANICA");
			
			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "¡BIENVENIDO A ISLA MECANICA!");
			stringList.Add ("Me he quedado sin bateria...", "ME HE QUEDADO SIN BATERIA...");
			stringList.Add ("Ayúdame a encontrar: ", "AYÚDAME A ENCONTRAR: ");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias!", "¡GENIAL! ¡GRACIAS POR ENCONTRAR MIS BATERIAS!");
			
			//emociones
			stringList.Add ("Ejercicio emociones", "EJERCICIO EMOCIONES");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "SELECCIONA LA EMOCIÓN POR LA QUE TE PREGUNTA EL ROBOT");
			stringList.Add ("Arrastra las imagenes para verlas", "ARRASTRA LAS IMAGENES PARA VERLAS");
			stringList.Add ("Pulsa la imagen que elijas", "PULSA LA IMAGEN QUE ELIJAS");
			stringList.Add ("Alegria", "ALEGRIA");
			stringList.Add ("Asco", "ASCO");
			stringList.Add ("Enfado", "ENFADO");
			stringList.Add ("Miedo", "MIEDO");
			stringList.Add ("Sorpresa", "SORPRESA");
			stringList.Add ("Tristeza", "TRISTEZA");
			stringList.Add ("Vergüenza", "VEGÜENZA");
			stringList.Add ("Curiosidad", "CURIOSIDAD");
			stringList.Add ("Nerviosismo", "NERVIOSISMO");
			stringList.Add ("Tranquilidad", "TRANQUILIDAD");
			
			//Empatia
			stringList.Add ("Ejercicio empatia", "EJERCICIO EMPATIA");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "OBSERVA LA SITUACIÓN QUE SE PLANTEA EN LA TELE GRANDE");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "SELECCIONA COMO CREES QUE SE SENTIRÍA ESA PERSONA");
			stringList.Add ("Pulsa la imagen para seleccionarla", "PULSA LA IMAGEN PARA SELECCIONARLA");
			
			//Isla ALtar
			stringList.Add ("Isla Altar", "ISLA ALTAR");
			stringList.Add ("Isla Altar Desbloqueada", "ISLA ALTAR DESBLOQUEADA");
			stringList.Add ("¡Felicidades!", "¡FELICIDADES!");
			stringList.Add ("¡Felicidades! Has completado el juego", "¡FELICIDADES! HAS COMPLETADO EL JUEGO");
			stringList.Add ("Menú inicial", "MENÚ INICIAL");
			stringList.Add ("Créditos", "CRÉDITOS");

			//Menu Final Demo
			stringList.Add ("¿Podras ganar al fantasma a baloncesto?", "¿PODRÁS GANAR AL FANTASMA A BALONCESTO?");
			stringList.Add ("¡Explora la isla mecanica y completa nuevos juegos!", "¡EXPLORA LA ISLA MECÁNICA Y COMPLETA NUEVOS JUEGOS!");
			stringList.Add ("¿Seras capaz de llegar hasta el final?", "¿SERAS CAPAZ DE LLEGAR HASTA EL FINAL?");
			stringList.Add ("¿Te atreves a adentrarte en la isla Fantasma?", "¿TE ATREVES A ADENTRARTE EN LA ISLA FANTASMA?");

			stringList.Add ("VALÓRANOS", "VALÓRANOS");
			stringList.Add ("¡GRACIAS POR JUGAR!", "¡GRACIAS POR JUGAR!");

            //Control Parental
            stringList.Add("Pregunta a tus padres:", "PREGUNTA A TUS PADRES:");
            stringList.Add("¿Eres mayor de edad?", "¿ERES MAYOR DE EDAD?");
            stringList.Add("Inserta tu año de nacimiento", "INSERTA TU AÑO DE NACIMIENTO");
            stringList.Add("Debes tener más de 18 años para seguir", "DEBES TENER MAS DE 18 AÑOS PARA SEGUIR");
            stringList.Add("El año introducido no es valido. introduce un año de 4 digitos", "EL AÑO INTRODUCIDO NO ES VALIDO, INTRODUCE TU AÑO DE NACIMIENTO");
		}

		if(lang=="English")
		{
			stringList.Add("Seleccion de Idioma", "CHOOSE LANGUAGE");

			//print(lang);
			//PANTALLA CARGA
			stringList.Add ("Español", "SPANISH");
			stringList.Add ("Ingles", "ENGLISH");
			stringList.Add ("Euskera", "EUSKERA");
			stringList.Add ("FRANCES", "FRENCH");

			stringList.Add ("Cargando...", "LOADING...");

			stringList.Add ("Fallos:", "MISTAKES:");

			stringList.Add ("¿SEGURO QUE QUIERES BORRAR LA PARTIDA?", "¿ARE YOU SURE YOU WANT TO LEAVE THE GAME?");
			stringList.Add ("SI", "YES");
			stringList.Add ("NO", "NO");

			//intro
			stringList.Add ("Empezar", "START");
			stringList.Add ("Continuar", "CONTINUE");
			stringList.Add ("Nuevo", "NEW");

			//personalizacion
			stringList.Add ("Crea tu avatar", "CREATE YOUR AVATAR");

			//selec isla
			stringList.Add ("Selección de isla", "ISLAND SELECTION");

			//Tutorial
			stringList.Add ("Tutorial", "TUTORIAL");
			stringList.Add ("Haz click en el suelo para moverte", "CLICK ON THE GROUND TO MOVE");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "CLICK ON THE PETS TO TALK TO THEM");
			stringList.Add ("¡Hola!", "HELLO!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "PAUSE THE GAME TO ACCESS MAP AND CUSTOMIZATION");
			stringList.Add ("Accede a los portales para completar los ejercicios", "ACCESS THE PORTALS TO COMPLETE THE EXERCISES");

			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "WELCOME TO THE FOREST ISLAND");
			stringList.Add ("He perdido uno de mis:", "I LOST ONE OF MY:");
			stringList.Add ("Ayúdame a encontrarlo", "HELP ME FINDING IT PLEASE");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "THANKS FOR HELPING ME GET IT BACK!");

			//Menu
			stringList.Add ("Objetivos", "AIMS");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "GET 3 STARS ON ALL OF THE FOREST ISLAND EXERCISES");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "GET 3 STARS ON ALL PHANTOM ISLAND EXERCISES");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "GET 3 STARS ON ALL MECHANICAL ISLAND EXERCISES");
			stringList.Add ("Dado nivel 1", "DICE LEVEL 1");
			stringList.Add ("Dado nivel 2", "DICE LEVEL 2");
			stringList.Add ("Sonidos nivel 1", "SOUNDS LEVEL 1");
			stringList.Add ("Sonidos nivel 2", "SOUNDS LEVEL 2");
			stringList.Add ("Sonidos nivel 3", "SOUNDS LEVEL 3");
			stringList.Add ("Empatia nivel 1", "EMPATHY LEVEL 1");
			stringList.Add ("Empatia nivel 2", "EMPATHY LEVEL 2");
			stringList.Add ("Empatia nivel 3", "EMPATHY LEVEL 3");
			stringList.Add ("Emociones nivel 1", "EMOTIONS LEVEL 1");
			stringList.Add ("Emociones nivel 2", "EMOTIONS LEVEL 2");
			stringList.Add ("Emociones nivel 3", "EMOTIONS LEVEL 3");

			//DAdo
			stringList.Add ("Ejercicio dado", "DICE EXERCISE");
			stringList.Add ("Entrar", "GO IN");
			stringList.Add ("Selección de nivel", "LEVEL SELECTION");
			stringList.Add ("Haz click en el dado para lanzarlo", "CLICK ON THE DICE TO THROW IT");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "MATCH THE IMAGE WITH THE DICE TO EARN POINTS!");
			stringList.Add ("Nivel 2 desbloqueado", "LEVEL 2 UNLOCKED");
			stringList.Add ("Nivel 3 desbloqueado", "LEVEL 3 UNLOCKED");
			stringList.Add ("Nivel 1 Completado", "LEVEL 1 COMPLETED");
			stringList.Add ("Nivel 2 Completado", "LEVEL 3 COMPLETED");
			stringList.Add ("Nivel 3 Completado", "LEVEL 3 COMPLETED");
			stringList.Add ("Aciertos:", "HITS: ");
			stringList.Add ("Combos:", "COMBO:");
			stringList.Add ("Monedas:", "COINS:");
			stringList.Add ("Nivel 2 completado", "LEVEL 2 COMPLETED");

			stringList.Add ("TIRA", "THROW");
			stringList.Add ("EL", "THE");
			stringList.Add ("DADO", "DICE");

			stringList.Add ("Fresa", "STRAWBERRY");
			stringList.Add ("Pera", "PEAR");
			stringList.Add ("Platano", "BANANA");
			stringList.Add ("Copa", "DRINKING GLASS");
			stringList.Add ("Bombilla", "LIGHT BULB");
			stringList.Add ("LLave", "KEY");
			stringList.Add ("Percha", "HANGER");
			stringList.Add ("Taza", "CUP");
			stringList.Add ("Vaso", "GLASS");
			stringList.Add ("Sol", "SUN");
			stringList.Add ("Luna", "MOON");
			stringList.Add ("Estrella", "STAR");

			//SOnidos
			stringList.Add ("Ejercicio sonidos","SOUNDS EXERCISE");
			stringList.Add ("Pulsa PLAY para escuchar un sonido", "PRESS PLAY TO HEAR A SOUND");
			stringList.Add ("y REPLAY para repetirlo", "AND REPLAY TO HEAR IT AGAIN");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "CLICK ON THE IMAGE THAT CORRESPONDS TO THE SOUND");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "PRESS PLAY AGAIN TO CONTINUE PLAYING");
			stringList.Add ("Isla Fantasma desbloqueada", "GHOST ISLAND UNLOCKED");

			stringList.Add ("Isla Fantasma", "GHOST ISLAND");

			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "WELCOME TO THE GHOST ISLAND!");
			stringList.Add ("Mis:", "MY:");
			stringList.Add ("se han ro...ro..roto...", "ARE BRO...O..O..OKEN");
			stringList.Add ("Ayúdame a encontrar las piezas ", "HELP ME FINDING THE PIECES");

			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "SECUENCES EXERCISE");
			stringList.Add ("Lavarse los dientes", "BRUSH YOUR TEETH");
			stringList.Add ("Llamar por teléfono", "PHONE CALL");
			stringList.Add ("Comprar el pan", "BUY BREAD");
			stringList.Add ("Cruzar la calle", "CROSS THE ROAD");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "PLACE THE IMAGES IN THE FRAME IN THE CORRECT ORDER");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "PRESS ON THE IMAGES TO PLACE THEM!");
			stringList.Add ("¿Quieres salir?", "DO YOU WANNA TO QUIT?");
			stringList.Add ("Secuencia desbloqueada", "SEQUENCE UNLOCKED");
			stringList.Add ("Isla Mecanica Desbloqueada", "MECHANICAL ISLAND UNLOCKED");
			stringList.Add ("Secuencia completada", "SEQUENCE COMPLETED");

			//CANASTA
			stringList.Add ("Juego canasta", "BASKETBALL GAME");
			stringList.Add ("Canasta Completada", "BASKETBALL GAME COMPLETED");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "GET MORE POINTS THAN THE GHOST BY SCORING THE BASKET");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "CLICK ON THE BAR BELOW WHEN IT PASSES THE YELLOW MARKER");
			stringList.Add ("¡Hazlo tres veces para encestar!", "DO IT THREE TIMES TO SCORE!");
			stringList.Add ("Has perdido", "YOU LOSE");
			stringList.Add ("Has ganado", "YOU WIN");
			stringList.Add ("Espera tu turno...", "WAIT FOR YOUR TURN...");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "THANK YOU! YOU'VE FOUND MY GLASSES!");

			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "MECHANICAL ISLAND");

			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "WELCOME TO MECHANICAL ISALAND!");
			stringList.Add ("Me he quedado sin bateria...", "I RAN OUT OF BATTERY");
			stringList.Add ("Ayúdame a encontrar: ", "HELP ME FIND:");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias|", "GREAT! THANK YOU FOR FINDING MY BATTERIES!");

			//emociones
			stringList.Add ("Ejercicio emociones", "EMOTIONS EXERCISE");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "SELECT THE EMOTION THE ROBOT ASKS FOR");
			stringList.Add ("Arrastra las imagenes para verlas", "DRAG THE IMAGES TO SEE THEM");
			stringList.Add ("Pulsa la imagen que elijas", "CLICK ON THE IMAGE YOU CHOSE");
			stringList.Add ("Alegria", "JOY");
			stringList.Add ("Asco", "DISGUST");
			stringList.Add ("Enfado", "ANGER");
			stringList.Add ("Miedo", "FEAR");
			stringList.Add ("Sorpresa", "SURPRISE");
			stringList.Add ("Tristeza", "SADNESS");
			stringList.Add ("Vergüenza", "SHAME");
			stringList.Add ("Curiosidad", "CURIOSITY");
			stringList.Add ("Nerviosismo", "NERVOUSNESS");
			stringList.Add ("Tranquilidad", "CALM");

			//Empatia
			stringList.Add ("Ejercicio empatia", "EMPATHY EXERCISE");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "LOOK AT THE SITUATION ON THE BIG TV");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "SELECT HOW YOU THINK THAT PERSON WOULD FEEL");
			stringList.Add ("Pulsa la imagen para seleccionarla", "CLICK ON IMAGE TO SELECT IT");

			//Isla ALtar
			stringList.Add ("Isla Altar", "ALTAR ISLAND");
			stringList.Add ("Isla Altar Desbloqueada", "ALTAR ISLAND UNLOCKED");
			stringList.Add ("¡Felicidades!", "CONGRATULATIONS!");
			stringList.Add ("¡Felicidades! Has completado el juego", "CONGRATULATIONS! YOU HAVE COMPLETED THE GAME");
			stringList.Add ("Menú inicial", "START MENU");
			stringList.Add ("Créditos", "CREDITS");

			//Menu Final Demo
			stringList.Add ("¿Podras ganar al fantasma a baloncesto?", "COULD YOU WIN THE GHOST IN A BASKETBALL MATCH?");
			stringList.Add ("¡Explora la isla mecanica y completa nuevos juegos!", "EXPLORE MECHANICAL ISLAND AND COMPLETE MORE GAMES!");
			stringList.Add ("¿Seras capaz de llegar hasta el final?", "WILL YOU BE ABLE TO GET TO THE END?");
			stringList.Add ("¿Te atreves a adentrarte en la isla Fantasma?", "WILL YOU DARE TO VENTURE INTO PHANTOM ISLAND?");

			stringList.Add ("VALÓRANOS", "RATE US");
			stringList.Add ("¡GRACIAS POR JUGAR!", "¡THANKS FOR PLAYING!");

            //Control Parental
            stringList.Add("Pregunta a tus padres:", "ASK YOUR PARENTS:");
            stringList.Add("¿Eres mayor de edad?", "ARE YOU A GROWN-UP?");
            stringList.Add("Inserta tu año de nacimiento", "INSERT YOUR OWN BIRTH YEAR");
            stringList.Add("Debes tener más de 18 años para seguir", "YOU MUST BE OLDER THAN 18 YEARS OLD TO CONTINUE");
            stringList.Add("El año introducido no es valido. introduce un año de 4 digitos", "THE YEAR INTRODUCED IS NOT VALID, INSERT YOUR YEAR OF BIRTH");
        }

		
		if(lang=="Euskara")
		{

			stringList.Add("Seleccion de Idioma", "HIZKUNTZA AUKERATU");

			//print(lang);
			stringList.Add ("Español", "ESPAÑOL");
			stringList.Add ("Ingles", "INGLÉS");
			stringList.Add ("Euskera", "EUSKERA");
			stringList.Add ("FRANCES", "FRANCÉS");

			stringList.Add ("Fallos:", "AKATSAK:");

			stringList.Add ("¿SEGURO QUE QUIERES BORRAR LA PARTIDA?", "ZIRU PARTIDA EZABATU NAHI DUZULA?");
			stringList.Add ("SI", "BAI");
			stringList.Add ("NO", "EZ");
			//PANTALLA CARGA

			stringList.Add ("Cargando...", "KARGATZEN...");
			
			//intro
			stringList.Add ("Empezar", "HASI");
			stringList.Add ("Continuar", "JARRAITU");
			stringList.Add ("Nuevo", "BERRIA");
			
			//personalizacion
			stringList.Add ("Crea tu avatar", "ZURE PERTSONAIA SORTU");
			
			//selec isla
			stringList.Add ("Selección de isla", "UHARTE AUKERAKETA");
			
			//Tutorial
			stringList.Add ("Tutorial", "TUTORIALA");
			stringList.Add ("Haz click en el suelo para moverte", "LURREAN CLICK EGIN PERTSONAIA MUGI DEZAN");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "MASKOTETAN CLICK EGIN BERAIEKIN HITZ EGITEKO");
			stringList.Add ("¡Hola!", "Kaixo!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "PARTIDA GELDIARAZI MAPA ETA PERTSONAI SORKUNTZARA SARTU AHAL IZATEKO");
			stringList.Add ("Accede a los portales para completar los ejercicios", "PORTALETAN SARTU ARIKETAK OSATU DITZAZUN");
			
			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "ONGI ETORRI BASO UHARTERA!");
			stringList.Add ("He perdido uno de mis:", "NIRE GALDU EGIN DUT");
			stringList.Add ("Ayúdame a encontrarlo", "AURKITU EZAZU MESEDEZ");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "ESKERRIK ASKO AURKITU IZANAGATIK");
			
			//Menu
			stringList.Add ("Objetivos", "HELBURUAK");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "BASO UHARTEKO ARIKETA GUZTIETAN HIRU IZAR LOR ITZAZU");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "MAMU UHARTEKO ARIKETA GUZTIETAN HIRU IZAR LOR ITZAZU");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "MEKANIKOA UHARTEKO ARIKETA GUZTIETAN HIRU IZAR LOR ITZAZU");
			stringList.Add ("Dado nivel 1", "DADO 1 MALLA");
			stringList.Add ("Dado nivel 2", "DADO 2 MALLA");
			stringList.Add ("Sonidos nivel 1", "SOINUAK 1 MALLA");
			stringList.Add ("Sonidos nivel 2", "SOINUAK 2 MALLA");
			stringList.Add ("Sonidos nivel 3", "SOINUAK 3 MALLA");
			stringList.Add ("Empatia nivel 1", "ENPATIA 1 MALLA");
			stringList.Add ("Empatia nivel 2", "ENPATIA 2 MALLA");
			stringList.Add ("Empatia nivel 3", "ENPATIA 3 MALLA");
			stringList.Add ("Emociones nivel 1", "EMOZIOEN 1 MALLA");
			stringList.Add ("Emociones nivel 2", "EMOZIOEN 2 MALLA");
			stringList.Add ("Emociones nivel 3", "EMOZIOEN 3 MALLA");
			
			//DAdo
			stringList.Add ("Ejercicio dado", "DADO ARIKETA");
			stringList.Add ("Entrar", "SARTU");
			stringList.Add ("Selección de nivel", "MAILA AUKERAKETA");
			stringList.Add ("Haz click en el dado para lanzarlo", "DADOAN CLICK EGIN JAURTI DEZAZUN");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "IRUDIA DADOAREKIN BATU PUNTUAK IRABAZI DITZAZUN!");
			stringList.Add ("Nivel 2 desbloqueado", "2 MAILA PREST");
			stringList.Add ("Nivel 3 desbloqueado", "3 MAILA PREST");
			stringList.Add ("Nivel 1 Completado", "1 MAILA OSATUTA");
			stringList.Add ("Nivel 2 Completado", "2 MAILA OSATUTA");
			stringList.Add ("Nivel 3 Completado", "3 MAILA OSATUTA");
			stringList.Add ("Aciertos:", "ASMATUTAKOAK: ");
			stringList.Add ("Combos:", "KATEAK: ");
			stringList.Add ("Monedas:", "TXANPONAK: ");
			stringList.Add ("Nivel 2 completado", "2 MAILA OSATUTA");
			
			stringList.Add ("TIRA", "DADOA");
			stringList.Add ("EL", "BOTA");
			stringList.Add ("DADO", "EZAZU");
			
			stringList.Add ("Fresa", "MARRUBIA");
			stringList.Add ("Pera", "UDAREA");
			stringList.Add ("Platano", "BANANA");
			stringList.Add ("Copa", "KOPA");
			stringList.Add ("Bombilla", "BONBILLA");
			stringList.Add ("LLave", "GILTZA");
			stringList.Add ("Percha", "ESEKIGAILUA");
			stringList.Add ("Taza", "KATILUA");
			stringList.Add ("Vaso", "EDALONTZIA");
			stringList.Add ("Sol", "EGUZKIA");
			stringList.Add ("Luna", "ILARGIA");
			stringList.Add ("Estrella", "IZARRA");
			
			//SOnidos
			stringList.Add ("Ejercicio sonidos","SOINU ARIKETA");
			stringList.Add ("Pulsa PLAY para escuchar un sonido", "PLAY BOTOIA SAKATU SOINU BAT ETZUTEKO");
			stringList.Add ("y REPLAY para repetirlo", "REPLAY BOTOIA SAKATU SOINU BERA ENTZUTAKO");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "ENTZUTAKO SOINUARI DAGOKION IRUDA SAKATU");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "PLAY BOTOIA BERRIRO SAKATU JOLASTEN JARAITZEKO");
			stringList.Add ("Isla Fantasma desbloqueada", "MAMU UHARTEA DESBLOKEATUA");
			
			stringList.Add ("Isla Fantasma", "MAMU UHARTEA");
			
			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "ONGI ETORRI MAMI UHARTERA!");
			stringList.Add ("Mis:", "NIRE:");
			stringList.Add ("se han ro...ro..roto...", "BETA..A..A..AURREKOAK HAUTSI DIRA");
			stringList.Add ("Ayúdame a encontrar las piezas ", "ZATI GUZTIAK AURKITZEN LAGUNDU NAZAZU MESEDEZ");
			
			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "EKINTZA-SAILA ARIKETA");
			stringList.Add ("Lavarse los dientes", "HORTZAK GARBITU");
			stringList.Add ("Llamar por teléfono", "TELEFONOZ DEITU");
			stringList.Add ("Comprar el pan", "OGIA EROSI");
			stringList.Add ("Cruzar la calle", "ERREPIDEA GURURZATU");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "IRUDIAK MARKOAN ORDEN ZUZENEAN JARRI");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "IRUDIAK SAKATUZ KOKA ITZAZU!");
			stringList.Add ("¿Quieres salir?", "IRTEN NAHI DUZU?");
			stringList.Add ("Secuencia desbloqueada", "EKINTZA PREST");
			stringList.Add ("Isla Mecanica Desbloqueada", "UHARTE MEKANIKOA DESBLOKEATUA");
			stringList.Add ("Secuencia completada", "EKINTZA-SAILA OSATUTA");
			
			//CANASTA
			stringList.Add ("Juego canasta", "SASKIBALOI JOKOA");
			stringList.Add ("Canasta Completada", "SASKIBALOI JOKOA OSATUTA");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "BALOIA SASKIRATU MAMUA BAINO PUNTU GEHIO LORTZEKO");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "BEHEKO BARRA SAKATU HUTSUNE HORIA GAINDITZEN DUENEAN");
			stringList.Add ("¡Hazlo tres veces para encestar!", "HIRU ALDIZ SAKATU EZAZU SASKIRATZEKO!");
			stringList.Add ("Has perdido", "HUTS EGIN DUZU");
			stringList.Add ("Has ganado", "IRABAZI DUZU");
			stringList.Add ("Espera tu turno...", "ITXARON ZURE TXANDA...");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "ESKERRIK ASKO! NIRE BETAURREKOAK AURKITU DITUZU!");
			
			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "UHARTE MEKANIKOA");
			
			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "ONGI ETORRI UHASTE MEKANIKORA!");
			stringList.Add ("Me he quedado sin bateria...", "BATERIA AGORTU ZAIT...");
			stringList.Add ("Ayúdame a encontrar: ", "AURKITZEN LAGUNDU NAZAZU");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias|", "BIKAIN! ESKERRIK ASKO LAGUNDU IZANAGATIK!");
			
			//emociones
			stringList.Add ("Ejercicio emociones", "EMOZIOEN ARIKETA");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "ROBOTAK GALDETUTAKO EMOZIOA AUKERATU");
			stringList.Add ("Arrastra las imagenes para verlas", "IRUDIAK MUGITU GUZTIAK IKUSI AHAL IZATEKO");
			stringList.Add ("Pulsa la imagen que elijas", "AUKERATUTAKO IRUDIA SAKATU");
			stringList.Add ("Alegria", "POZA");
			stringList.Add ("Asco", "NAZKA");
			stringList.Add ("Enfado", "HASERRALDI");
			stringList.Add ("Miedo", "BELDURRA");
			stringList.Add ("Sorpresa", "HARRIDURA");
			stringList.Add ("Tristeza", "GOIBELTASUNA");
			stringList.Add ("Vergüenza", "LOTSA");
			stringList.Add ("Curiosidad", "JAKINGURA");
			stringList.Add ("Nerviosismo", "URDURITASUN");
			stringList.Add ("Tranquilidad", "LASAITASUNA");
			
			//Empatia
			stringList.Add ("Ejercicio empatia", "ENPATIA ARIKETA");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "TELEBISTAN AGARTZEN DIREN IRUDIAK IKUSI");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "IRUSIETAN AGERTZEN DEN PERTSONA NOLA SENTITZEN DEN AUKERATU");
			stringList.Add ("Pulsa la imagen para seleccionarla", "IRUSIA SAKATU AUKERATU AHAL IZATEKO");
			
			//Isla ALtar
			stringList.Add ("Isla Altar", "ALDERE UHARTEA");
			stringList.Add ("Isla Altar Desbloqueada", "UHARTE ALDERE DESBLOKEATUA");
			stringList.Add ("¡Felicidades!", "ZORIONAK!");
			stringList.Add ("¡Felicidades! Has completado el juego", "ZORIONAK! JOKOA OSATU DUZU");
			stringList.Add ("Menú inicial", "HASIERAKO MENUA");
			stringList.Add ("Créditos", "KREDITUAK");

			//Menu Final Demo
			stringList.Add ("¿Podras ganar al fantasma a baloncesto?", "MAMUA SASKIBALOIRA IRABAZIKO ZENUKE?");
			stringList.Add ("¡Explora la isla mecanica y completa nuevos juegos!", "UHARTE MEKANIKOA AZTERTU ETA JOKO GEHIAGO OSATU!");
			stringList.Add ("¿Seras capaz de llegar hasta el final?", "BUKAERA ARTE IRISTEKO GAI IZANGO ZARA?");
			stringList.Add ("¿Te atreves a adentrarte en la isla Fantasma?", "MAMU UHARTEAN BARNERATZEN AUSARTZEN ZARA?");

			stringList.Add ("VALÓRANOS", "PUNTUATU GAITZAZU");
			stringList.Add ("¡GRACIAS POR JUGAR!", "¡ESKERRIK ASKO JOKATZEAGATIK!");

            //Control Parental
            stringList.Add("Pregunta a tus padres:", "ZURE GURASOEI GALDETU:");
            stringList.Add("¿Eres mayor de edad?", "18 URTE EDO GEHIO DITUZU?");
            stringList.Add("Inserta tu año de nacimiento", "ZURE JAIOTZE URTEA SARTU");
            stringList.Add("Debes tener más de 18 años para seguir", "18 URTE BAINO GEHIO IZAN BEHAR DITUZU JARRAITZEKO");
            stringList.Add("El año introducido no es valido. introduce un año de 4 digitos", "SARTUTAKO URTEA EZ DA ZUZENA, JAIO ZINEN URTEA SARTU EZAZU");
        }

		if(lang=="Frances")
		{
			stringList.Add("Seleccion de Idioma", "CHOISIR LA LANGUE");
			
			stringList.Add ("Español", "ESPAGNOL");
			stringList.Add ("Ingles", "ANGLAIS");
			stringList.Add ("Euskera", "EUSKERA");
			stringList.Add ("FRANCES", "FRANÇAIS");
			
			stringList.Add ("Fallos:", "ERREURS:");
			
			stringList.Add ("Cargando...", "CHARGER...");
			
			stringList.Add ("¿SEGURO QUE QUIERES BORRAR LA PARTIDA?", "VOULEZ-VOUS VRAIMENT QUITTER LE JEU?");
			stringList.Add ("SI", "OUI");
			stringList.Add ("NO", "NON");
			
			//intro
			stringList.Add ("Empezar", "COMMENCER");
			stringList.Add ("Continuar", "CONTINUER");
			stringList.Add ("Nuevo", "NOUVEAU");
			
			//personalizacion
			stringList.Add ("Crea tu avatar", "CRÉEZ VOTRE AVATAR");
			
			//selec isla
			stringList.Add ("Selección de isla", "SÉLECTION D'ÎLE");
			
			//Tutorial
			stringList.Add ("Tutorial", "TUTORIEL");
			stringList.Add ("Haz click en el suelo para moverte", "CLIQUEZ SUR LA TERRE POUR VOUS DÉPLACER");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "CLIQUEZ SUR LES MASCOTTES POUR LEUR PARLER");
			stringList.Add ("¡Hola!", "SALUT!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "METTEZ LA PARTIE EN PAUSE POUR ACCÉDER À CARTE ET CUSTOMISATION");
			stringList.Add ("Accede a los portales para completar los ejercicios", "ACCÉDEZ AUX PORTAILS POUR COMPLÉTER LES EXERCISES");
			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "BIENVENUE SUR L'ÎLE FORÊT!");
			stringList.Add ("He perdido uno de mis:", ":");
			stringList.Add ("Ayúdame a encontrarlo", "");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "");
			
			//Menu
			stringList.Add ("Objetivos", "OBJECTIFS");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "OBTENEZ TROIS ÉTOILES DANS TOUS LES EXERCISES SUR L'ÎLE FORÊT");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "OBTENEZ TROIS ÉTOILE DANS TOUS LES EXERCICES SUR L'ÎLE FANTÔME");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "OBTENEZ TROIS ÉTOILE DANS TOUS LES EXERCICES SUR L'ÎLE MÉCANIQUE");
			stringList.Add ("Dado nivel 1", "DÉ NIVEAU 1");
			stringList.Add ("Dado nivel 2", "DÉ NIVEAU 2");
			stringList.Add ("Sonidos nivel 1", "SONS NIVEAU 1");
			stringList.Add ("Sonidos nivel 2", "SONS NIVEAU 2");
			stringList.Add ("Sonidos nivel 3", "SONS NIVEAU 3");
			stringList.Add ("Empatia nivel 1", "EMPATHIE NIVEAU 1");
			stringList.Add ("Empatia nivel 2", "EMPATHIE NIVEAU 2");
			stringList.Add ("Empatia nivel 3", "EMPATHIE NIVEAU 3");
			stringList.Add ("Emociones nivel 1", "ÉMOTIONS NIVEAU 1");
			stringList.Add ("Emociones nivel 2", "ÉMOTIONS NIVEAU 2");
			stringList.Add ("Emociones nivel 3", "ÉMOTIONS NIVEAU 3");
			
			//DAdo
			stringList.Add ("Ejercicio dado", "EXERCICE DE DÉ");
			stringList.Add ("Entrar", "ENTRER");
			stringList.Add ("Selección de nivel", "CHOIX DE NIVEAU");
			stringList.Add ("Haz click en el dado para lanzarlo", "CLIQUEZ SUR LE DÉ POUR LE LANCER");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "METTEZ L'IMAGE ET LE DÉ ENSEMBLE POUR GAGNER DES POINTS!");
			stringList.Add ("Nivel 2 desbloqueado", "NIVEAU 2 DÉBLOQUÉ");
			stringList.Add ("Nivel 3 desbloqueado", "NIVEAU 3 DÉBLOQUÉ");
			stringList.Add ("Nivel 1 Completado", "NIVEAU 1 COMPLÉTÉ");
			stringList.Add ("Nivel 2 Completado", "NIVEAU 2 COMPLÉTÉ");
			stringList.Add ("Nivel 3 Completado", "NIVEAU 3 COMPLÉTÉ");
			stringList.Add ("Aciertos:", "BONNES RÉPONSES: ");
			stringList.Add ("Combos:", "COMBOS: ");
			stringList.Add ("Monedas:", "PIÈCES: ");
			stringList.Add ("Nivel 2 completado", "NIVEAU 2 COMPLÉTÉ");
			
			stringList.Add ("TIRA", "LANCEZ");
			stringList.Add ("EL", "LE");
			stringList.Add ("DADO", "DÉ");
			
			stringList.Add ("Fresa", "FRAISE");
			stringList.Add ("Pera", "POIRE");
			stringList.Add ("Platano", "BANANE");
			stringList.Add ("Copa", "VERRE À PIED");
			stringList.Add ("Bombilla", "AMPOULE");
			stringList.Add ("LLave", "CLÉ");
			stringList.Add ("Percha", "CINTRE");
			stringList.Add ("Taza", "TASSE");
			stringList.Add ("Vaso", "VERRE");
			stringList.Add ("Sol", "SOLEIL");
			stringList.Add ("Luna", "LUNE");
			stringList.Add ("Estrella", "ÉTOILE");
			
			//SOnidos
			stringList.Add ("Ejercicio sonidos","EXERCICE DE SONS");
			stringList.Add ("Pulsa PLAY para escuchar un sonido", "APPUYEZ SUR PALY POUR ÉCOUTER UN SON");
			stringList.Add ("y REPLAY para repetirlo", "ET REPLAY POUR L'ÉCOUTER DE NOUVEAU");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "CLIQUEZ SUR L'IMAGE QUI CORRESPOND AU SON");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "APPUYEZ SUR L'IMAGE QUI CORRESPOND AU SON");
			stringList.Add ("Isla Fantasma desbloqueada", "L'ILE FANTÔME DÉBLOQUÉ");
			
			stringList.Add ("Isla Fantasma", "ISLA FANTASMA");
			
			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "BIENVENUE SUR L'ÎLE FANTÔME!");
			stringList.Add ("Mis:", "MES:");
			stringList.Add ("se han ro...ro..roto...", "SONT CA.. CA.. CASSÉES...");
			stringList.Add ("Ayúdame a encontrar las piezas", "AIDEZ-MOI À RETROUVER LES PIÈCES");
			
			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "EXERCICE DE SÉQUENCES");
			stringList.Add ("Lavarse los dientes", "BROSSE-TOI LES DENTS");
			stringList.Add ("Llamar por teléfono", "APPELER PAR TÉLÉPHONE");
			stringList.Add ("Comprar el pan", "ACHETER DU PAIN");
			stringList.Add ("Cruzar la calle", "TRAVERSER LA RUE");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "RANGEZ LES IMAGES DEDANS LE CADRE À L'ORDRE CORRECT");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "APPUYEZ SUR LES IMAGES POUR LES RANGER!");
			stringList.Add ("¿Quieres salir?", "VOULEZ-VOUS SORTIR?");
			stringList.Add ("Secuencia desbloqueada", "SÉQUENCE DÉBLOQUÉE");
			stringList.Add ("Isla Mecanica Desbloqueada", "L'ÎLE MÉCANIQUE DÉBLOQUÉE");
			stringList.Add ("Secuencia completada", "SÉQUENCE COMPLÉTÉE");
			
			//CANASTA
			stringList.Add ("Juego canasta", "JEU DE BASKET-BALL");
			stringList.Add ("Canasta Completada", "BASKET-BALL COMPLÉTÉE");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "OBTENEZ PLUS DE POINTS QUE LE FANTÔME EN MARQUANT LE PANIER!");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "CLIQUEZ SUR LA BARRE DESSOUS QUAND IL PASSE LA MARQUE JAUNE");
			stringList.Add ("¡Hazlo tres veces para encestar!", "FAIS-LE TROIS FOIS POUR MARQUER LE PANIER!");
			stringList.Add ("Has perdido", "VOUS AVEZ PERDU");
			stringList.Add ("Has ganado", "VOUS GAGNEZ");
			stringList.Add ("Espera tu turno...", "ATTENDEZ VOTRE TOUR…");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "MERCI! VOUS AVEZ TROUVÉ MES LUNETTES!");
			
			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "L'ÎLE MÉCANIQUE");
			
			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "BIENVENUE SUR L'ÎLE MÉCANIQUE!");
			stringList.Add ("Me he quedado sin bateria...", "JE M'AI PLUS DE BATTERIE...");
			stringList.Add ("Ayúdame a encontrar: ", "AIDEZ-MOI TROUVER: ");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias!", "¡GENIAL! ¡GRACIAS POR ENCONTRAR MIS BATERIAS!");
			
			//emociones
			stringList.Add ("Ejercicio emociones", "EXERCICE D'ÉMOTIONS");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "LE ROBOT DEMANDE SUR UNE ÉMOTION, SÉLECTIONNEZ-LA");
			stringList.Add ("Arrastra las imagenes para verlas", "GLISSEZ LES IMAGES POUR LES VOIR");
			stringList.Add ("Pulsa la imagen que elijas", "APPUYEZ SUR L'IMAGE QUE VOUS CHOISISSEZ");
			stringList.Add ("Alegria", "JOIE");
			stringList.Add ("Asco", "DÉGOÛT");
			stringList.Add ("Enfado", "COLÉRE");
			stringList.Add ("Miedo", "PEUR");
			stringList.Add ("Sorpresa", "SURPRISE");
			stringList.Add ("Tristeza", "TRISTESSE");
			stringList.Add ("Vergüenza", "HONTE");
			stringList.Add ("Curiosidad", "CURIOSITÉ");
			stringList.Add ("Nerviosismo", "NERVOSITÉ");
			stringList.Add ("Tranquilidad", "CALME");
			
			//Empatia
			stringList.Add ("Ejercicio empatia", "EXERCICE D'EMPATHIE");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "OBSERVEZ LA SCÈNE À LA TÉLÉVISION GRANDE");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "CHOISISSEZ COMMENT VOUS PENDEZ QUE CETTE PERSONNE SE SENTIRAIT");
			stringList.Add ("Pulsa la imagen para seleccionarla", "APPUYEZ SUR L'IMAGE POUR LA SÉLECTIONNER");
			
			//Isla ALtar
			stringList.Add ("Isla Altar", "ÎLE AUTEL");
			stringList.Add ("Isla Altar Desbloqueada", "L'ÎLE AUTEL DÉBLOQUÉE");
			stringList.Add ("¡Felicidades!", "FÉLICITATIONS!");
			stringList.Add ("¡Felicidades! Has completado el juego", "FÉLICITATIONS! VOUS AVEZ COMPLÉTÉ LE JEU");
			stringList.Add ("Menú inicial", "MENU INITIAL");
			stringList.Add ("Créditos", "CRÉDITS");

			//Menu Final Demo
			stringList.Add ("¿Podras ganar al fantasma a baloncesto?", "COULD YOU WIN THE GHOST IN A BASKETBALL MATCH?");
			stringList.Add ("¡Explora la isla mecanica y completa nuevos juegos!", "EXPLORE MECHANICAL ISLAND AND COMPLETE MORE GAMES!");
			stringList.Add ("¿Seras capaz de llegar hasta el final?", "WILL YOU BE ABLE TO GET TO THE END?");
			stringList.Add ("¿Te atreves a adentrarte en la isla Fantasma?", "WILL YOU DARE TO VENTURE INTO PHANTOM ISLAND?");

			stringList.Add ("VALÓRANOS", "ÉVALUEZ-NOUS");
			stringList.Add ("¡GRACIAS POR JUGAR!", "MERCI DE JOUER!");

            //Control Parental
            stringList.Add("Pregunta a tus padres:", "DEMANDE À TES PARENTS");
            stringList.Add("¿Eres mayor de edad?", "ÊTES-VOUS UN ADULTE?");
            stringList.Add("Inserta tu año de nacimiento", "INSÉREZ VOTRE ANNÉE DE NAISSANCE");
            stringList.Add("Debes tener más de 18 años para seguir", "VOUS DEVEZ AVOIR PLUS DE 18 ANS POUR SUIVRE");
            stringList.Add("El año introducido no es valido. introduce un año de 4 digitos", "L'ANNÉE PRÉSENTÉE N'EST PAS VALIDE, INTRODUISEZ VOTRE ANNÉE DE NAISSANCE");
        }
	}
}

