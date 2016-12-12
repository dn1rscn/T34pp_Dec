using UnityEngine;
using System.Collections;

public class controlObjetosMision : MonoBehaviour {


	ControlDatosGlobales_Mundo3D CDG_Mundo3D;


	// Use this for initialization
	void Start () {
	
		//Accedemos al script de datos globales
		CDG_Mundo3D=GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
	
	}

	void OnTriggerEnter(Collider coli)
	{	
		//Si colisionamos con el huevo del dino
		if (coli.gameObject.tag == "huevoDino")
		{
			//Activamos la variable de datos globales "TenemosElHuevoDelDino"



		}
		//Si colisionamos con una de las 4 partes de las gafa del fantasma
		if (coli.gameObject.tag == "gafaFantasma")
		{
			//Activamos la variable de datos globales "TenemosElHuevoDelDino"



		}

		//Si colisionamos con una de las 4 baterias del robot
		if (coli.gameObject.tag == "bateriaRobot")
		{
			//Activamos la variable de datos globales "TenemosElHuevoDelDino"



		}
	}
}
