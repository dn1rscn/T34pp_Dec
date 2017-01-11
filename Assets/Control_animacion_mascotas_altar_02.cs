using UnityEngine;
using System.Collections;

public class Control_animacion_mascotas_altar_02 : MonoBehaviour
{
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	public bool bAccion;

	public GameObject botonMenu;
	public GameObject txt_juegoCompletado;
	public GameObject botoncreditos;
	public GameObject creditos;

	public GameObject prota;
	public GameObject posicionFinal;

	NavMeshAgent agente;

	void Start(){
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();
		agente = prota.GetComponent<NavMeshAgent>();
	}

	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			//Desactivamos los controles del prota y lo enviamos a la posicion final
			prota.GetComponent<CapsuleCollider>().enabled = false;
			prota.GetComponent<ControlProtaMouse_2>().enabled = false;
			agente.SetDestination(posicionFinal.transform.position);


			GameObject dino = GameObject.Find ("Dinoi_animaciones_v3");
			Animator dino_animator = dino.GetComponent<Animator> ();
			dino_animator.SetBool ("bCelebra", true);

			GameObject robot = GameObject.Find ("robot_animaciones_bake_v2");
			Animator robot_animator = robot.GetComponent<Animator> ();
			robot_animator.SetBool ("bCelebra", true);

			GameObject fantasma = GameObject.Find ("fantasma_bake_v2");
			Animator fantasma_animator = fantasma.GetComponent<Animator> ();
			fantasma_animator.SetBool ("bCelebra", true);
		}

		Invoke("mostrarInterfazIslaAltar",3.0f);
	}

	void FixedUpdate(){
		if (agente.velocity!=Vector3.zero)		
		{
			prota.GetComponent<Animator>().SetBool ("andar", true);
		}
		else
		{
			prota.GetComponent<Animator>().SetBool("andar",false);
		}
	}

	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject dino = GameObject.Find ("Dinoi_animaciones_v3");
			Animator dino_animator = dino.GetComponent<Animator> ();
			dino_animator.SetBool ("bCelebra", false);
		}
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject robot = GameObject.Find ("robot_animaciones_bake_v2");
			Animator robot_animator = robot.GetComponent<Animator> ();
			robot_animator.SetBool ("bCelebra", false);
		}
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject fantasma = GameObject.Find ("fantasma_bake_v2");
			Animator fantasma_animator = fantasma.GetComponent<Animator> ();
			fantasma_animator.SetBool ("bCelebra", false);
		}
	}

	public void mostrarInterfazIslaAltar(){
		
		creditos.SetActive (false);
		botonMenu.SetActive (true);
		txt_juegoCompletado.SetActive (true);
		botoncreditos.SetActive (true);
	}

	public void cargarMenuInicial(){
		Application.LoadLevel("personalizacion2.0");
		CDG_Mundo3D.IKKI = true;
	}

	public void cargarcreditos () {
		txt_juegoCompletado.SetActive (false);
		creditos.SetActive (true);
	}


}
