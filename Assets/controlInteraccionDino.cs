using UnityEngine;
using System.Collections;

public class controlInteraccionDino : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	ControlMisionesInterfaz CMI;
	SaveLoad SL;

	public Sprite[] array_BocadillosConversacion; 
	public int bocadillosRestantes;

	SpriteRenderer spr_flechaDestino_Dino;
	SpriteRenderer spr_bocadilloDino_01;
	SpriteRenderer spr_bocadilloDino_FinMision;
	
	Vector3 posicionConversarConDino;
	Vector3 posicionConversarConDino2;

	ControlProtaMouse_2 ctrlProta;

	NavMeshAgent agente;

	GameObject Dino;

	public GameObject gObj_botonPasarBocadillo;
	public GameObject gObj_botonPasarBocadillo_2;

	public GameObject huevoNido;

	Animator animator_Dino;
	Animator animator_Canvas;
	Animator animator_Cam;
	Animator animator_Prota;

	private bool posicionCorrecta=false;

	// Use this for initialization
	void Start () 
	{
		bocadillosRestantes = array_BocadillosConversacion.Length;

		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();
		CMI = GameObject.Find ("interfaz").GetComponent<ControlMisionesInterfaz> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();

		Dino= GameObject.Find("Dinoi_animaciones_v3");

		spr_flechaDestino_Dino = GameObject.Find("flechaDestino_Dino").GetComponent<SpriteRenderer>();
		spr_bocadilloDino_01 = GameObject.Find("bocadillo_Dino").GetComponent<SpriteRenderer>();
		spr_bocadilloDino_FinMision = GameObject.Find("bocadillo_Dino_FinMision").GetComponent<SpriteRenderer>();

		agente = GameObject.Find ("Chico_TEAPlay").GetComponent<NavMeshAgent>();
		posicionConversarConDino = GameObject.Find("Posicion_ConversarConDino").transform.position; 
		posicionConversarConDino2 = GameObject.Find("Posicion_ConversarConDino2").transform.position; 

		animator_Dino = GameObject.Find ("Dinoi_animaciones_v3").GetComponent <Animator> ();
		animator_Cam = GameObject.Find ("PivoteCamaraPrincipal").GetComponent <Animator> ();
		animator_Canvas = GameObject.Find ("Canvas_Mundo3D").GetComponent <Animator> ();
		animator_Prota = GameObject.Find ("Chico_TEAPlay").GetComponent<Animator>();

		ctrlProta = GameObject.Find ("Chico_TEAPlay").GetComponent<ControlProtaMouse_2>();

		//Si ya le hemos dado el huevo al dino...
		if(CDG_Mundo3D.huevoDinoEntregado){
			huevoNido.SetActive (true);

			CDG_Mundo3D.hemosHabladoConDino = true; 
			CDG_Mundo3D.tenemosHuevoDino = true;

		}


	}

	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			//Si NO hemos hablado aun con Dino
			if (!CDG_Mundo3D.hemosHabladoConDino)
			{

			//Desactivamos la flecha de destino sobre el dino
			spr_flechaDestino_Dino.enabled = false;

			//Activamos el "Modo Dialogo" desde el animator del canvas
			animator_Canvas.Play("Canvas_AparecerDialogos");

			//Desactivamos el control del prota mientras estemos conversando
			ctrlProta.enabled = false;

			//Y mandamos su NavMeshAgent a la posicion de conversar con el Dino
			agente.SetDestination(posicionConversarConDino);

			//Activamos la animacion de zoom de la camara
			animator_Cam.SetBool("ZoomCam", true);

			//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
			spr_bocadilloDino_01.enabled=true;
			gObj_botonPasarBocadillo.SetActive(true);
	
			}

			//Si ya hemos hablado con dino..
			else 
			{
				//Si HEMOS CONSEGUIDO EL HUEVO DEL DINO Y AUN NO LO HEMOS ENTREGADO:
				if(CDG_Mundo3D.tenemosHuevoDino && !CDG_Mundo3D.huevoDinoEntregado){
					SL.Save();
					animator_Dino.SetBool("acierto_Dino",true);
					Invoke ("DinoAnimAcierto_desactivar",2.0f);

					//Activamos el "Modo Dialogo" desde el animator del canvas
					animator_Canvas.Play("Canvas_AparecerDialogos");

					//Desactivamos el control del prota mientras estemos conversando
					ctrlProta.enabled = false;

					//Y mandamos su NavMeshAgent a la posicion de conversar con el Dino
					agente.SetDestination(posicionConversarConDino);

					//Activamos la animacion de zoom de la camara
					animator_Cam.SetBool("ZoomCam", true);

					//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
					spr_bocadilloDino_FinMision.enabled=true;
					gObj_botonPasarBocadillo_2.SetActive(true);

					//Hacemos que aparezca el huevo del Dino en el nido
					Invoke("activarHuevoNido",2.0f);
					CDG_Mundo3D.huevoDinoEntregado=true;
				}

				//Si no tenemos el huevo del Dino
				else if(!CDG_Mundo3D.tenemosHuevoDino){
					DinoAnimFallo_activar();
					Invoke ("DinoAnimFallo_desactivar",2.0f);
				}
			}


		}
	}

	void OnTriggerStay(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay" && !posicionCorrecta) 
		{
			//Si no hemos hablado aun con el Dino o si ya tenemos el Huevo
			//Colocamos al personaje en la posicion correcta.
			if (!CDG_Mundo3D.hemosHabladoConDino||CDG_Mundo3D.tenemosHuevoDino)
			{
				//agente.transform.LookAt(Dino.transform.position);

				if(agente.remainingDistance >= 0.1) //&& (impacto.point-agente.transform.position).magnitude>= distanciaMinima)
				{
					posicionCorrecta=false;
					animator_Prota.SetBool ("andar", true);
				}
				else
				{
					agente.transform.LookAt(Dino.transform.position);

					//Invoke("DejarDeMirarDino",2.0f);
					animator_Prota.SetBool("andar",false);
				}
			}
		}
	}

	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
		//	animator_Cam.SetBool("ZoomCam", false);
		//	animator_Dino.SetBool ("fallo_Dino", false);
		//	animator_Canvas.Play("Canvas_DesaparecerDialogos");

			posicionCorrecta=false;
			animator_Dino.SetBool ("fallo_Dino", false);
			GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = true;


		}
		
	}

	public void DinoAnimFallo_activar(){
		animator_Dino.SetBool ("fallo_Dino", true);
	}

	public void DinoAnimFallo_desactivar(){
		animator_Dino.SetBool ("fallo_Dino", false);
	}

	public void DinoAnimAcierto_desactivar(){
		animator_Dino.SetBool ("acierto_Dino", false);
	}

	public void DejarDeMirarDino(){
		posicionCorrecta=true;
	}


	public void terminarMisionDino(){
		//A los 1 segundos, salimos del "Modo Dialogo"
		Invoke("salirDialogo",1.0f);
	}

	public void pasarBocadillo(){

		if (bocadillosRestantes!=0)
		{
			//Cambiamos la imagen del bocadillo
			Sprite ImagenNueva = array_BocadillosConversacion[bocadillosRestantes-1];
			spr_bocadilloDino_01.GetComponent<SpriteRenderer>().sprite = ImagenNueva;

			bocadillosRestantes--;
		}
		else 
		{		
			//A los 1 segundos, salimos del "Modo Dialogo"
			Invoke("salirDialogo",1.0f);
		}
	}


	public void activarBocadillo2 (){
		spr_bocadilloDino_01.enabled=false;
		//spr_bocadilloDino_02.enabled=true;
		animator_Dino.SetBool("fallo_Dino",true);

		//A los 1 segundos, salimos del "Modo Dialogo"
		Invoke("salirDialogo",1.0f);

	}


	void activarHuevoNido(){
		huevoNido.SetActive(true);
	}

	void salirDialogo(){

		ctrlProta.enabled = true;

		spr_bocadilloDino_01.enabled=false;
		gObj_botonPasarBocadillo.SetActive(false);

		spr_bocadilloDino_FinMision.enabled=false;
		gObj_botonPasarBocadillo_2.SetActive(false);

		CDG_Mundo3D.hemosHabladoConDino=true;
		CMI.ActualizarMisionDino ();

		animator_Cam.SetBool("ZoomCam", false);
		animator_Dino.SetBool ("fallo_Dino", false);
		animator_Canvas.Play("Canvas_DesaparecerDialogos");
		
		posicionCorrecta=true;

		SL.Save();


	}
}
