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

			stringList.Add ("Cargando...", "Cargando...");
			
			//intro
			stringList.Add ("Empezar", "Empezar");
			stringList.Add ("Continuar", "Continuar");
			stringList.Add ("Nuevo", "Nuevo");
			
			//personalizacion
			stringList.Add ("Crea tu avatar", "Crea tu avatar");
			
			//selec isla
			stringList.Add ("Selección de isla", "Selección de isla");
			
			//Tutorial
			stringList.Add ("Tutorial", "Tutorial");
			stringList.Add ("Haz click en el suelo para moverte", "Haz click en el suelo para moverte");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "Interactua con las mascotas haciendo click en ellas");
			stringList.Add ("¡Hola!", "¡Hola!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "Pausa la partida para acceder a mapa y personalización");
			stringList.Add ("Accede a los portales para completar los ejercicios", "Accede a los portales para completar los ejercicios");
			
			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "¡Bienvenido a la isla bosque!");
			stringList.Add ("He perdido uno de mis:", "He perdido uno de mis:");
			stringList.Add ("Ayúdame a encontrarlo", "Ayúdame a encontrarlo");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "¡Gracias por ayudarme a recuperarlo!");
			
			//Menu
			stringList.Add ("Objetivos", "Objetivos");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "Consigue 3 estrellas en todos los ejercicios de la isla bosque");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "Consigue 3 estrellas en todos los ejercicios de la isla Fantasma");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "Consigue 3 estrellas en todos los ejercicios de la isla Mecanica");
			stringList.Add ("Dado nivel 1", "Dado nivel 1");
			stringList.Add ("Dado nivel 2", "Dado nivel 2");
			stringList.Add ("Sonidos nivel 1", "Sonidos nivel 1");
			stringList.Add ("Sonidos nivel 2", "Sonidos nivel 2");
			stringList.Add ("Sonidos nivel 3", "Sonidos nivel 3");
			
			//DAdo
			stringList.Add ("Ejercicio dado", "Ejercicio dado");
			stringList.Add ("Entrar", "Entrar");
			stringList.Add ("Selección de nivel", "Selección de nivel");
			stringList.Add ("Haz click en el dado para lanzarlo", "Haz click en el dado para lanzarlo");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "¡Empareja la imagen con el dado para ganar puntos!");
			stringList.Add ("Nivel 2 desbloqueado", "Nivel 2 desbloqueado");
			stringList.Add ("Nivel 1 Completado", "Nivel 1 Completado");
			stringList.Add ("Aciertos: ", "Aciertos: ");
			stringList.Add ("Combos: ", "Combos: ");
			stringList.Add ("Monedas: ", "Monedas: ");
			stringList.Add ("Nivel 2 completado", "Nivel 2 completado");
			
			stringList.Add ("TIRA", "TIRA");
			stringList.Add ("EL", "EL");
			stringList.Add ("DADO", "DADO");
			
			stringList.Add ("Fresa", "Fresa");
			stringList.Add ("Pera", "Pera");
			stringList.Add ("Platano", "Platano");
			stringList.Add ("Copa", "Copa");
			stringList.Add ("Bombilla", "bombilla");
			stringList.Add ("LLave", "Llave");
			stringList.Add ("Percha", "Percha");
			stringList.Add ("Taza", "Copa");
			stringList.Add ("Vaso", "Vaso");
			stringList.Add ("Sol", "Sol");
			stringList.Add ("Luna", "Luna");
			stringList.Add ("Estrella", "Estrella");
			
			//SOnidos
			stringList.Add ("Ejercicios sonidos","Ejercicios sonidos");
			stringList.Add ("Pulsa PLAY para escuchar un sonido ", "Pulsa Play para escuchar en sonido");
			stringList.Add ("y REPLAY para repetirlo", "y REPLAY para repetirlo");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "Haz click en la imagen que corresponda al sonido");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "Pulsa PLAY de nuevo para seguir jugando");
			stringList.Add ("Isla Fantasma desbloqueada", "Isla Fantasma desbloqueada");
			
			stringList.Add ("Isla Fantasma", "Isla Fantasma");
			
			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "¡Bienvenido a la isla fantasma!");
			stringList.Add ("Mis:", "Mis:");
			stringList.Add ("se han ro...ro..roto...", "se han ro...ro..roto...");
			stringList.Add ("Ayúdame a encontrar las piezas", "Ayúdame a encontrar las piezas");
			
			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "Ejercicio secuencias");
			stringList.Add ("Lavarse los dientes", "Lavarse los dientes");
			stringList.Add ("Llamar por teléfono", "Llamar por teléfono");
			stringList.Add ("Comprar pan", "Comprar pan");
			stringList.Add ("Cruzar la calle", "Cruzar la calle");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "Coloca las imagenes en el marco en el orden correcto");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "¡Haz click en ellas para colocarlas!");
			stringList.Add ("¿Quieres salir?", "¿Quieres salir?");
			stringList.Add ("Secuencia desbloqueada", "Secuencia desbloqueada");
			stringList.Add ("Isla Mecanica Desbloqueada", "Isla Mecanica Desbloqueada");
			
			//CANASTA
			stringList.Add ("Juego canasta", "Juego canasta");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "¡Consigue más puntos que el fantasma encestando!");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "Haz click en la barra cuando pase la barra amarilla");
			stringList.Add ("¡Hazlo tres veces para encestar!", "¡Hazlo tres veces para encestar!");
			stringList.Add ("Has perdido", "Has perdido");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "¡GRACIAS! ¡Has logrado encontrar mis gafas!");
			
			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "Isla Mecanica");
			
			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "¡Bienvenido a isla Mecanica!");
			stringList.Add ("Me he quedado sin bateria...", "Me he quedado sin bateria...");
			stringList.Add ("Ayúdame a encontrar: ", "Ayúdame a encontrar: ");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias!", "¡Genial! ¡Gracias por encontrar mis baterias!");
			
			//emociones
			stringList.Add ("Ejercicio emociones", "Ejercicio emociones");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "Selecciona la emoción por la que te pregunta el robot");
			stringList.Add ("Arrastra la imagen para verlas", "Arrastra la imagen para verlas");
			stringList.Add ("Pulsa la imagen que elijas", "Pulsa la imagen que elijas");
			stringList.Add ("Alegria", "Alegria");
			stringList.Add ("Asco", "Asco");
			stringList.Add ("Enfado", "Enfado");
			stringList.Add ("Miedo", "Miedo");
			stringList.Add ("Sorpresa", "Sorpresa");
			stringList.Add ("Tristeza", "Tristeza");
			stringList.Add ("Vergüenza", "Vergüenza");
			stringList.Add ("Curiosidad", "Curiosidad");
			stringList.Add ("Nerviosismo", "Nerviosismo");
			stringList.Add ("Tranquilidad", "Tranquilidad");
			
			//Empatia
			stringList.Add ("Ejercicio empatia", "Ejercicio empatia");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "Observa la situación que se plantea en la tele grande");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "Selecciona como crees que se sentiría esa persona");
			stringList.Add ("Pulsa la imagen para seleccionarla", "Pulsa la imagen para seleccionarla");
			
			//Isla ALtar
			stringList.Add ("Isla Altar", "Isla Altar");
			stringList.Add ("¡Felicidades!", "¡Felicidades!");
			stringList.Add ("¡Felicidades! Has completado el juego", "¡Felicidades! Has completado el juego");
			stringList.Add ("Menú inicial", "Menú inicial");
			stringList.Add ("Créditos", "Créditos");
		}

		if(lang=="English")
		{
			//print(lang);
			//PANTALLA CARGA
			stringList.Add ("Cargando...", "Loading...");

			//intro
			stringList.Add ("Empezar", "Start");
			stringList.Add ("Continuar", "Continue");
			stringList.Add ("Nuevo", "New");

			//personalizacion
			stringList.Add ("Crea tu avatar", "Create your avatar");

			//selec isla
			stringList.Add ("Selección de isla", "Island selection");

			//Tutorial
			stringList.Add ("Tutorial", "Tutorial");
			stringList.Add ("Haz click en el suelo para moverte", "Click on the floor to move");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "Click on the pets to talk to them");
			stringList.Add ("¡Hola!", "Hello!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "Pause the game to access map and personalization");
			stringList.Add ("Accede a los portales para completar los ejercicios", "Access the portals to complete the exercises");

			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "Welcome to the forest island");
			stringList.Add ("He perdido uno de mis:", "I lost one of my:");
			stringList.Add ("Ayúdame a encontrarlo", "Help me finding it please");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "Thanks for helping me getting it back!");

			//Menu
			stringList.Add ("Objetivos", "Aims");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "Get 3 stars on all of the forest island exercises");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "Get 3 stars on all Phantom island exercises");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "Get 3 stars on all Mechanical island exercises");
			stringList.Add ("Dado nivel 1", "Dice level 1");
			stringList.Add ("Dado nivel 2", "Dice level 2");
			stringList.Add ("Sonidos nivel 1", "Sounds level 1");
			stringList.Add ("Sonidos nivel 2", "Sounds level 2");
			stringList.Add ("Sonidos nivel 3", "Sounds level 3");

			//DAdo
			stringList.Add ("Ejercicio dado", "Dice exercise");
			stringList.Add ("Entrar", "Go in");
			stringList.Add ("Selección de nivel", "Level selection");
			stringList.Add ("Haz click en el dado para lanzarlo", "Click on the dice to throw it");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "Match the image with the dice to earn points!");
			stringList.Add ("Nivel 2 desbloqueado", "Level 2 unlocked");
			stringList.Add ("Nivel 1 Completado", "Level 1 Completed");
			stringList.Add ("Aciertos:", "Hits: ");
			stringList.Add ("Combos:", "Combo:");
			stringList.Add ("Monedas:", "Coins:");
			stringList.Add ("Nivel 2 completado", "Level 2 completed");

			stringList.Add ("TIRA", "THROW");
			stringList.Add ("EL", "THE");
			stringList.Add ("DADO", "DICE");

			stringList.Add ("Fresa", "Strawberry");
			stringList.Add ("Pera", "Pear");
			stringList.Add ("Platano", "Banana");
			stringList.Add ("Copa", "Drinking glass");
			stringList.Add ("Bombilla", "Light bulb");
			stringList.Add ("LLave", "Key");
			stringList.Add ("Percha", "Hanger");
			stringList.Add ("Taza", "Cup");
			stringList.Add ("Vaso", "Glass");
			stringList.Add ("Sol", "Sun");
			stringList.Add ("Luna", "Moon");
			stringList.Add ("Estrella", "Star");

			//SOnidos
			stringList.Add ("Ejercicios sonidos","Sounds exercise");
			stringList.Add ("Pulsa PLAY para escuchar un sonido ", "Press PLAY to hear a sound");
			stringList.Add ("y REPAY para repetirlo", "and REPLAY to hear it again");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "Click on the image that corresponds to the sound");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "Press PLAY again to continue playing");
			stringList.Add ("Isla Fantasma desbloqueada", "Ghost island unlocked");

			stringList.Add ("Isla Fantasma", "Ghost island");

			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "Welcome to the ghost island!");
			stringList.Add ("Mis:", "My:");
			stringList.Add ("se han ro...ro..roto...", "are bro...o...o..oken");
			stringList.Add ("Ayúdame a encontrar las piezas ", "Help me finding the pieces");

			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "Sequences exercise");
			stringList.Add ("Lavarse los dientes", "Brush your teeth");
			stringList.Add ("Llamar por teléfono", "Phone call");
			stringList.Add ("Comprar pan", "Buy");
			stringList.Add ("Cruzar la calle", "Cross the road");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "Place the images in the frame in the correct order");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "Press the images to place them!");
			stringList.Add ("¿Quieres salir?", "Do you wanna to quit?");
			stringList.Add ("Secuencia desbloqueada", "Sequence unlocked");
			stringList.Add ("Isla Mecanica Desbloqueada", "Mechanical island Unlocked");

			//CANASTA
			stringList.Add ("Juego canasta", "Basketball game");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "Get  more points than the ghost by scoring the basket");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "Click on the bar below when it passes the yellow marker");
			stringList.Add ("¡Hazlo tres veces para encestar!", "Do it three times to score!");
			stringList.Add ("Has perdido", "You lose");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "Thank you! you've found my glasses!");

			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "Mechanical islad");

			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "Welcome to Mechanical Island!");
			stringList.Add ("Me he quedado sin bateria...", "I ran out of battery");
			stringList.Add ("Ayúdame a encontrar: ", "Help me find:");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias|", "Great! Thank you for finding my batteries!");

			//emociones
			stringList.Add ("Ejercicio emociones", "Emotions exercise");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "Select the emotion the robot asks for");
			stringList.Add ("Arrastra la imagen para verlas", "Drag the images to see them");
			stringList.Add ("Pulsa la imagen que elijas", "Click on the image you chose");
			stringList.Add ("Alegria", "Joy");
			stringList.Add ("Asco", "Disgust");
			stringList.Add ("Enfado", "Anger");
			stringList.Add ("Miedo", "Fear");
			stringList.Add ("Sorpresa", "Surprise");
			stringList.Add ("Tristeza", "SAdness");
			stringList.Add ("Vergüenza", "Shame");
			stringList.Add ("Curiosidad", "Curiosity");
			stringList.Add ("Nerviosismo", "Nervousness");
			stringList.Add ("Tranquilidad", "Clam");

			//Empatia
			stringList.Add ("Ejercicio empatia", "Empathy exercise");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "Look at the situation on the big TV");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "Select how you think that person would feel");
			stringList.Add ("Pulsa la imagen para seleccionarla", "Click on image to select it");

			//Isla ALtar
			stringList.Add ("Isla Altar", "Altar islad");
			stringList.Add ("¡Felicidades!", "Congratulations!");
			stringList.Add ("¡Felicidades! Has completado el juego", "Congratulations! you have completed the game");
			stringList.Add ("Menú inicial", "Start menu");
			stringList.Add ("Créditos", "Credits");
		}

		
		if(lang=="Euskara")
		{
			//print(lang);
			//PANTALLA CARGA
			stringList.Add ("Cargando...", "Kargatzen...");
			
			//intro
			stringList.Add ("Empezar", "Hasi");
			stringList.Add ("Continuar", "Jarraitu");
			stringList.Add ("Nuevo", "Berria");
			
			//personalizacion
			stringList.Add ("Crea tu avatar", "Zure pertsonaia sortu");
			
			//selec isla
			stringList.Add ("Selección de isla", "Uharte aukeraketa");
			
			//Tutorial
			stringList.Add ("Tutorial", "Tutoriala");
			stringList.Add ("Haz click en el suelo para moverte", "Lurrean CLICK egin pertsonaia mugi dezan");
			stringList.Add ("Interactua con las mascotas haciendo click en ellas", "Maskotetan CLICK egin beraiekin hitz egiteko");
			stringList.Add ("¡Hola!", "Kaixo!");
			stringList.Add ("Pausa la partida para acceder a mapa y personalización", "Partida geldiarazi mapa eta pertsonai sorkuntzara sartu ahal izateko");
			stringList.Add ("Accede a los portales para completar los ejercicios", "Portaletan sartu ariketak osatu ditzazun");
			
			//DIno
			stringList.Add ("¡Bienvenido a la isla bosque!", "Ongi etorri baso uhartera!");
			stringList.Add ("He perdido uno de mis:", "Nire Galdu egin dut");
			stringList.Add ("Ayúdame a encontrarlo", "Aurkitu ezazu mesedez");
			stringList.Add ("¡Gracias por ayudarme a recuperarlo!", "Eskerrik asko aurkitu izanagatik");
			
			//Menu
			stringList.Add ("Objetivos", "Helburuak");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla bosque", "Baso uharteko ariketa guztietan hiru izar lor itzazu");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Fantasma", "Mamu uharteko ariketa guztietan hiru izar lor itzazu");
			stringList.Add ("Consigue 3 estrellas en todos los ejercicios de la isla Mecanica", "Mekanikoa uharteko ariketa guztietan hiru izar lor itzazu");
			stringList.Add ("Dado nivel 1", "Dado 1 malla");
			stringList.Add ("Dado nivel 2", "Dado 2 malla");
			stringList.Add ("Sonidos nivel 1", "Soinuak 1 malla");
			stringList.Add ("Sonidos nivel 2", "Soinuak 2 malla");
			stringList.Add ("Sonidos nivel 3", "Soinuak 3 malla");
			
			//DAdo
			stringList.Add ("Ejercicio dado", "Dado ariketa");
			stringList.Add ("Entrar", "Sartu");
			stringList.Add ("Selección de nivel", "Maila aukeraketa");
			stringList.Add ("Haz click en el dado para lanzarlo", "Dadoan CLICK egin jaurti dezazun");
			stringList.Add ("¡Empareja la imagen con el dado para ganar puntos!", "Irudia dadoarekin batu puntuak irabazi ditzazun!");
			stringList.Add ("Nivel 2 desbloqueado", "2 Maila prest");
			stringList.Add ("Nivel 1 Completado", "1 Maila osatuta");
			stringList.Add ("Aciertos:", "Asmatutakoak: ");
			stringList.Add ("Combos:", "Kateak: ");
			stringList.Add ("Monedas:", "Txanponak: ");
			stringList.Add ("Nivel 2 completado", "2 Maila osatuta");
			
			stringList.Add ("TIRA", "Dado");
			stringList.Add ("EL", "a");
			stringList.Add ("DADO", "bota");
			
			stringList.Add ("Fresa", "Marrubia");
			stringList.Add ("Pera", "Udarea");
			stringList.Add ("Platano", "Banana");
			stringList.Add ("Copa", "Kopa");
			stringList.Add ("Bombilla", "Bonbilla");
			stringList.Add ("LLave", "Giltza");
			stringList.Add ("Percha", "Esekigailua");
			stringList.Add ("Taza", "Katilua");
			stringList.Add ("Vaso", "Edalontzia");
			stringList.Add ("Sol", "Eguzkia");
			stringList.Add ("Luna", "Ilargia");
			stringList.Add ("Estrella", "Izarra");
			
			//SOnidos
			stringList.Add ("Ejercicios sonidos","Soinu ariketa");
			stringList.Add ("Pulsa PLAY para escuchar un sonido ", "PLAY botoia sakatu soinu bat etzuteko");
			stringList.Add ("y REPAY para repetirlo", "REPLAY botoia sakatu soinu bera entzuteko");
			stringList.Add ("Haz click en la imagen que corresponda al sonido", "Entzutako soinuari dagokion iruda sakatu");
			stringList.Add ("Pulsa PLAY de nuevo para seguir jugando", "PLAY botoia berriro sakatu jolasten jaraitzeko");
			stringList.Add ("Isla Fantasma desbloqueada", "Mamu uhartea desblokeatua");
			
			stringList.Add ("Isla Fantasma", "Mamu uhartea");
			
			//Fantasma
			stringList.Add ("¡Bienvenido a la isla fantasma!", "Ongi etorri mami uhartera!");
			stringList.Add ("Mis:", "Nire:");
			stringList.Add ("se han ro...ro..roto...", "beta..a..a..aurrekoak hautsi dira");
			stringList.Add ("Ayúdame a encontrar las piezas ", "Zati guztiak aurkitzen lagundu nazazu mesedez");
			
			//Ejercicio secuencias
			stringList.Add ("Ejercicio secuencias", "Ekintza-saila ariketa");
			stringList.Add ("Lavarse los dientes", "Hortzak garbitu");
			stringList.Add ("Llamar por teléfono", "Telefonoz deitu");
			stringList.Add ("Comprar pan", "Ogia erosi");
			stringList.Add ("Cruzar la calle", "Errepidea gurutzatu");
			stringList.Add ("Coloca las imagenes en el marco en el orden correcto", "Irudiak markoan kiri zuzenean jarri");
			stringList.Add ("¡Haz click en ellas para colocarlas!", "Irudiak sakatuz koka itzazu!");
			stringList.Add ("¿Quieres salir?", "Irten nahi duzu?");
			stringList.Add ("Secuencia desbloqueada", "Ekintza prest");
			stringList.Add ("Isla Mecanica Desbloqueada", "Uharte mekanikoa desblokeatua");
			
			//CANASTA
			stringList.Add ("Juego canasta", "Saskibaloi jokoa");
			stringList.Add ("¡Consigue más puntos que el fantasma encestando!", "Baloia saskiratu mamua baino puntu gehio lortzeko");
			stringList.Add ("Haz click en la barra cuando pase la barra amarilla", "Beheko barra sakatu hutsune horia gainditzen duenean");
			stringList.Add ("¡Hazlo tres veces para encestar!", "Hiru aldiz sakatu ezazu saskiratzeko!");
			stringList.Add ("Has perdido", "Huts egin duzu");
			stringList.Add ("¡GRACIAS! ¡Has logrado encontrar mis gafas!", "Eskerrik asko! Nire betaurrekoak aurkitu dituzu!");
			
			//Entrar isla mecanica
			stringList.Add ("Isla Mecanica", "Uharte mekanikoa");
			
			//Robot
			stringList.Add ("¡Bienvenido a isla Mecanica!", "Ongi etorri Uhaste Mekanikora!");
			stringList.Add ("Me he quedado sin bateria...", "Bateria agortu zait...");
			stringList.Add ("Ayúdame a encontrar: ", "aurkitzen lagundu nazazu");
			stringList.Add ("¡Genial! ¡Gracias por encontrar mis baterias|", "Bikain! Eskerrik asko lagundu izanagatik!");
			
			//emociones
			stringList.Add ("Ejercicio emociones", "Emozioen ariketa");
			stringList.Add ("Selecciona la emoción por la que te pregunta el robot", "Robotak galdetutako emozioa aukeratu");
			stringList.Add ("Arrastra la imagen para verlas", "Irudiak mugitu guztiak ikusi ahal izateko");
			stringList.Add ("Pulsa la imagen que elijas", "Aukeratutako irudia sakatu");
			stringList.Add ("Alegria", "Poza");
			stringList.Add ("Asco", "Nazka");
			stringList.Add ("Enfado", "Haserraldi");
			stringList.Add ("Miedo", "Beldurra");
			stringList.Add ("Sorpresa", "Harridura");
			stringList.Add ("TRisteza", "Goibeltasuna");
			stringList.Add ("Vergüenza", "Lotsa");
			stringList.Add ("Curiosidad", "Jakingura");
			stringList.Add ("Nerviosismo", "Urduritasun");
			stringList.Add ("Tranquilidad", "Lasaitasuna");
			
			//Empatia
			stringList.Add ("Ejercicio empatia", "Enpatia ariketa");
			stringList.Add ("Observa la situación que se plantea en la tele grande", "Telebistan agertzen diren irudiak ikusi");
			stringList.Add ("Selecciona como crees que se sentiría esa persona", "Irudietan agertzen den pertsona nola sentitzen den aukeratu");
			stringList.Add ("Pulsa la imagen para seleccionarla", "Irudia sakatu aukeratu ahal izateko");
			
			//Isla ALtar
			stringList.Add ("Isla Altar", "Aldare uhartea");
			stringList.Add ("¡Felicidades!", "Zorionak!");
			stringList.Add ("¡Felicidades! Has completado el juego", "Zorionak! Jokoa osatu duzu");
			stringList.Add ("Menú inicial", "Hasierako menua");
			stringList.Add ("Créditos", "Kredituak");
		}
	}
}

