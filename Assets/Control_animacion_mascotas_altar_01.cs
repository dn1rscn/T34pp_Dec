using UnityEngine;
using System.Collections;

public class Control_animacion_mascotas_altar_01 : MonoBehaviour 
{
	
	public bool bAccion;

	public GameObject grp_Particulas;

	void OnTriggerEnter(Collider coli)
	{

		if (coli.gameObject.name == "Chico_TEAPlay") 
		{

			GameObject dino = GameObject.Find ("Dinoi_animaciones_v3");
			Animator dino_animator = dino.GetComponent<Animator> ();
			dino_animator.SetBool ("bSaludo", true);
	
			GameObject robot = GameObject.Find ("robot_animaciones_bake_v2");
			Animator robot_animator = robot.GetComponent<Animator> ();
			robot_animator.SetBool ("bSaludo", true);
	
			GameObject fantasma = GameObject.Find ("fantasma_bake_v2");
			Animator fantasma_animator = fantasma.GetComponent<Animator> ();
			fantasma_animator.SetBool ("bSaludo", true);
		}
		grp_Particulas.SetActive(true);
	}
	void OnTriggerExit(Collider coli)
	{

		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject dino = GameObject.Find ("Dinoi_animaciones_v3");
			Animator dino_animator = dino.GetComponent<Animator> ();
			dino_animator.SetBool ("bSaludo", false);

			GameObject robot = GameObject.Find ("robot_animaciones_bake_v2");
			Animator robot_animator = robot.GetComponent<Animator> ();
			robot_animator.SetBool ("bSaludo", false);

			GameObject fantasma = GameObject.Find ("fantasma_bake_v2");
			Animator fantasma_animator = fantasma.GetComponent<Animator> ();
			fantasma_animator.SetBool ("bSaludo", false);
		}
		
		
		
	}
}
