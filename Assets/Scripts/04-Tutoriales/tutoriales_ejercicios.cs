using UnityEngine;
using System.Collections;

public class tutoriales_ejercicios : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//CERRAR LA PANTALLA DE TUTORIAL

	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	
	}
	public void CerrarPantallaTutorial()
	{
		GameObject.Find ("botonTutorial").SetActive (false);
	}
}
