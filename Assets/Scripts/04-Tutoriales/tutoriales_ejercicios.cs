using UnityEngine;
using System.Collections;

public class tutoriales_ejercicios : MonoBehaviour 
{
	public GameObject botonTuto;
	// Use this for initialization
	void Start () {
	
	}
	
	//CERRAR LA PANTALLA DE TUTORIAL
	public void CerrarPantallaTutorial()
	{
		GameObject.Find ("botonTutorial").SetActive (false);
	}

	public void info()
	{
		botonTuto.SetActive (true);
	}
}
