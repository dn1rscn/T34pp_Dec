using UnityEngine;
using System.Collections;

public class control_triggersPosicion : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;


	// Use this for initialization
	void Start () {
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled=false;
		GameObject grupoSuperiorProta = transform.parent.gameObject;

		switch (CDG_Mundo3D.posicionPersonaje) {
			case 6:
			{
				//posicionFinal
				grupoSuperiorProta.transform.position = GameObject.Find ("posicionInicialProta_06").transform.position;
				
				break;
			}	

			case 5:
			{
				//posicionFinal
				grupoSuperiorProta.transform.position = GameObject.Find ("posicionInicialProta_05").transform.position;
				
				break;
			}	

			case 4:
			{
				//posicionFinal
				grupoSuperiorProta.transform.position = GameObject.Find ("posicionInicialProta_04").transform.position;
				
				break;
			}	

			case 3:
			{
				//posicionFinal
				grupoSuperiorProta.transform.position = GameObject.Find ("posicionInicialProta_03").transform.position;
				
				break;
			}	
			case 2:
			{	//posicionMedia
				grupoSuperiorProta.transform.position = GameObject.Find ("posicionInicialProta_02").transform.position;
				break;
				
			}	
			case 1:
			{	//posicionInicial
				grupoSuperiorProta.transform.position = GameObject.Find ("posicionInicialProta_01").transform.position;
				
				break;
			}
			default: 
			{
				break;
			}
		}


		gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled=true;


	}
	
	void OnTriggerEnter(Collider coli){
		//print (coli.gameObject.name);

		switch (coli.gameObject.name)
		{
		case "Posicion_01" :
			CDG_Mundo3D.posicionPersonaje = 1;
			break;
		case "Posicion_02":
				CDG_Mundo3D.posicionPersonaje = 2;
				break;
		case "Posicion_03":
				CDG_Mundo3D.posicionPersonaje = 3;
				break;
		case "Posicion_04":
			CDG_Mundo3D.posicionPersonaje = 4;
		break;
		case "Posicion_05":
				CDG_Mundo3D.posicionPersonaje = 5;
		break;
		case "Posicion_06":
				CDG_Mundo3D.posicionPersonaje = 6;
			break;
		}
	}
}
