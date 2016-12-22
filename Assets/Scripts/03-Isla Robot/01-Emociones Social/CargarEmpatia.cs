using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CargarEmpatia : MonoBehaviour 
{
	ControlEmociones CE;
	controlRespAleatoria CRA;
	ControlAleatorioSocialNivel2 CA2;
	Control_monedas cM;

	public GameObject[] GRPS_Canvas;
	public GameObject[] GRPS;
	public GameObject[] Ejercicios;
	public bool[] Ejer_Activos;
	public GameObject finpartida;
	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;

	public GameObject Ifindeljuego2;
	public GameObject Boton_Back;

	public GameObject[] vidas;

	int EjerSocial_Aleat;
	public int PreguntaAleat;
	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		CE.EjercicioSocial = Random.Range (0,3);
		PreguntaAleat = Random.Range (1, 4);
		reset ();
		Actualizar_Escena ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	public void Cambio_escena()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();


		print ("caMBIO");

		//CE.NivelEmpatia=1;
		CE.respuesta=false;
		Actualizar_Escena();
		if (CE.NivelEmpatia == 1 || CE.NivelEmpatia == 3) 
		{
			CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
			CRA.RespuesAleatoria ();
		} 
		else if (CE.NivelEmpatia == 2) 
		{
			CA2 = GameObject.Find ("ctrlAleatorio").GetComponent<ControlAleatorioSocialNivel2> ();
			CA2.AleatorioResp();
		}
	}
	public void Volver_a_jugar()
	{
		cM = GameObject.Find ("controlMonedas").GetComponent<Control_monedas> ();
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		//CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();

		reset ();
		Actualizar_Escena ();
		if (CE.NivelEmpatia == 1 || CE.NivelEmpatia == 3) 
		{
			CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
			CRA.RespuesAleatoria ();
		} 
		else if (CE.NivelEmpatia == 2) 
		{
			CA2 = GameObject.Find ("ctrlAleatorio").GetComponent<ControlAleatorioSocialNivel2> ();
			CA2.AleatorioResp();
		}

	}
	public void Salir()
	{
		reset ();
		if (CE.NivelEmpatia == 1) //Nivel 1
		{
			switch(CE.EjercicioSocial)
			{
			case 1:
				Application.LoadLevel("Empatia_MenusSeleccion");
				break;
			case 2:
				Application.LoadLevel("Empatia_MenusSeleccion");
				break;
			case 3:
				Application.LoadLevel("Isla_Mecanica_v3");
				break;
			}
		}
		if (CE.NivelEmpatia == 2) 
		{
			Application.LoadLevel("Empatia_MenusSeleccion");
		}
		if (CE.NivelEmpatia == 3) //Nivel 3
		{
			switch(CE.EjercicioSocial)
			{
			case 1:
				Application.LoadLevel("Empatia_MenusSeleccion");
				break;
			case 2:
				Application.LoadLevel("Empatia_MenusSeleccion");
				break;
			case 3:
				//Application.LoadLevel("Empatia_MenusSeleccion");
				Application.LoadLevel("Isla_Mecanica_v3");
				break;
			}
		}

	}
	public void Actualizar_Escena()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();

		//animacion/efecto cambio pantallas
		for (int i = 0; i<GRPS.Length; i++) 
		{
			GRPS[i].SetActive(false);
			GRPS_Canvas[i].SetActive(false);
		}
		for (int i = 0; i<Ejercicios.Length; i++) 
		{
			Ejercicios[i].SetActive(false);
		}
		
		
		switch (CE.NivelEmpatia) 
		{
		case 1:

			GRPS[0].SetActive(true);
			GRPS_Canvas[0].SetActive(true);
			CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
			Cargar_Ejercicio();
			CRA.RespuesAleatoria ();
			break;
		case 2:
			print ("nivel2");
			GRPS[1].SetActive(true);
			GRPS_Canvas[1].SetActive(true);
			while (Ejer_Activos[PreguntaAleat-1]==true) 
			{
				print("numAleat");
				PreguntaAleat = Random.Range (1,4);
			}
			GameObject.Find("ctrlAleatorio").GetComponent<ControlAleatorioSocialNivel2>().AleatorioResp();
			break;
		case 3:

			GRPS[2].SetActive(true);
			GRPS_Canvas[2].SetActive(true);
			CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
			Cargar_Ejercicio();
			CRA.RespuesAleatoria ();
			break;
		}
	}
	void Cargar_Ejercicio()
	{
		while (Ejer_Activos[CE.EjercicioSocial]==true) 
		{
			PreguntaAleat = Random.Range (1, 4);
		}

		if (Ejer_Activos [CE.EjercicioSocial] == false) 
		{
			switch (CE.EjercicioSocial) 
			{
			case 0:
				Ejercicios [0].SetActive (true);
				break;
			case 1:
				Ejercicios [1].SetActive (true);
				break;
			case 2:
				Ejercicios [2].SetActive (true);
				break;
			}
		}
	}

	public void back()
	{
		Boton_Back.SetActive (false);
		Ifindeljuego2.SetActive (true);
		Ifindeljuego2.GetComponent<Animator> ().Play ("AnimFinPartida");
	}
	public void seguirJugando()
	{
		Boton_Back.SetActive (true);
		Ifindeljuego2.SetActive (false);
	}
	void reset()
	{
		cM = GameObject.Find ("controlMonedas").GetComponent<Control_monedas> ();
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		//CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
		
		for (int i=0; i<vidas.Length; i++) 
		{
			vidas[i].SetActive(true);
		}
		for (int i=0; i<Ejer_Activos.Length; i++) 
		{
			Ejer_Activos[i]=false;
		}
		CE.Intentos = 1;
		cM.monedasSocialNivel1 = 0;
		CE.respuesta = true;
		estrella1.SetActive(false);
		estrella2.SetActive(false);
		estrella3.SetActive(false);
		finpartida.SetActive(false);
		CE.respuesta=false;
	}
}
