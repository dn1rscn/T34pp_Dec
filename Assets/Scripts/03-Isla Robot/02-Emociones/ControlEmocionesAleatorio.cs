﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlEmocionesAleatorio : MonoBehaviour 
{
	ControlEmociones CE;

	public string[] AEmociones;
	public Sprite[] APregunta;
	public Sprite[] AImRespuesta;
	public GameObject[] ARespuesta;
	public bool[] ARespuestasActivas;

	public Image Pregunta;
	public Text TPregunta;

	public int respuestaCorrectaAleat;
	public int respuestaAleat;
	public int PreguntaAleat;

	int AnteriorPregunta;

	int i;
	// Use this for initialization
	void Start () 
	{
		Aleatorio_Emociones ();
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	public void Aleatorio_Emociones()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		noRepetirRespuesta();
		switch (CE.NivelEmociones) 
		{
		case 1:
			respuestaCorrectaAleat = Random.Range (1, 4);
			break;
		case 2:
			respuestaCorrectaAleat = Random.Range (1, 6);
			break;
		case 3:
			respuestaCorrectaAleat = Random.Range (1, 8);
			break;
		}
		//print (respuestaCorrectaAleat);
		//print (PreguntaAleat);
		switch (respuestaCorrectaAleat) 
		{
		case 1:					//respuesta correcta en cartel1
			ARespuesta [0].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=0)
				{
					noRepetir();
					
				}
			}
			break;
			
		case 2:					//respuesta correcta en cartel1
			ARespuesta [1].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=1)
				{
					noRepetir();
				}
			}
			break;
		case 3:					//respuesta correcta en cartel1
			ARespuesta [2].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=2)
				{
					noRepetir();
				}
			}
			break;
		case 4:					//respuesta correcta en cartel1
			ARespuesta [3].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=3)
				{
					noRepetir();
				}
			}
			break;
		case 5:					//respuesta correcta en cartel1
			ARespuesta [4].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=4)
				{
					noRepetir();
				}
			}
			break;
		case 6:					//respuesta correcta en cartel1
			ARespuesta [5].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=5)
				{
					noRepetir();
				}
			}
			break;
		case 7:					//respuesta correcta en cartel1
			ARespuesta [6].GetComponent<Image> ().sprite = AImRespuesta [PreguntaAleat];
			for(i=0;i<ARespuesta.Length;i++)
			{
				if(i!=6)
				{
					noRepetir();
				}
			}
			break;
			
		default:
			break;
		}
		//print (respuestaAleat);
	}
	void noRepetir()
	{
		respuestaAleat = Random.Range (0, ARespuesta.Length);
		while(respuestaAleat==PreguntaAleat||ARespuestasActivas[respuestaAleat]==true)
		{
			respuestaAleat = Random.Range (0, ARespuesta.Length);
		}
		ARespuesta [i].GetComponent<Image> ().sprite = AImRespuesta [respuestaAleat];
		ARespuestasActivas[respuestaAleat]=true;
	}
	void noRepetirRespuesta()
	{
		PreguntaAleat = Random.Range (0, APregunta.Length);
		while (PreguntaAleat==AnteriorPregunta) 
		{
			PreguntaAleat = Random.Range (0, APregunta.Length);
		}
		Pregunta.GetComponent<Image> ().sprite = APregunta [PreguntaAleat];
		TPregunta.GetComponent<Text> ().text=languageDictionary.stringList [AEmociones[PreguntaAleat]];

		AnteriorPregunta=PreguntaAleat;
	}
}
