using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ControlInterface : MonoBehaviour 
{
	control_datosGlobalesPersonalizacion cdgP;
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	SaveLoad SL;
	Actualizar_ninos AN;


	public GameObject BotonInicio;
	public GameObject BotonJuego;

	public GameObject PersonajeInicio;
	public GameObject Personajejuego;

	public GameObject MascotaInicio;
	public GameObject Mascotajuego;

	public GameObject CamInicio;
	public GameObject CamJuego;

	public GameObject FondoRobot;
	public GameObject FondoFantasma;
	public GameObject FondoDino;

	public GameObject mensaje;


	// Use this for initialization
	void Start () 
	{
		CDG_Mundo3D = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();

		if(Application.loadedLevelName=="personalizacion2.0"||Application.loadedLevelName=="personalizacion2_ipad")
		{
			cdgP = GameObject.Find ("datosGlobalesPersonalizacion").GetComponent<control_datosGlobalesPersonalizacion> ();
			AN=GameObject.Find("AvataresParaMenu").GetComponent<Actualizar_ninos>();
			

			//Game.
			//print ("cargamos partida");
			//SL.Load ();

			if (CDG_Mundo3D.IKKI == true) 
			{
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
					.SetScreenName("Inicio"));

                string filepath = Path.Combine(Application.persistentDataPath, "progress.json");

                if (File.Exists (Application.persistentDataPath + "SavedGame.sg")|| File.Exists(filepath)) 
				{

					BotonInicio.SetActive (false);
					CamInicio.SetActive (true);
					
					BotonJuego.SetActive (true);
					CamJuego.SetActive (false);
				} 
				else //if (File.Exists (Application.persistentDataPath + "SavedGame.sg")) 
				{
					print("nuevo Juego");
					
					BotonInicio.SetActive (true);
					PersonajeInicio.SetActive (true);
					MascotaInicio.SetActive (true);
					CamInicio.SetActive (true);
					
					BotonJuego.SetActive (false);
					Personajejuego.SetActive (false);
					Mascotajuego.SetActive (false);
					CamJuego.SetActive (false);
					
					cdgP.inicio=true;
				}

				CDG_Mundo3D.IKKI=false;
			} 
			else if (CDG_Mundo3D.IKKI == false) 
			{

				if (cdgP.inicio == true)
				{
					BotonInicio.SetActive (true);
					PersonajeInicio.SetActive (true);
					MascotaInicio.SetActive (true);
					CamInicio.SetActive (true);

					BotonJuego.SetActive (false);
					Personajejuego.SetActive (false);
					Mascotajuego.SetActive (false);
					CamJuego.SetActive (false);

				} 
				else if (cdgP.inicio == false) 
				{
					GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
					.SetScreenName("Personalizacion"));

					BotonInicio.SetActive (false);
					PersonajeInicio.SetActive (false);
					MascotaInicio.SetActive (false);
					CamInicio.SetActive (false);

					BotonJuego.SetActive (true);
					Personajejuego.SetActive (true);
					Mascotajuego.SetActive (true);
					CamJuego.SetActive (true);
				}
			}


			switch (cdgP.mascota)
			{
			case 0:
				FondoRobot.SetActive (true);
				FondoFantasma.SetActive (false);
				FondoDino.SetActive (false);
				break;

			case 1:
				FondoRobot.SetActive (false);
				FondoFantasma.SetActive (true);
				FondoDino.SetActive (false);
				break;

			case 2:
				FondoRobot.SetActive (false);
				FondoFantasma.SetActive (false);
				FondoDino.SetActive (true);
				break;
			}
		}
	
	}
	public void OKpersonalizacion()
	{
		print ("guardamos Partida");
		cdgP.nuevoJuego = false;

        SL.Save();

        Application.LoadLevel ("Mapa");
        
    }
	public void irAPlayStore()
	{
		print ("Vamos a PlayStore");
		//SL.Save ();

		//Redireccionar a la Playstore
		if(Application.platform==RuntimePlatform.Android)
		{
			Application.OpenURL("market://details?id=com.IKKI.TEApp");
		}
		else
		{
			Application.OpenURL("https://play.google.com/store/apps/details?id=com.IKKI.TEApp");
		}

		//Analytics
		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
		                                                                   .SetEventCategory("valoracion")
		                                                                   .SetEventAction("like_DEMO"));
	
	}

	public void dislikeYVolverAlMenu()
	{
	//Analytics
		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
		                                                                   .SetEventCategory("valoracion")
		                                                                   .SetEventAction("dislike_DEMO"));
	}
	public void redireccionarAWebIkki()
	{
		//Analytics
		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
		                                                                   .SetEventCategory("valoracion")
		                                                                   .SetEventAction("redireccionBotonWeb_DEMO"));
	}
	public void redireccionarTwitterIkki()
	{
		//Analytics
		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
		                                                                   .SetEventCategory("valoracion")
		                                                                   .SetEventAction("redireccionTwitter_DEMO"));
	}
	public void redireccionarFacebookIkki()
	{
		//Analytics
		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
		                                                                   .SetEventCategory("valoracion")
		                                                                   .SetEventAction("redireccionFacebook_DEMO"));
	}

    public void Continuar()
	{
		//cdgP.nuevoJuego = false;
		SL.Load ();
		Application.LoadLevel ("Mapa");

		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
				.SetEventCategory("Botones Inicio")
				.SetEventAction("Continuar"));
	}

	/*public void NuevoJuego()
	{
		cdgP.nuevoJuego = false;
		Application.LoadLevel ("Mapa");
	}*/
	public void Volver_mundo ()
	{
		CDG_Mundo3D = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		if (CDG_Mundo3D.islaBosque == true) 
		{
			Application.LoadLevel ("Isla_bosque");
		}
		else if (CDG_Mundo3D.islaMec == true) {
			Application.LoadLevel ("Isla_Mecanica_v3");
		}
		else if (CDG_Mundo3D.islaFant == true) {
			Application.LoadLevel ("Isla_fantasma");
		}
		else{
			Application.LoadLevel ("Mapa");
		}

		SL.Save();
	}
	public void No_borrar()
	{
		mensaje.SetActive(false);
	}
	public void PersonalizacionInicial()
	{
		//print ("cam personaje");
		if (cdgP.inicio == true) 
		{
			GameObject.Find ("camara_Inicio").GetComponent<Animator> ().Play ("CamPersonaje");

		} else if (cdgP.inicio == false) 
		{
			GameObject.Find ("camara_Juego").GetComponent<Animator> ().Play ("ACamMascPersonaje");
		}
	}
	public void NuevaPartida()
	{
		//print ("hola");
		mensaje.SetActive(true);
	}
	public void mascotas()
	{
		if (cdgP.inicio == true) {
			GameObject.Find ("camara_Inicio").GetComponent<Animator> ().Play ("CamMascota");
		} else if (cdgP.inicio == false) 
		{
			GameObject.Find ("camara_Juego").GetComponent<Animator> ().Play ("ACamPerMascota");
		}
	}
	public void robot()
	{
		FondoRobot.SetActive (true);
		FondoFantasma.SetActive (false);
		FondoDino.SetActive (false);

		cdgP.mascota = 0;
	}
	public void fantasma()
	{
		FondoRobot.SetActive (false);
		FondoFantasma.SetActive (true);
		FondoDino.SetActive (false);

		cdgP.mascota = 1;
	}
	public void Dino()
	{
		FondoRobot.SetActive (false);
		FondoFantasma.SetActive (false);
		FondoDino.SetActive (true);

		cdgP.mascota = 2;
	}
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/studios_ikki/");
    }
    public void Facebook ()
	{
		Application.OpenURL ("https://www.facebook.com/Ikki-Studios-1854126904821934");
	}
	public void twitter ()
	{
		Application.OpenURL ("https://twitter.com/Studiosikki");
	}
	public void webIkki ()
	{
		Application.OpenURL ("http://www.studiosikki.com");
	}
	public void borrar_Partida()
	{
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.Android)
        {
            if (File.Exists(Application.persistentDataPath + "SavedGame.sg"))
            {
                print("existe el archivo");
                File.Delete(Application.persistentDataPath + "SavedGame.sg");
                SL.LoadDefault();
                AN.Start();
                print("nuevo Juego");

                Application.LoadLevel("seleccion_Idioma");
                /*BotonInicio.SetActive (true);
                PersonajeInicio.SetActive (true);
                MascotaInicio.SetActive (true);
                CamInicio.SetActive (true);

                BotonJuego.SetActive (false);
                Personajejuego.SetActive (false);
                Mascotajuego.SetActive (false);
                CamJuego.SetActive (false);

                GameObject.Find ("camara_Inicio").GetComponent<Animator> ().Play ("CamPersonaje");*/
            }
            else
            {
                print("no existe el archivo");
            }
        }
        else if (Application.platform == RuntimePlatform.IPhonePlayer)
        {
            string filepath = Path.Combine(Application.persistentDataPath, "progress.json");
            if (File.Exists(filepath))
            {
                print("existe el archivo");
                File.Delete(filepath);
                SL.LoadDefault();
                AN.Start();
                print("nuevo Juego");

                Application.LoadLevel("seleccion_Idioma");
            }
            else
            {
                print("no existe el archivo");
            }
        }
        
	}

}
