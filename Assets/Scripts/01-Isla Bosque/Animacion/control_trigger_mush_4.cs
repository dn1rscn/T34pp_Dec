﻿using UnityEngine;
using System.Collections;

public class control_trigger_mush_4 : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter(Collider coli)

	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			GameObject mushroom = GameObject.Find ("mushroom_animaciones_5");
			Animator mushroom_animator = mushroom.GetComponent<Animator> ();
			mushroom_animator.SetBool ("bAccion", true);
		}
		
	}
	void OnTriggerExit(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay")
		{
			GameObject mushroom = GameObject.Find ("mushroom_animaciones_5");
			Animator mushroom_animator = mushroom.GetComponent<Animator> ();
			mushroom_animator.SetBool ("bAccion", false);
		}
		
	}
}
