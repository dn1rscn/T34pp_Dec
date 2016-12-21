using UnityEngine;
using System.Collections;

public class Control_raton_madri : MonoBehaviour
{
	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject gpr_raton_madri_1 = GameObject.Find ("gpr_raton_madri");
			Animator grupo_raton_move_1 = gpr_raton_madri_1.GetComponent<Animator> ();
			grupo_raton_move_1.Play ("grupo_raton_move_1");
		}
		
	}
}
