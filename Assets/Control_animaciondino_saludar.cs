using UnityEngine;
using System.Collections;

public class Control_animaciondino_saludar : MonoBehaviour
{
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	SpriteRenderer flechaDestino_Dino;

	// Use this for initialization
	void Start ()
	{
		flechaDestino_Dino = GameObject.Find("flechaDestino_Dino").GetComponent<SpriteRenderer>();
	
		//Accedemos al script de datos globales
		CDG_Mundo3D = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		if(CDG_Mundo3D.hemosHabladoConDino || CDG_Mundo3D.huevoDinoEntregado){
			Destroy (this);
		}
	}

	void OnTriggerEnter(Collider coli)
		
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject dino = GameObject.Find ("Dinoi_animaciones_v3");
			Animator dino_animator = dino.GetComponent<Animator> ();
			dino_animator.SetBool ("bAccionDino", true);
			flechaDestino_Dino.enabled = true;
		}
		
	}
	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject dino = GameObject.Find ("Dinoi_animaciones_v3");
			Animator dino_animator = dino.GetComponent<Animator> ();
			dino_animator.SetBool ("bAccionDino", false);

			Destroy (this);
		}
		
	}
}
