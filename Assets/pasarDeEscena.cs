using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.iOS;

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
			if (File.Exists (Application.persistentDataPath + "SavedGame.sg")||File.Exists(Application.dataPath + "SaveGame,sg")) 
			{
                if ((Device.generation.ToString()).IndexOf("iPad") > -1)
                {
                    Application.LoadLevel("personalizacion2_ipad");
                }
                else
                {
                    Application.LoadLevel("personalizacion2.0");
                }
			}
			else
			{
				Application.LoadLevel(escenaSiguiente);
			}

		}
	}
}
