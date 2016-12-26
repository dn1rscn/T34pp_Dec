using UnityEngine;
using System.Collections;

public class controlInteraccionRobot : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	ControlMisionesInterfaz CMI;

	public Sprite[] array_BocadillosConversacion; 
	public int bocadillosRestantes;

	SpriteRenderer spr_bocadilloRobot_01;
	SpriteRenderer spr_bocadilloRobot_FinMision;
	
	Vector3 posicionConversarConRobot;

	ControlProtaMouse_2 ctrlProta;

	NavMeshAgent agente;

	GameObject Robot;

	public GameObject gObj_botonPasarBocadillo;
	public GameObject gObj_botonPasarBocadillo_2;

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
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		CMI = GameObject.Find ("interfaz").GetComponent<ControlMisionesInterfaz> ();

		Robot= GameObject.Find("robot_animaciones_bake_v2");

		spr_bocadilloRobot_01 = GameObject.Find("bocadillo_Robot").GetComponent<SpriteRenderer>();
		spr_bocadilloRobot_FinMision = GameObject.Find("bocadillo_Robot_FinMision").GetComponent<SpriteRenderer>();

		agente = GameObject.Find ("Chico_TEAPlay").GetComponent<NavMeshAgent>();
		posicionConversarConRobot = GameObject.Find("Posicion_ConversarConRobot").transform.position; 

		animator_Robot = GameObject.Find ("robot_animaciones_bake_v2").GetComponent <Animator> ();
		animator_Cam = GameObject.Find ("PivoteCamaraPrincipal").GetComponent <Animator> ();
		animator_Canvas = GameObject.Find ("Canvas_Mundo3D").GetComponent <Animator> ();
		animator_Prota = GameObject.Find ("Chico_TEAPlay").GetComponent<Animator>();

		ctrlProta = GameObject.Find ("Chico_TEAPlay").GetComponent<ControlProtaMouse_2>();

		//Si ya le hemos dado las baterias al robot, debe empezar el nivel en pie
		if(CDG_Mundo3D.robotArreglado){
			animator_Robot.Play("reposo_robot");
			CDG_Mundo3D.hemosHabladoConRobot = true;
			CDG_Mundo3D.tenemosBateriasRobot = true;
			CDG_Mundo3D.IslaMec_Desbloqueada = true;
			CDG_Mundo3D.check_bateriasRobot [0] = true;
			CDG_Mundo3D.check_bateriasRobot [1] = true;
			CDG_Mundo3D.check_bateriasRobot [2] = true;
			CDG_Mundo3D.check_bateriasRobot [3] = true;

		}
	}

	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			//Si NO hemos hablado aun con Robot
			if (!CDG_Mundo3D.hemosHabladoConRobot && !CDG_Mundo3D.tenemosBateriasRobot)
			{
				//Activamos el "Modo Dialogo" desde el animator del canvas
				animator_Canvas.Play("Canvas_AparecerDialogos");

				//Desactivamos el control del prota mientras estemos conversando
				ctrlProta.enabled = false;

				//Y mandamos su NavMeshAgent a la posicion de conversar con el Robot
				agente.SetDestination(posicionConversarConRobot);

				//Activamos la animacion de zoom de la camara
				animator_Cam.SetBool("ZoomCam_Robot", true);

				//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
				spr_bocadilloRobot_01.enabled=true;
				gObj_botonPasarBocadillo.SetActive(true);
			}

			//Si ya hemos hablado con Robot..
			else 
			{
				//Si HEMOS CONSEGUIDO LAS BATERIAS DEL Robot:
				if(CDG_Mundo3D.tenemosBateriasRobot && !CDG_Mundo3D.robotArreglado){
					//Activamos el "Modo Dialogo" desde el animator del canvas
					animator_Canvas.Play("Canvas_AparecerDialogos");

					//Desactivamos el control del prota mientras estemos conversando
					ctrlProta.enabled = false;

					//Y mandamos su NavMeshAgent a la posicion de conversar con el Robot
					agente.SetDestination(posicionConversarConRobot);

					//Activamos la animacion de zoom de la camara
					animator_Cam.SetBool("ZoomCam_Robot", true);

					//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
					spr_bocadilloRobot_FinMision.enabled=true;
					gObj_botonPasarBocadillo_2.SetActive(true);

					CDG_Mundo3D.robotArreglado=true;

					//Hacemos que el Robot se levante
					Invoke("activarRobot",2.0f);
				}

				//Si no tenemos las baterias del Robot
				else if(!CDG_Mundo3D.tenemosBateriasRobot){
					Invoke ("RobotAnimFallo_desactivar",2.0f);
				}
			}
		}
	}

	void OnTriggerStay(Collider coli)
	{
		//Si no hemos hablado aun con el Robot o si ya tenemos sus baterias
		if (!CDG_Mundo3D.hemosHabladoConRobot||CDG_Mundo3D.tenemosBateriasRobot)
		{
			//Colocamos al personaje en la posicion correcta.
			if (coli.gameObject.name == "Chico_TEAPlay" && !posicionCorrecta) 
			{
				//agente.transform.LookAt(Robot.transform.position);
				if (agente.velocity!=Vector3.zero)		
				{
					posicionCorrecta=false;
					animator_Prota.SetBool ("andar", true);
				}
				else
				{
					agente.transform.LookAt(Robot.transform.position);

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

	public void activarRobot(){
		//	Ejecutamos la animacion de reposo del robot
		animator_Robot.SetBool("acierto_Robot",true);
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

		animator_Cam.SetBool("ZoomCam_Robot", false);
		animator_Robot.SetBool ("fallo_Robot", false);
		animator_Canvas.Play("Canvas_DesaparecerDialogos");
		
		posicionCorrecta=true;

		GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = true;



	}
}
