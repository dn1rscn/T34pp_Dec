using UnityEngine;
using System.Collections;

public class controlInteraccionFantasma : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	ControlMisionesInterfaz CMI;

	public Sprite[] array_BocadillosConversacion; 
	public int bocadillosRestantes;

	SpriteRenderer spr_bocadilloFantasma_01;
	SpriteRenderer spr_bocadilloFantasma_FinMision;

	Vector3 posicionConversarConFantasma;
	Vector3 posicionReposoFantasma;

	ControlProtaMouse_2 ctrlProta;

	NavMeshAgent agenteProta;

	NavMeshAgent agenteFantasma;

	GameObject Fantasma;
	public GameObject gafasFantasma;

	public GameObject gObj_botonPasarBocadillo;
	public GameObject gObj_botonPasarBocadillo_2;
	
	Animator animator_Fantasma;
	Animator animator_Canvas;
	Animator animator_Cam;
	Animator animator_Prota;

	private bool posicionCorrecta=false;

	// Use this for initialization
	void Start () 
	{
		bocadillosRestantes = array_BocadillosConversacion.Length;

		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		CMI = GameObject.Find ("interfaz").GetComponent<ControlMisionesInterfaz> ();

		Fantasma = GameObject.Find("fantasma_bake_v2");

		spr_bocadilloFantasma_01 = GameObject.Find("bocadillo_Fantasma").GetComponent<SpriteRenderer>();
		spr_bocadilloFantasma_FinMision = GameObject.Find("bocadillo_Fantasma_FinMision").GetComponent<SpriteRenderer>();

		agenteProta = GameObject.Find ("Chico_TEAPlay").GetComponent<NavMeshAgent>();
		agenteFantasma = GameObject.Find ("fantasma_bake_v2").GetComponent<NavMeshAgent>();

		posicionConversarConFantasma = GameObject.Find("Posicion_ConversarConFantasma").transform.position; 
		posicionReposoFantasma = GameObject.Find("posicionReposoFantasma_PuertaMansion").transform.position; 

		animator_Fantasma = Fantasma.GetComponent <Animator> ();
		animator_Cam = GameObject.Find ("PivoteCamaraPrincipal").GetComponent <Animator> ();
		animator_Canvas = GameObject.Find ("Canvas_Mundo3D").GetComponent <Animator> ();
		animator_Prota = GameObject.Find ("Chico_TEAPlay").GetComponent<Animator>();

		ctrlProta = GameObject.Find ("Chico_TEAPlay").GetComponent<ControlProtaMouse_2>();

		//Si ya le hemos dado las gafas al fantasma, debe empezar el nivel con ellas puestas
		if(CDG_Mundo3D.gafasFantasmaEntregadas){
			gafasFantasma.SetActive (true);
			animator_Fantasma.Play("reposo_fantasma");
			CDG_Mundo3D.hemosHabladoConFantasma = true; 
			CDG_Mundo3D.tenemosGafasFantasma = true;
			CDG_Mundo3D.IslaFantasma_Desbloqueada = true;
			CDG_Mundo3D.check_partesGafas [0] = true;
			CDG_Mundo3D.check_partesGafas [1] = true;
			CDG_Mundo3D.check_partesGafas [2] = true;
			CDG_Mundo3D.check_partesGafas [3] = true;
		}
	}

	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			//Si NO hemos hablado aun con el fantasma
			if (!CDG_Mundo3D.hemosHabladoConFantasma && !CDG_Mundo3D.tenemosGafasFantasma)
			{
				//Activamos el "Modo Dialogo" desde el animator del canvas
				animator_Canvas.Play("Canvas_AparecerDialogos");

				//Desactivamos el control del prota mientras estemos conversando
				ctrlProta.enabled = false;

				//Y mandamos su NavMeshAgent a la posicion de conversar con el Dino
				agenteProta.SetDestination(posicionConversarConFantasma);

				//Activamos la animacion de zoom de la camara
				animator_Cam.SetBool("ZoomCam_Fantasma", true);

				//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
				spr_bocadilloFantasma_01.enabled=true;
				gObj_botonPasarBocadillo.SetActive(true);
				GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = false;

			}

			//Si ya hemos hablado con el Fantasma..
			else 
			{
				//Si HEMOS CONSEGUIDO LAS GAFAS DEL FANTASMA:
				if(CDG_Mundo3D.tenemosGafasFantasma && !CDG_Mundo3D.gafasFantasmaEntregadas){
					//Activamos el "Modo Dialogo" desde el animator del canvas
					animator_Canvas.Play("Canvas_AparecerDialogos");

					//Desactivamos el control del prota mientras estemos conversando
					ctrlProta.enabled = false;
					GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = false;

					//Y mandamos su NavMeshAgent a la posicion de conversar con el Fantasma
					agenteProta.SetDestination(posicionConversarConFantasma);
					
					//Activamos la animacion de zoom de la camara
					animator_Cam.SetBool("ZoomCam_Fantasma", true);
					
					//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
					spr_bocadilloFantasma_FinMision.enabled=true;
					gObj_botonPasarBocadillo_2.SetActive(true);
					
					CDG_Mundo3D.gafasFantasmaEntregadas=true;

					animator_Fantasma.SetBool("acierto_Fantasma",true);
					//Hacemos que el al fantasma le aparezcan las gafas
					Invoke("activarGafasFantasma",2.0f);
				}
			}
		
		}
	}

	void OnTriggerStay(Collider coli)
	{
		//Si no hemos hablado aun con el Fantasma o si ya tenemos sus gafas
		if (!CDG_Mundo3D.hemosHabladoConFantasma||CDG_Mundo3D.tenemosGafasFantasma)
		{
			//Colocamos al personaje en la posicion correcta.
			if (coli.gameObject.name == "Chico_TEAPlay" && !posicionCorrecta) 
			{
				//agente.transform.LookAt(Robot.transform.position);
				if (agenteProta.velocity!=Vector3.zero)		
				{
					posicionCorrecta=false;
					animator_Prota.SetBool ("andar", true);
				}
				else
				{
					agenteProta.transform.LookAt(Fantasma.transform.position);
					
					//Invoke("DejarDeMirarRobot",2.0f);
					animator_Prota.SetBool("andar",false);
					GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = false;
				}
			}
		}
	}

	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			posicionCorrecta=false;
		}
	}
	
	void activarGafasFantasma(){
		gafasFantasma.SetActive (true);
	}

	public void pasarBocadillo(){
		
		if (bocadillosRestantes!=0)
		{
			//Cambiamos la imagen del bocadillo
			Sprite ImagenNueva = array_BocadillosConversacion[bocadillosRestantes-1];
			spr_bocadilloFantasma_01.GetComponent<SpriteRenderer>().sprite = ImagenNueva;
			
			bocadillosRestantes--;
		}
		else 
		{		
			//A los 3 segundos, salimos del "Modo Dialogo"
			Invoke("salirDialogo",3.0f);
		}
	}

	public void activarBocadillo2 (){
		spr_bocadilloFantasma_01.enabled=false;

		//A los 3 segundos, salimos del "Modo Dialogo"
		Invoke("salirDialogo",3.0f);
	}

	public void terminarMisionFantasma(){
		//mandamos al fantasma a la posicion de reposo (delante de la mansion)
		agenteFantasma.enabled= true;
		animator_Fantasma.SetBool("andar",true);
		agenteFantasma.SetDestination(posicionReposoFantasma);

		//A los 1 segundos, salimos del "Modo Dialogo"
		Invoke("salirDialogo",1.0f);
	}

	void salirDialogo(){

		ctrlProta.enabled = true;

		spr_bocadilloFantasma_01.enabled=false;
		gObj_botonPasarBocadillo.SetActive(false);

		spr_bocadilloFantasma_FinMision.enabled=false;
		gObj_botonPasarBocadillo_2.SetActive(false);

		animator_Cam.SetBool("ZoomCam_Fantasma", false);
		animator_Canvas.Play("Canvas_DesaparecerDialogos");
		
		posicionCorrecta=true;

		CDG_Mundo3D.hemosHabladoConFantasma = true;
		CMI.ActualizarMisionFantasma ();

		GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = true;

	}
}
