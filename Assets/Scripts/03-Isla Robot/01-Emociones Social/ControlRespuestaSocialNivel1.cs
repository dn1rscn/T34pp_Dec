using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuestaSocialNivel1 : MonoBehaviour 
{
	controlRespAleatoria CRA;

	ControlEmociones CE;
	ControlSlider CSlider;
	DatosDesbloqueo DD;
	ControlNotificaciones1 CNotificaciones;
	ControlDatosGlobales_Mundo3D cdg_3d;
	CargarEmpatia Cargar_Em;
	ControlMisiones CMisiones;

	public GameObject IfinJuego;

	
	//public GameObject BotonVolverGrande;
	
	public GameObject SiguienteSituacion;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasSocialNivel1;
	Text TmonedasSocialNivel1;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;
	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();
		//CSlider = GameObject.Find ("Progreso").GetComponent<ControlSlider> ();

		CE.respuesta = false;
		CNotificaciones.Isla.SetActive (false);
		CNotificaciones.Nivel2.SetActive(false);
		CNotificaciones.GMision.SetActive (false);
		for(int i=0;i < CNotificaciones.MisionDino.Length; i++)
		{
			CNotificaciones.MisionDino[i].SetActive(false);
		}
		//actualizarPuntuacion ();
		//CSlider.progresoEmocionesSNivel1 ();


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void respuesta()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();

		if (CE.respuesta == false) 
		{
			CRA = GameObject.Find ("crtRespuesta").GetComponent<controlRespAleatoria> ();
			//print (gameObject.GetComponent<Image> ().sprite);
			print (CRA.RespuestaAleat);
			print (gameObject.name);

			if (gameObject.name == "respuesta1" && CRA.RespuestaAleat == 1) 
			{
				//cdg.resp = true;
				correcto ();
			} else { 
				if (gameObject.name == "respuesta2" && CRA.RespuestaAleat == 2) 
				{
					//cdg.resp = true;
					correcto ();
				} else {
					error ();
				}
			}
		}


	}

	void correcto()
	{
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();
		cdg_3d = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		DD = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();
		Cargar_Em = GameObject.Find ("ControlEscenasEmpatia").GetComponent<CargarEmpatia> ();

		GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("acierto");

		print ("correcto");
		Cargar_Em.Ejer_Activos [CE.EjercicioSocial] = true;

		for (int i=0; i<Cargar_Em.Ejer_Activos.Length&&Cargar_Em.Ejer_Activos[i]==true; i++) 
		{
			print("entro en for ");

			if(i==Cargar_Em.Ejer_Activos.Length-1&&Cargar_Em.Ejer_Activos[i]==true)
			{
				IfinJuego.SetActive(true);

				CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();
				ControlMonedas = GameObject.Find ("controlMonedas");
				cM = ControlMonedas.GetComponent<Control_monedas> ();
				
				puntuacionfin = GameObject.Find ("puntuacionFin");
				TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
				
				monedasSocialNivel1 = GameObject.Find ("monedas");
				TmonedasSocialNivel1 = monedasSocialNivel1.GetComponent<Text> ();
				
				cM.calcular_monedaSocialNivel1 ();
				cM.calcular_monedasGenerales ();
				if (CE.Intentos == 1) 
				{
					if(CE.emociones1_completado==true)
					{
						cdg_3d.Altar_Desbloqueado=true;
						CNotificaciones.Isla.SetActive (true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					else if(CE.emociones1_completado==false)
					{
						CE.empatia1_completado=true;
					}
					if(DD.AEmpatia[1]==false)
					{
						CNotificaciones.Nivel2.SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					
					Invoke ("ActivarEstrella1", 1.0f);
					Invoke ("ActivarEstrella2", 2.0f);
					Invoke ("ActivarEstrella3", 3.0f);
					
					SiguienteSituacion.SetActive (true);
					if(CE.EjercicioSocial<CE.ASocialNivel1.Length)
					{
						CE.ASocialNivel1[CE.EjercicioSocial]=true;
					}
					DD.AEmpatia[1] = true;
					if(CE.NivelEmpatia == 1 &&CMisiones.ejerM_3estrellas[0]==false)
					{
						CMisiones.ejerB_3estrellas[0]=true;
						CMisiones.Mision_Robot();
						CNotificaciones.GMision.SetActive(true);
						CNotificaciones.MisionDino[0].SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					if(CE.NivelEmpatia==3&&CMisiones.ejerM_3estrellas[2]==false)
					{
						CMisiones.ejerB_3estrellas[2]=true;
						CMisiones.Mision_Robot();
						CNotificaciones.GMision.SetActive(true);
						CNotificaciones.MisionDino[2].SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					
				} 
				else 
				{
					if (CE.Intentos == 2) 
					{
						if(CE.emociones1_completado==true)
						{
							cdg_3d.Altar_Desbloqueado=true;
							CNotificaciones.Isla.SetActive (true);
							GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
						}
						else if(CE.emociones1_completado==false)
						{
							CE.empatia1_completado=true;
						}

						if(DD.AEmpatia[1]==false)
						{
							CNotificaciones.Nivel2.SetActive(true);
							GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
						}
						Invoke ("ActivarEstrella1", 1.0f);
						Invoke ("ActivarEstrella2", 2.0f);
						
						SiguienteSituacion.SetActive (true);
						if(CE.EjercicioSocial<CE.ASocialNivel1.Length)
						{
							CE.ASocialNivel1[CE.EjercicioSocial]=true;
						}
						DD.AEmpatia[1] = true;

						
						
					} 
					else if (CE.Intentos == 3)
					{
						if(CE.emociones1_completado==true)
						{
							cdg_3d.Altar_Desbloqueado=true;
							CNotificaciones.Isla.SetActive (true);
							GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
						}
						else if(CE.emociones1_completado==false)
						{
							CE.empatia1_completado=true;
						}
						
						Invoke ("ActivarEstrella1", 1.0f);
						
						SiguienteSituacion.SetActive (true);
						if(CE.EjercicioSocial<CE.ASocialNivel1.Length)
						{
							CE.ASocialNivel1[CE.EjercicioSocial]=true;
						}

						
						
					}
				}
				
				
				TpuntuacionFin.text = "\nIntentos: " + CE.Intentos.ToString();
				
				TmonedasSocialNivel1.text = cM.monedasSocialNivel1.ToString();
				
				
				CE.Intentos = 1;
				cM.monedasSocialNivel1 = 0;
				CE.respuesta = true;
			}

		}
		if (IfinJuego.activeSelf == false) 
		{
			Cargar_Em.Actualizar_Escena ();
		}

	}
	void error()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		Cargar_Em = GameObject.Find ("ControlEscenasEmpatia").GetComponent<CargarEmpatia> ();
		print ("error");
		GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("Fallo");
		CE.Intentos++;
		
		if(CE.Intentos==4)
		{
			Cargar_Em.vidas [CE.Intentos-2].SetActive (false);
			IfinJuego.SetActive(true);
			
			ControlMonedas = GameObject.Find ("controlMonedas");
			cM = ControlMonedas.GetComponent<Control_monedas> ();
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasSocialNivel1 = GameObject.Find ("monedas");
			TmonedasSocialNivel1 = monedasSocialNivel1.GetComponent<Text> ();
			
			cM.calcular_monedaSocialNivel1 ();
			cM.calcular_monedasGenerales ();
			if (CE.Intentos == 1) 
			{
				if(CE.emociones1_completado==true)
				{
					cdg_3d.Altar_Desbloqueado=true;
					CNotificaciones.Isla.SetActive (true);
					GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				}
				else if(CE.emociones1_completado==false)
				{
					CE.empatia1_completado=true;
				}
				
				Invoke ("ActivarEstrella1", 1.0f);
				Invoke ("ActivarEstrella2", 2.0f);
				Invoke ("ActivarEstrella3", 3.0f);
				
				SiguienteSituacion.SetActive (true);
				if(CE.EjercicioSocial<CE.ASocialNivel1.Length)
				{
					CE.ASocialNivel1[CE.EjercicioSocial]=true;
				}
				DD.AEmpatia[1] = true;
				
			} 
			else 
			{
				if (CE.Intentos == 2) 
				{
					if(CE.emociones1_completado==true)
					{
						cdg_3d.Altar_Desbloqueado=true;
						CNotificaciones.Isla.SetActive (true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					else if(CE.emociones1_completado==false)
					{
						CE.empatia1_completado=true;
					}
					
					Invoke ("ActivarEstrella1", 1.0f);
					Invoke ("ActivarEstrella2", 2.0f);
					
					SiguienteSituacion.SetActive (true);
					if(CE.EjercicioSocial<CE.ASocialNivel1.Length)
					{
						CE.ASocialNivel1[CE.EjercicioSocial]=true;
					}
					DD.AEmpatia[1] = true;
					
					
				} 
				else if (CE.Intentos == 3)
				{
					if(CE.emociones1_completado==true)
					{
						cdg_3d.Altar_Desbloqueado=true;
						CNotificaciones.Isla.SetActive (true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					else if(CE.emociones1_completado==false)
					{
						CE.empatia1_completado=true;
					}
					
					Invoke ("ActivarEstrella1", 1.0f);
					
					SiguienteSituacion.SetActive (true);
					if(CE.EjercicioSocial<CE.ASocialNivel1.Length)
					{
						CE.ASocialNivel1[CE.EjercicioSocial]=true;
					}
					DD.AEmpatia[1] = true;
					
					
				}
			}
			
			
			TpuntuacionFin.text = "\nIntentos: " + CE.Intentos.ToString();
			
			TmonedasSocialNivel1.text = cM.monedasSocialNivel1.ToString();
			

			CE.Intentos = 1;
			cM.monedasSocialNivel1 = 0;
			CE.respuesta = true;
		}
		else
		{
			Cargar_Em.vidas [CE.Intentos-2].SetActive (false);
		}
		print ("incorrecto");
	}
	void actualizarPuntuacion()
	{
		puntuacion = GameObject.Find ("puntuacion");
		Tpuntuacion = puntuacion.GetComponent<Text> ();
		
		Tpuntuacion.text = CE.Intentos.ToString();
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
}
