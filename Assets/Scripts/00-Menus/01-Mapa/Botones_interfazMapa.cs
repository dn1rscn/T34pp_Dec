using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Botones_interfazMapa : MonoBehaviour 
{

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;

	public GameObject Fondo_IBosque;
	public GameObject Fondo_IFantasma;
	public GameObject Fondo_IRobot;

	float Tiempo = 0;

	public bool seleccion;

	public GameObject Loading;

	// Use this for initialization
	void Start () 
	{
		if (GameObject.Find ("controlMapa")) 
		{
			Fondo_IBosque.SetActive (false);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (false);
		}

		//SI EXISTE, ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		if(GameObject.Find("ControlDatosGlobales"))
		{
			CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

			if (CDG_Mundo3D.islaBosque == true) 
			{
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
				.SetScreenName("Isla Bosque"));

				Fondo_IBosque.SetActive (true);
				Fondo_IFantasma.SetActive (false);
				Fondo_IRobot.SetActive (false);
			}
			if (CDG_Mundo3D.islaMec == true) 
			{
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
				.SetScreenName("Isla Mecanica"));

				Fondo_IBosque.SetActive (false);
				Fondo_IFantasma.SetActive (false);
				Fondo_IRobot.SetActive (true);
			}
			if (CDG_Mundo3D.islaFant == true) 
			{
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
				.SetScreenName("Isla Fantasma"));

				Fondo_IBosque.SetActive (false);
				Fondo_IFantasma.SetActive (true);
				Fondo_IRobot.SetActive (false);
			}

		}

		seleccion = false;

		//Ajustamos Loading, solo si se ha declarado
		if(Loading)
		{
			Loading.SetActive(false);
		}


	}

	public void Volver_mundo ()
	{
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();
		if (CDG_Mundo3D.islaBosque == true) 
		{
			Application.LoadLevel ("Isla_bosque");
		}
		if (CDG_Mundo3D.islaMec == true) 
		{
			Application.LoadLevel ("04_1-Mundo3D_IslaRobot");
		}
		if (CDG_Mundo3D.islaFant == true) 
		{
			Application.LoadLevel ("05_1-Mundo3D_IslaFantasma");
		}
	}
	public void Isla_Bosque()
	{
		if (seleccion == false&&CDG_Mundo3D.islaBosque==false ) 
		{
			//print (Tiempo);
			Fondo_IBosque.SetActive (true);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (false);

			CDG_Mundo3D.posicionPersonaje = 1;
			seleccion=true;
			Loading.SetActive(true);

			Invoke ("ToBosque", Tiempo);
		}
	}
	public void Isla_FAntasma()
	{
		if (CDG_Mundo3D.Demo==true)
		{
			Application.LoadLevel("Isla_altar");
		}
		else if (CDG_Mundo3D.Demo==false)
		{
			if (seleccion == false && CDG_Mundo3D.IslaFantasma_Desbloqueada==true&&CDG_Mundo3D.islaFant==false) 
			{
				print (Tiempo);
				Fondo_IBosque.SetActive (false);
				Fondo_IFantasma.SetActive (true);
				Fondo_IRobot.SetActive (false);

				CDG_Mundo3D.posicionPersonaje = 1;

				seleccion=true;
				Loading.SetActive(true);

				Invoke ("ToFantasma", Tiempo);
			}
		}
	}
	public void Isla_Robot()
	{
		if (seleccion == false && CDG_Mundo3D.IslaMec_Desbloqueada==true&&CDG_Mundo3D.islaMec==false) 
		{
			print (Tiempo);
			Fondo_IBosque.SetActive (false);
			Fondo_IFantasma.SetActive (false);
			Fondo_IRobot.SetActive (true);

			CDG_Mundo3D.posicionPersonaje = 1;

			seleccion = true;
			Loading.SetActive(true);

			Invoke ("ToRobot", Tiempo);
		}

	}

	void ToBosque()
	{
		Debug.Log ("A Isla Bosque");
		CDG_Mundo3D.islaBosque = true;
		CDG_Mundo3D.islaFant = false;
		CDG_Mundo3D.islaMec = false;
		Application.LoadLevel ("Isla_bosque");
	}
	void ToFantasma()
	{
		Debug.Log ("A Isla Fantasma");
		CDG_Mundo3D.islaBosque = false;
		CDG_Mundo3D.islaFant = true;
		CDG_Mundo3D.islaMec = false;
		Application.LoadLevel ("Isla_fantasma");
	}
	void ToRobot()
	{
		Debug.Log ("A Isla Robot");
		CDG_Mundo3D.islaBosque = false;
		CDG_Mundo3D.islaFant = false;
		CDG_Mundo3D.islaMec = true;
		Application.LoadLevel ("Isla_Mecanica_v3");
	}
}
