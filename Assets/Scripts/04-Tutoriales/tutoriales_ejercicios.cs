using UnityEngine;
using System.Collections;

public class tutoriales_ejercicios : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//CERRAR LA PANTALLA DE TUTORIAL
	public void CerrarPantallaTutorial()
	{
		GameObject.Find ("botonTutorial").SetActive (false);
	}
}
