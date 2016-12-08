using UnityEngine;
using System.Collections;

public class NoDestruirMusicaFondo : MonoBehaviour {

	public static NoDestruirMusicaFondo cont;

	void Awake ()
	{
		
		if (cont == null) {
			cont = this;
			DontDestroyOnLoad (gameObject);
		} else if (cont != this) {
			Destroy(gameObject);
		}
	}
	
	void FixedUpdate () {
		if(Application.loadedLevelName !="mapa" && Application.loadedLevelName !="personalizacion2.0" )
		{
			print ("eliminando musica fondo");
			Destroy(gameObject);
		}
	
	}
}
