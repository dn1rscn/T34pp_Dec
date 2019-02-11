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
            string filepath = Path.Combine(Application.persistentDataPath, "progress.json");

            if (File.Exists (Application.persistentDataPath + "SavedGame.sg")|| File.Exists(filepath))
			{
                if ((Device.generation.ToString()).Contains("iPad"))
                {
                    print("Es un ipad: " + Device.generation);
                    Application.LoadLevel("personalizacion2_ipad");
                }
                else
                {
                    print("No es un ipad: " + Device.generation);
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
