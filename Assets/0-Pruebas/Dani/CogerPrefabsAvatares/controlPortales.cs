using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlPortales : MonoBehaviour {

	Animator animator_PanelCanvas;
	Animator animator_botonesPortal;

	Animator animator_Canvas;

	Text textoNombrePortal;

	string destinoPortal;

	Image loadingScreen;

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	// Use this for initialization
	void Start ()
	{
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		loadingScreen = GameObject.Find("loadingScreen").GetComponent<Image>();
		if(GameObject.Find ("CanvasPortal_Verde")){
			animator_PanelCanvas = GameObject.Find ("CanvasPortal_Verde").GetComponent<Animator> ();
		}
		if(GameObject.Find("botonesPortal")){
		animator_botonesPortal = GameObject.Find("botonesPortal").GetComponent<Animator>();
		}

		animator_Canvas = GameObject.Find ("Canvas_Mundo3D").GetComponent<Animator> ();

	}
	
	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.tag == "Portal")
		{
			animator_Canvas.enabled = false;

			//Recogemos el texto que contiene el gameObject "nombrePortal" en el momento de colisionar con el trigger
			textoNombrePortal = GameObject.Find("nombrePortal").GetComponent<Text>();


			print ("Colision con: "+coli.gameObject.name);
			//Ejecutamos la animacion del canvas al entrar en algun portal
 			animator_PanelCanvas.Play("CanvasPortal_animIntro");
			animator_botonesPortal.Play("IntroBotonesPortales");

			print ("Colision con: "+coli.gameObject.name);

			//TRIGGERS ISLA BOSQUE
			if(coli.gameObject.name=="trigger_EjercicioPictogramas")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Ejercicio dado";
				print(destinoPortal);
			}
			else if(coli.gameObject.name=="trigger_EjercicioSonidos")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Ejercicio sonidos";
				print(destinoPortal);

				//animator_PanelCanvas.Play("pasarABlanco");
				//Invoke("cargarPictogramas2",100*Time.deltaTime);
			}
			else if(coli.gameObject.name=="trigger_IslaFantasma")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Isla Fantasma";
				print(destinoPortal);
				
				//animator_PanelCanvas.Play("pasarABlanco");
				//Invoke("cargarPictogramas2",100*Time.deltaTime);
			}

			//TRIGGERS ISLA FANTASMA
			else if(coli.gameObject.name=="trigger_ejercicioSecuencias")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Ejercicio secuencias";
				print(destinoPortal);
				
				//animator_PanelCanvas.Play("pasarABlanco");
				//Invoke("cargarPictogramas2",100*Time.deltaTime);
			}
			else if(coli.gameObject.name=="trigger_ejercicioCanasta")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Juego canasta";
				print(destinoPortal);
				
			}
			else if(coli.gameObject.name=="trigger_islaMecanica")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Isla Mecanica";
				print(destinoPortal);
				
			}


			//TRIGGERS ISLA MECANICA
			else if(coli.gameObject.name=="trigger_ejercicioEmocionesSocial")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Ejercicio empatia";
				print(destinoPortal);
				
			}
			else if(coli.gameObject.name=="trigger_ejercicioEmociones")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Ejercicio emociones";
				print(destinoPortal);
				
			}
			else if(coli.gameObject.name=="trigger_altarFinal")
			{
				//CDG_Mundo3D.posicionPersonaje = 2;
				destinoPortal= "Isla Altar";
				print(destinoPortal);
				
			}

			//Actualizamos el texto contiene el gameObject "nombrePortal"
			textoNombrePortal.text = destinoPortal;


		}
	}

	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.tag == "Portal")
		{
			animator_Canvas.enabled = true;
			//Ejecutamos la animacion de salida canvas al salir del portal
			animator_PanelCanvas.Play("CanvasPortal_animSalida");
			animator_botonesPortal.Play("SalidaBotonesPortales");
			textoNombrePortal.text = "";
		}
	}


	public void usarPortal(){

		loadingScreen.enabled = true;

		switch (destinoPortal)
		{
		
		//ISLA BOSQUE
		case "Ejercicio dado":
			Application.LoadLevel("Dado_SeleccionNivel");
			break;
		case "Ejercicio sonidos":
			Application.LoadLevel("Sonidos_menu_Seleccion");
			print ("Cargando ejercicio sonidos...");
			break;
		case "Isla Fantasma":

			//Ajustamos la posicion de aparicion para que aparezca en la posicion 1 de la siguiente isla, y no en la 6 
			CDG_Mundo3D.posicionPersonaje = 1;

			Application.LoadLevel("Isla_fantasma");
			print ("Cargando islaFantasma...");
			CDG_Mundo3D.islaBosque = false;
			CDG_Mundo3D.islaMec = false;
			CDG_Mundo3D.islaFant = true;
			break;

		//ISLA FANTASMA
		case "Ejercicio secuencias":
			Application.LoadLevel("SECUENCIAS_menu_seleccion");
			print ("Cargando ejercicio secuencias...");
			break;
		case "Juego canasta":
			Application.LoadLevel("10_iFantasma_P2_Canasta");
			print ("Cargando ejercicio canasta...");
			break;
		case "Isla Mecanica":
			//Ajustamos la posicion de aparicion para que aparezca en la posicion 1 de la siguiente isla, y no en la 6 
			CDG_Mundo3D.posicionPersonaje = 1;

			Application.LoadLevel("Isla_Mecanica_v3");
			print ("Cargando islaMecanica...");
			CDG_Mundo3D.islaBosque = false;
			CDG_Mundo3D.islaMec = true;
			CDG_Mundo3D.islaFant = false;
			break;

		//ISLA MECANICA
		case "Ejercicio empatia":
			Application.LoadLevel("Empatia_MenusSeleccion");
			print ("Cargando ejercicio emociones social...");
			break;
		case "Ejercicio emociones":
			Application.LoadLevel("2-Emociones_SelecNivel");
			print ("Cargando ejercicio emociones...");
			break;
		case "Isla Altar":
			Application.LoadLevel("Isla_altar");
			print ("Cargando altarFINAL...");
			CDG_Mundo3D.islaBosque = true;
			CDG_Mundo3D.islaMec = false;
			CDG_Mundo3D.islaFant = false;
			break;

		}
	}

}
