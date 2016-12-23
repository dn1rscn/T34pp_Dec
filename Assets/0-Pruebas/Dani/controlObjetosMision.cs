using UnityEngine;
using System.Collections;

public class controlObjetosMision : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	Control_PuntuacionObjetos CPO;

	public GameObject[] gObjArray_partesGafasFantasma;
	public GameObject[] gObjArray_bateriasRobot;

	public GameObject animObjetoMision;
	Animator animator_ObjetoMision;
	// Use this for initialization
	void Start () {
	
		//Accedemos al script de datos globales
		CDG_Mundo3D = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		CPO = GameObject.Find ("objetos").GetComponent<Control_PuntuacionObjetos> ();
	
		gObjArray_partesGafasFantasma = GameObject.FindGameObjectsWithTag("gafaFantasma");
		gObjArray_bateriasRobot = GameObject.FindGameObjectsWithTag("bateriaRobot");

		animator_ObjetoMision = animObjetoMision.GetComponent<Animator>();

		ActualizarObjetosMision(); 
	}

	void OnTriggerEnter(Collider coli)
	{	
		//Si colisionamos con el huevo del dino
		if (coli.gameObject.tag == "huevoDino")
		{
			coli.gameObject.SetActive (false);

			//Activamos la animacion "HAS CONSEGUIDO EL HUEVO"
			animator_ObjetoMision.Play("anim_RecogerObjetoMision");

			//Activamos los sonidos de "Objeto de mision obtenido"
			GameObject.Find("audioRecogerHuevo_01").GetComponent<AudioSource>().Play();
			GameObject.Find("audioRecogerHuevo_02").GetComponent<AudioSource>().Play();

			//Activamos la variable de datos globales "tenemosHuevoDelDino"
			CDG_Mundo3D.tenemosHuevoDino = true;

		}


		//Si colisionamos con una de las 4 partes de las gafa del fantasma
		if (coli.gameObject.tag == "gafaFantasma")
		{
			//Activamos la notificacion "HAS CONSEGUIDO UNA PARTE DE LAS GAFAS"
			GameObject.Find("audioRecogerBateria").GetComponent<AudioSource>().Play();

			coli.gameObject.SetActive (false);

			int cont=0;
			int recogidos=0;
			//Recorremos el array de gameobjects 
			foreach (GameObject parteGafa in gObjArray_partesGafasFantasma)
			{
				//Y almacenamos en check_partesGafas las partes que ya hayamos recogido
				if(parteGafa.activeSelf == false){
					print(parteGafa.name+" recogida");

					CDG_Mundo3D.check_partesGafas[cont]= true;
					recogidos++;
					CPO.GafasRecogidas++;
					CPO.actualizar_Objetos();

					if(recogidos == 4){
						//Activamos la variable de datos globales "tenemosGafasFantasma"
						CDG_Mundo3D.tenemosGafasFantasma = true;

						//Activamos la animacion "TODAS LAS PARTES DE LAS GAFAS CONSEGUIDAS!!"
						animator_ObjetoMision.Play("anim_RecogerObjetoMision");

						//Activamos los sonidos de "Objeto de mision obtenido"
						GameObject.Find("audioRecogerHuevo_01").GetComponent<AudioSource>().Play();
						GameObject.Find("audioRecogerHuevo_02").GetComponent<AudioSource>().Play();

					}
				}
				else {
					print(parteGafa.name+" para recoger");
					CDG_Mundo3D.check_partesGafas[cont]= false;
				}
				cont++;
			}

		}


		//Si colisionamos con una de las 4 baterias del robot
		if (coli.gameObject.tag == "bateriaRobot")
		{
			//Activamos la animacion "HAS CONSEGUIDO UNA BATERIA PARA EL ROBOT"
			GameObject.Find("audioRecogerBateria").GetComponent<AudioSource>().Play();

			coli.gameObject.SetActive (false);
			
			int cont=0;
			int recogidos=0;
			//Recorremos el array de gameobjects 
			foreach (GameObject bateria in gObjArray_bateriasRobot)
			{
				//Y almacenamos en check_partesGafas las partes que ya hayamos recogido
				if(bateria.activeSelf == false){
					print(bateria.name+" recogida");

					CDG_Mundo3D.check_bateriasRobot[cont]= true;
					recogidos++;
					CPO.EnergiaRecogida++;
					CPO.actualizar_Objetos();
					if(recogidos == 4){

						//Activamos la animacion "TODAS LAS BATERIAS CONSEGUIDAS!!"
						animator_ObjetoMision.Play("anim_RecogerObjetoMision");
						
						//Activamos los sonidos de "Objeto de mision obtenido"
						GameObject.Find("audioRecogerHuevo_01").GetComponent<AudioSource>().Play();
						GameObject.Find("audioRecogerHuevo_02").GetComponent<AudioSource>().Play();

						//Activamos la variable de datos globales "tenemosBateriasRobot"
						CDG_Mundo3D.tenemosBateriasRobot = true;
					}
				}
				else {
					print(bateria.name+" para recoger");
					CDG_Mundo3D.check_bateriasRobot[cont]= false;
				}
				cont++;
			}


		}
	}


	public void ActualizarObjetosMision(){

		//Actualizamos el estado de los objetos de mision de la isla fantasma
		if(Application.loadedLevelName == "Isla_fantasma"){
			int cont=0;
			foreach (bool parteGafa in CDG_Mundo3D.check_partesGafas)
			{
				if(parteGafa == true){
					gObjArray_partesGafasFantasma[cont].SetActive(false);
				}
				else{
					gObjArray_partesGafasFantasma[cont].SetActive(true);
				}
				cont++;
			}
		}

		//Actualizamos el estado de los objetos de mision de la isla mecanica
		if(Application.loadedLevelName == "Isla_Mecanica_v3"){
			int cont=0;
			foreach (bool bateria in CDG_Mundo3D.check_bateriasRobot)
			{
				if(bateria == true){
					gObjArray_bateriasRobot[cont].SetActive(false);
				}
				else{
					gObjArray_bateriasRobot[cont].SetActive(true);
				}
				cont++;
			}
		}


	}
}
