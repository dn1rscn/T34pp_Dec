using UnityEngine;
using System.Collections;

public class controlInteraccionRobot : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	ControlMisionesInterfaz CMI;

	public Sprite[] array_BocadillosConversacion; 
	public int bocadillosRestantes;

	//SpriteRenderer spr_flechaDestino_Robot;
	SpriteRenderer spr_bocadilloRobot_01;
	SpriteRenderer spr_bocadilloRobot_FinMision;
	
	Vector3 posicionConversarConRobot;
	Vector3 posicionConversarConRobot2;

	ControlProtaMouse_2 ctrlProta;

	NavMeshAgent agente;

	GameObject Robot;

	public GameObject gObj_botonPasarBocadillo;
	public GameObject gObj_botonPasarBocadillo_2;

	//public GameObject huevoNido;

	Animator animator_Robot;
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

		Robot= GameObject.Find("robot_animaciones_bake_v2");

		//spr_flechaDestino_Robot = GameObject.Find("flechaDestino_Robot").GetComponent<SpriteRenderer>();
		spr_bocadilloRobot_01 = GameObject.Find("bocadillo_Robot").GetComponent<SpriteRenderer>();
		spr_bocadilloRobot_FinMision = GameObject.Find("bocadillo_Robot_FinMision").GetComponent<SpriteRenderer>();

		agente = GameObject.Find ("Chico_TEAPlay").GetComponent<NavMeshAgent>();
		posicionConversarConRobot = GameObject.Find("Posicion_ConversarConRobot").transform.position; 
		posicionConversarConRobot2 = GameObject.Find("Posicion_ConversarConRobot2").transform.position; 

		animator_Robot = GameObject.Find ("robot_animaciones_bake_v2").GetComponent <Animator> ();
		animator_Cam = GameObject.Find ("PivoteCamaraPrincipal").GetComponent <Animator> ();
		animator_Canvas = GameObject.Find ("Canvas_Mundo3D").GetComponent <Animator> ();
		animator_Prota = GameObject.Find ("Chico_TEAPlay").GetComponent<Animator>();

		ctrlProta = GameObject.Find ("Chico_TEAPlay").GetComponent<ControlProtaMouse_2>();
	}

	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			//Si NO hemos hablado aun con Robot
			if (!CDG_Mundo3D.hemosHabladoConRobot)
			{
			//Desactivamos la flecha de destino sobre el Robot
			//spr_flechaDestino_Robot.enabled = false;

			//Activamos el "Modo Dialogo" desde el animator del canvas
			animator_Canvas.Play("Canvas_AparecerDialogos");

			//Desactivamos el control del prota mientras estemos conversando
			ctrlProta.enabled = false;

			//Y mandamos su NavMeshAgent a la posicion de conversar con el Robot
			agente.SetDestination(posicionConversarConRobot);

			//Activamos la animacion de zoom de la camara
			animator_Cam.SetBool("ZoomCam", true);

			//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
			spr_bocadilloRobot_01.enabled=true;
			gObj_botonPasarBocadillo.SetActive(true);
	
			}

			//Si ya hemos hablado con Robot..
			else 
			{
				//Si HEMOS CONSEGUIDO EL HUEVO DEL Robot:
				if(CDG_Mundo3D.tenemosBateriasRobot){
					animator_Robot.SetBool("acierto_Robot",true);
					Invoke ("RobotAnimAcierto_desactivar",2.0f);

					//Activamos el "Modo Dialogo" desde el animator del canvas
					animator_Canvas.Play("Canvas_AparecerDialogos");

					//Desactivamos el control del prota mientras estemos conversando
					ctrlProta.enabled = false;

					//Y mandamos su NavMeshAgent a la posicion de conversar con el Robot
					agente.SetDestination(posicionConversarConRobot);

					//Activamos la animacion de zoom de la camara
					animator_Cam.SetBool("ZoomCam", true);

					//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
					spr_bocadilloRobot_FinMision.enabled=true;
					gObj_botonPasarBocadillo_2.SetActive(true);

					//Hacemos que aparezca el huevo del Robot en el nido
					Invoke("activarHuevoNido",2.0f);
				}

				//Si no tenemos el huevo del Robot
				else if(!CDG_Mundo3D.tenemosBateriasRobot){
					RobotAnimFallo_activar();
					Invoke ("RobotAnimFallo_desactivar",2.0f);
				}
			}
		}
	}

	void OnTriggerStay(Collider coli)
	{
		//Si no hemos hablado aun con el Robot o si ya tenemos el Huevo
		if (!CDG_Mundo3D.hemosHabladoConRobot||CDG_Mundo3D.tenemosBateriasRobot)
		{
			//Colocamos al personaje en la posicion correcta.
			if (coli.gameObject.name == "Chico_TEAPlay" && !posicionCorrecta) 
			{
				//agente.transform.LookAt(Robot.transform.position);

				if(agente.remainingDistance >= 0.1) //&& (impacto.point-agente.transform.position).magnitude>= distanciaMinima)
				{
					posicionCorrecta=false;
					animator_Prota.SetBool ("andar", true);
				}
				else
				{
					agente.transform.LookAt(Robot.transform.position);

					//Invoke("DejarDeMirarRobot",2.0f);
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
		//	animator_Robot.SetBool ("fallo_Robot", false);
		//	animator_Canvas.Play("Canvas_DesaparecerDialogos");

			posicionCorrecta=false;
			animator_Robot.SetBool ("fallo_Robot", false);

		}
		
	}

	public void RobotAnimFallo_activar(){
		animator_Robot.SetBool ("fallo_Robot", true);
	}

	public void RobotAnimFallo_desactivar(){
		animator_Robot.SetBool ("fallo_Robot", false);
	}

	public void RobotAnimAcierto_desactivar(){
		animator_Robot.SetBool ("acierto_Robot", false);
	}

	public void DejarDeMirarRobot(){
		posicionCorrecta=true;
	}


	public void terminarMisionRobot(){
		//A los 1 segundos, salimos del "Modo Dialogo"
		Invoke("salirDialogo",1.0f);
	}

	public void pasarBocadillo(){

		if (bocadillosRestantes!=0)
		{
			//Cambiamos la imagen del bocadillo
			Sprite ImagenNueva = array_BocadillosConversacion[bocadillosRestantes-1];
			spr_bocadilloRobot_01.GetComponent<SpriteRenderer>().sprite = ImagenNueva;

			bocadillosRestantes--;
		}
		else 
		{		
			//A los 1 segundos, salimos del "Modo Dialogo"
			Invoke("salirDialogo",1.0f);
		}
	}


	public void activarBocadillo2 (){
		spr_bocadilloRobot_01.enabled=false;
		//spr_bocadilloRobot_02.enabled=true;
		animator_Robot.SetBool("fallo_Robot",true);

		//A los 1 segundos, salimos del "Modo Dialogo"
		Invoke("salirDialogo",1.0f);

	}
	
	void salirDialogo(){

		ctrlProta.enabled = true;

		spr_bocadilloRobot_01.enabled=false;
		gObj_botonPasarBocadillo.SetActive(false);

		spr_bocadilloRobot_FinMision.enabled=false;
		gObj_botonPasarBocadillo_2.SetActive(false);

		CDG_Mundo3D.hemosHabladoConRobot=true;
		CMI.ActualizarMisionRobot ();

		animator_Cam.SetBool("ZoomCam", false);
		animator_Robot.SetBool ("fallo_Robot", false);
		animator_Canvas.Play("Canvas_DesaparecerDialogos");
		
		posicionCorrecta=true;


	}
}
