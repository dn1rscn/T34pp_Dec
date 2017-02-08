using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlTrigger_IntMansion : MonoBehaviour {


	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject.Find("loadingScreen").GetComponent<Image>().enabled=true;

			Application.LoadLevel("SECUENCIAS_menu_seleccion");
			print ("Cargando ejercicio secuencias...");
		}

	}
}
