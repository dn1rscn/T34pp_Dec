﻿using UnityEngine;
using System.Collections;

public class controlInteraccionFantasma : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	ControlMisionesInterfaz CMI;
	SaveLoad SL;

	public Sprite[] array_BocadillosConversacion; 
	public int bocadillosRestantes;

    public Sprite[] array_BocadillosConversacion_castellano;
    public Sprite[] array_BocadillosConversacion_euskera;
    public Sprite[] array_BocadillosConversacion_ingles;
    public Sprite[] array_BocadillosConversacion_frances;

    SpriteRenderer spr_bocadilloFantasma_01;
	SpriteRenderer spr_bocadilloFantasma_FinMision;

	Vector3 posicionConversarConFantasma;
	Vector3 posicionReposoFantasma;
	GameObject posicionReposoFantasma2;

	ControlProtaMouse_2 ctrlProta;

	UnityEngine.AI.NavMeshAgent agenteProta;

	UnityEngine.AI.NavMeshAgent agenteFantasma;

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
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();

		Fantasma = GameObject.Find("fantasma_bake_v2");

        //Segun el idioma seleccionado ajustamos los bocadillos
        switch (languageDictionary.lang)
        {
            case "Spanish":
                print("traduciendoBocadillos_Castellano");
                GameObject.Find("bocadillo_Fantasma").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_castellano[0];
                array_BocadillosConversacion[0] = array_BocadillosConversacion_castellano[2];
                array_BocadillosConversacion[1] = array_BocadillosConversacion_castellano[1];
                GameObject.Find("bocadillo_Fantasma_FinMision").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_castellano[3];

                break;
            case "English":
                print("traduciendoBocadillos_Ingles");
                GameObject.Find("bocadillo_Fantasma").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_ingles[0];
                array_BocadillosConversacion[0] = array_BocadillosConversacion_ingles[2];
                array_BocadillosConversacion[1] = array_BocadillosConversacion_ingles[1];
                GameObject.Find("bocadillo_Fantasma_FinMision").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_ingles[3];

                break;
            case "Euskara":
                print("traduciendoBocadillos_Euskara");
                GameObject.Find("bocadillo_Fantasma").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_euskera[0];
                array_BocadillosConversacion[0] = array_BocadillosConversacion_euskera[2];
                array_BocadillosConversacion[1] = array_BocadillosConversacion_euskera[1];
                GameObject.Find("bocadillo_Fantasma_FinMision").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_euskera[3];

                break;
            case "Frances":
                print("traduciendoBocadillos_Frances");
                GameObject.Find("bocadillo_Fantasma").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_frances[0];
                array_BocadillosConversacion[0] = array_BocadillosConversacion_frances[2];
                array_BocadillosConversacion[1] = array_BocadillosConversacion_frances[1];
                GameObject.Find("bocadillo_Fantasma_FinMision").GetComponent<SpriteRenderer>().sprite = array_BocadillosConversacion_frances[3];

                break;
        }


        spr_bocadilloFantasma_01 = GameObject.Find("bocadillo_Fantasma").GetComponent<SpriteRenderer>();
		spr_bocadilloFantasma_FinMision = GameObject.Find("bocadillo_Fantasma_FinMision").GetComponent<SpriteRenderer>();

		agenteProta = GameObject.Find ("Chico_TEAPlay").GetComponent<UnityEngine.AI.NavMeshAgent>();
		agenteFantasma = GameObject.Find ("fantasma_bake_v2").GetComponent<UnityEngine.AI.NavMeshAgent>();

		posicionConversarConFantasma = GameObject.Find("Posicion_ConversarConFantasma").transform.position; 
		posicionReposoFantasma = GameObject.Find("posicionReposoFantasma_PuertaMansion").transform.position; 
		posicionReposoFantasma2 = GameObject.Find("posicionReposoFantasma2_PuertaMansion"); 

		animator_Fantasma = Fantasma.GetComponent <Animator> ();
		animator_Cam = GameObject.Find ("PivoteCamaraPrincipal").GetComponent <Animator> ();
		animator_Canvas = GameObject.Find ("Canvas_Mundo3D").GetComponent <Animator> ();
		animator_Prota = GameObject.Find ("Chico_TEAPlay").GetComponent<Animator>();

		ctrlProta = GameObject.Find ("Chico_TEAPlay").GetComponent<ControlProtaMouse_2>();

		//Si ya le hemos dado las gafas al fantasma, debe empezar el nivel con ellas puestas
		if(CDG_Mundo3D.gafasFantasmaEntregadas){
			gafasFantasma.SetActive (true);


			Fantasma.transform.parent.gameObject.transform.position=posicionReposoFantasma2.transform.position;
			//agenteFantasma.enabled=true;
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
				Invoke("botonBocadillo_01",3.0f);
			}

			//Si ya hemos hablado con el Fantasma..
			else 
			{
				//Si HEMOS CONSEGUIDO LAS GAFAS DEL FANTASMA:
				if(CDG_Mundo3D.tenemosGafasFantasma && !CDG_Mundo3D.gafasFantasmaEntregadas){
	
					SL.Save();
					//Activamos el "Modo Dialogo" desde el animator del canvas
					animator_Canvas.Play("Canvas_AparecerDialogos");

					//Desactivamos el control del prota mientras estemos conversando
					ctrlProta.enabled = false;

					//Y mandamos su NavMeshAgent a la posicion de conversar con el Fantasma
					agenteProta.SetDestination(posicionConversarConFantasma);
					
					//Activamos la animacion de zoom de la camara
					animator_Cam.SetBool("ZoomCam_Fantasma", true);
					
					//Activamos el primer bocadillo de conversacion y el boton para pasar de bocadillos en el canvas
					spr_bocadilloFantasma_FinMision.enabled=true;
					Invoke("botonBocadillo_02",4.0f);

					CDG_Mundo3D.gafasFantasmaEntregadas=true;

					animator_Fantasma.SetBool("acierto_Fantasma",true);
					//Hacemos que el al fantasma le aparezcan las gafas
					Invoke("activarGafasFantasma",2.0f);
				}
				else{
					Invoke("activarCollider",1.0f);
				}
			}
	
			SL.Save();
		
		}
	}

	void OnTriggerStay(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay" && !posicionCorrecta) 
		{
			//Si no hemos hablado aun con el Fantasma o si ya tenemos sus gafas
			//Colocamos al personaje en la posicion correcta.
			if (!CDG_Mundo3D.hemosHabladoConFantasma||(CDG_Mundo3D.tenemosGafasFantasma&&!CDG_Mundo3D.gafasFantasmaEntregadas))
			{
				//agente.transform.LookAt(Robot.transform.position);
				if(agenteProta.velocity !=Vector3.zero) //&& (impacto.point-agente.transform.position).magnitude>= distanciaMinima)
				{
					posicionCorrecta=false;
					animator_Prota.SetBool("andar",true);
				}
				else
				{
					print("quieto");
					animator_Prota.SetBool("andar",false);
					agenteProta.transform.LookAt(Fantasma.transform.position);
					posicionCorrecta=true;

					//Invoke("DejarDeMirarRobot",2.0f);

					//GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = false;


				}
			}
		}
	}

	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			posicionCorrecta=false;
			//GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = true;

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

	void botonBocadillo_01(){
		gObj_botonPasarBocadillo.SetActive(true);
	}

	void botonBocadillo_02(){
		gObj_botonPasarBocadillo_2.SetActive(true);

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
	void activarCollider(){
		GameObject.Find ("Chico_TEAPlay").GetComponent<CapsuleCollider>().enabled = true;

	}
}
