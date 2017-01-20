using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuestaEmociones : MonoBehaviour 
{
	ControlEmocionesAleatorio CEA;
	ControlEmociones CE;
	ControlSlider CSlider;
	ControlNotificaciones1 CNotificaciones;
	ControlDatosGlobales_Mundo3D cdg_3d;
	ControlMisiones CMisiones;
	SaveLoad SL;

	public GameObject[] Vidas;
	
	public GameObject IfinJuego;
	public GameObject IfinJuego2;
	
	//public GameObject BotonVolverGrande;
	
	public GameObject SiguienteSecuencia;

	public GameObject Boton_Back;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasEmociones;
	Text TmonedasEmociones;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;
	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		CSlider = GameObject.Find ("Progreso").GetComponent<ControlSlider> ();
		CEA = GameObject.Find ("ctrAleatorio").GetComponent<ControlEmocionesAleatorio> ();
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();

		//CEA.Aleatorio_Emociones ();

		Boton_Back.SetActive (true);

		cM.monedasEmociones=0;
		CE.aciertos=0;
		CE.Intentos = 1;

		CE.respuesta = false;
		actualizarPuntuacion ();
		CSlider.progresoEmociones();

		CNotificaciones.Nivel2.SetActive(false);
		CNotificaciones.Nivel3.SetActive(false);
		CNotificaciones.Isla.SetActive (false);
		CNotificaciones.GMision.SetActive (false);
		for(int i=0;i < CNotificaciones.MisionDino.Length; i++)
		{
			CNotificaciones.MisionDino[i].SetActive(false);
		}
	}
	
	public void Respuesta()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		if (CE.respuesta == false) 
		{
			CEA = GameObject.Find ("ctrAleatorio").GetComponent<ControlEmocionesAleatorio> ();

			if ("P" + gameObject.GetComponent<Image> ().sprite.name == GameObject.Find ("Pregunta").GetComponent<Image> ().sprite.name) {
				Correcto ();
			} else {
				Error ();
			}
		}
	}

	void Correcto()
	{
		//print ("correcto");
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		//print (CEA.ARespuesta.Length);
		GameObject.Find ("robot_animaciones_bake_v2").GetComponent<Animator> ().Play("acierto_robot");
		CE.aciertos++;

		actualizarPuntuacion ();
		CSlider.progresoEmociones();

		if (CEA.ARespuesta.Length == 7) 
		{
			cdg_3d = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
			CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();
			
			ControlMonedas = GameObject.Find ("controlMonedas");
			cM = ControlMonedas.GetComponent<Control_monedas> ();

			
			if (CE.aciertos==5) 
			{


				//Invoke ("ActivarEstrella1", 1.0f);
				if(CE.NivelEmociones<3)
				{
					SiguienteSecuencia.SetActive(true);
				}


				if(CE.NivelEmociones==1&&CE.empatia1_completado==true)
				{
					cdg_3d.Altar_Desbloqueado=true;
					CNotificaciones.Isla.SetActive (true);
					GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				}
				else if(CE.NivelEmociones==1&&CE.empatia1_completado==false)
				{
					CE.emociones1_completado=true;
				}
			}
			if (CE.aciertos==10) 
			{
				switch(CE.NivelEmociones)
				{
				case 1:
					if(CE.empatia1_completado==true)
					{
						cdg_3d.Altar_Desbloqueado=true;
						CNotificaciones.Isla.SetActive (true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					else if(CE.NivelEmociones==1&&CE.empatia1_completado==false)
					{
						CE.emociones1_completado=true;
					}
					if(CE.AEmociones[1]==false)
					{
						CNotificaciones.Nivel2.SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
						
					}
					if(CE.NivelEmociones<CE.AEmociones.Length)
					{
						CE.AEmociones[CE.NivelEmociones]=true;
					}
					break;
					
				case 2:
					if(CE.AEmociones[2]==false)
					{
						CNotificaciones.Nivel3.SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
						
					}
					break;
				}

				//Invoke ("ActivarEstrella1", 1.0f);
				//Invoke ("ActivarEstrella2", 2.0f);
				if(CE.NivelEmociones<3)
				{
					SiguienteSecuencia.SetActive(true);
				}
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}

				

			}
			if (CE.aciertos == 15) 
			{
				IfinJuego.SetActive(true);
				IfinJuego.GetComponent<Animator>().Play("AnimFinPartida");

				puntuacionfin = GameObject.Find ("puntuacionFin");
				TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
				
				monedasEmociones = GameObject.Find ("monedas");
				TmonedasEmociones = monedasEmociones.GetComponent<Text> ();

				cM.calcular_monedasEmociones();
				
				if(CMisiones.ejerM_3estrellas[CE.NivelEmociones+2]==false)
				{
					CNotificaciones.Nivel2.SetActive(false);
					CNotificaciones.Nivel3.SetActive(false);
					CNotificaciones.Isla.SetActive (false);
					CNotificaciones.GMision.SetActive(true);
					for(int i=0;i < CNotificaciones.MisionDino.Length; i++)
					{
						CNotificaciones.MisionDino[i].SetActive(false);
					}
					CNotificaciones.MisionDino[CE.NivelEmociones+2].SetActive(true);
					GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				}

				Invoke ("ActivarEstrella1", 1.0f);
				Invoke ("ActivarEstrella2", 2.0f);
				Invoke ("ActivarEstrella3", 3.0f);
				if(CE.NivelEmociones<3)
				{
					SiguienteSecuencia.SetActive(true);
				}
				if(CE.NivelEmociones<CE.AEmociones.Length)
				{
					CE.AEmociones[CE.NivelEmociones]=true;
				}
				CMisiones.ejerM_3estrellas[CE.NivelEmociones+2]=true;
				CMisiones.Mision_Robot();

				
				TpuntuacionFin.text = "\nIntentos: " + CE.Intentos.ToString ();
				
				TmonedasEmociones.text = cM.monedasEmociones.ToString();

				SL.Save();

				cM.monedasEmociones=0;
				CE.Intentos=1;
				CE.aciertos=0;
				CE.respuesta=true;
			}

		}
		if (CE.aciertos != 15) 
		{
			for(int i = 0; i<CEA.ARespuestasActivas.Length; i++)
			{
				CEA.ARespuestasActivas[i]=false;
			}

			CEA.Aleatorio_Emociones();

		}
	}
	void Error()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		GameObject.Find ("robot_animaciones_bake_v2").GetComponent<Animator> ().Play("fallo_robot");
		print ("fallo");
		CE.Intentos++;

		if (CE.Intentos == 4) 
		{
			Vidas[CE.Intentos-2].SetActive(false);

			IfinJuego.SetActive(true);
			IfinJuego.GetComponent<Animator>().Play("AnimFinPartida");
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasEmociones = GameObject.Find ("monedas");
			TmonedasEmociones = monedasEmociones.GetComponent<Text> ();
			
			cM.calcular_monedasEmociones();

			if(CE.aciertos>=5)
			{
				Invoke ("ActivarEstrella1", 1.0f);
			}
			if(CE.aciertos>=10)
			{
				Invoke ("ActivarEstrella2", 2.0f);
			}
			if(CE.aciertos>=15)
			{
				Invoke ("ActivarEstrella3", 3.0f);
			}

			TpuntuacionFin.text = "\nIntentos: " + CE.Intentos.ToString ();
			
			TmonedasEmociones.text = cM.monedasEmociones.ToString();

			SL.Save();

			cM.monedasEmociones=0;
			CE.Intentos=1;
			CE.aciertos=0;
			CE.respuesta=true;
		} 
		else 
		{
			Vidas[CE.Intentos-2].SetActive(false);
		}


	}
	void ActivarEstrella1()
	{
		Debug.Log("estrella1");
		//yield return new WaitForSeconds (2.0f);
		GameObject.Find ("estrellas").GetComponent<Animator> ().Play ("AnimEstrella1");
	}
	void ActivarEstrella2()
	{
		//yield return new WaitForSeconds (2.0f);
		GameObject.Find ("estrellas").GetComponent<Animator> ().Play ("AnimEstrella2");
	}
	void ActivarEstrella3()
	{
		//yield return new WaitForSeconds (2.0f);
		GameObject.Find ("estrellas").GetComponent<Animator> ().Play ("AnimEstrella3");
	}
	void actualizarPuntuacion()
	{
		puntuacion = GameObject.Find ("puntuacion");
		Tpuntuacion = puntuacion.GetComponent<Text> ();
		
		Tpuntuacion.text = CE.aciertos.ToString();
	}

	public void Salir_Interfaz()
	{
		Boton_Back.SetActive (false);

		IfinJuego2.SetActive(true);
		
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		
		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
		
		monedasEmociones = GameObject.Find ("monedas");
		TmonedasEmociones = monedasEmociones.GetComponent<Text> ();
	
		TmonedasEmociones.text = cM.monedasEmociones.ToString();
		TpuntuacionFin.text = "¿ QUIERES SALIR ? ";
		CE.respuesta = true;
	}
	public void seguir_Jugando()
	{
		Boton_Back.SetActive (true);
		IfinJuego2.SetActive(false);
		CE.respuesta = true;
	}
}
