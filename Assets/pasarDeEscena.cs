﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class pasarDeEscena : MonoBehaviour {

	public string escenaSiguiente;

	public void reproducirAudio (){
		GameObject.Find ("audioIntroIkki_1").GetComponent<AudioSource>().Play();
	}


	public void siguienteEscena (){

		if(escenaSiguiente==""){
			print ("Debes especificar el nombre de la escena siguiente en el Inspector");
		} 

		else 
		{
			if (File.Exists (Application.persistentDataPath + "SavedGame.sg")) 
			{
				Application.LoadLevel("personalizacion2.0");
			}
			else
			{
				Application.LoadLevel(escenaSiguiente);
			}

		}
	}
}
