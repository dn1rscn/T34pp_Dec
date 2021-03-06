using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuestaSocialNivel2 : MonoBehaviour 
{
	ControlAleatorioSocialNivel2 CAN2;

	ControlEmociones CE;
	DatosDesbloqueo DD;
	ControlNotificaciones1 CNotificaciones;
	ControlDatosGlobales_Mundo3D cdg_3d;
	CargarEmpatia Cargar_Em;
	ControlMisiones CMisiones;
	SaveLoad SL;
	
	public GameObject IfinJuego;
	
	//public GameObject BotonVolverGrande;
	
	public GameObject SiguienteSituacion;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasSocialNivel2;
	Text TmonedasSocialNivel2;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;
	// Use this for initialization
	void Start () 
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();
		//CSlider = GameObject.Find ("Progreso").GetComponent<ControlSlider> ();

		//CSlider.progresoEmocionesSNivel1 ();
		CE.respuesta = false;
		CNotificaciones.Isla.SetActive (false);
		CNotificaciones.Nivel2.SetActive(false);
		CNotificaciones.GMision.SetActive (false);
		for(int i=0;i < CNotificaciones.MisionDino.Length; i++)
		{
			CNotificaciones.MisionDino[i].SetActive(false);
		}
		//actualizarPuntuacion ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void respuesta()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		Cargar_Em = GameObject.Find ("ControlEscenasEmpatia").GetComponent<CargarEmpatia> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();


		if (CE.respuesta == false) 
		{
			CAN2 = GameObject.Find ("ctrlAleatorio").GetComponent<ControlAleatorioSocialNivel2> ();
			switch (Cargar_Em.PreguntaAleat) {

			case 1:
				if (gameObject.GetComponent<Image> ().sprite.name == "Enfado") 
				{
					correcto ();
				} 
				else {
					error ();
				}
				break;
			case 2:
				if (gameObject.GetComponent<Image> ().sprite.name == "Asco") 
				{
					correcto ();
				} 
				else {
					error ();
				}
				break;
			case 3:
				if (gameObject.GetComponent<Image> ().sprite.name == "Verguenza") 
				{
					correcto ();
				} 
				else {
					error ();
				}
				break;
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
		GameObject.Find ("robot_animaciones_bake_v2").GetComponent<Animator> ().Play("acierto_robot");

		GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("acierto");
		
		print ("correcto");
		Cargar_Em.Ejer_Activos [Cargar_Em.PreguntaAleat-1] = true;
		
		for (int i=0; i<Cargar_Em.Ejer_Activos.Length&&Cargar_Em.Ejer_Activos[i]==true; i++) 
		{
			print("entro en for ");
			
			if(i==Cargar_Em.Ejer_Activos.Length-1&&Cargar_Em.Ejer_Activos[i]==true)
			{
				CNotificaciones.Isla.SetActive (false);
				CNotificaciones.Nivel2.SetActive(false);
				CNotificaciones.GMision.SetActive (false);
				for(int x=0;x < CNotificaciones.MisionDino.Length; x++)
				{
					CNotificaciones.MisionDino[x].SetActive(false);
				}

				IfinJuego.SetActive(true);
				IfinJuego.GetComponent<Animator>().Play("AnimFinPartida");
				


				CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();
				ControlMonedas = GameObject.Find ("controlMonedas");
				cM = ControlMonedas.GetComponent<Control_monedas> ();
				
				puntuacionfin = GameObject.Find ("puntuacionFin");
				TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
				
				monedasSocialNivel2 = GameObject.Find ("monedas");
				TmonedasSocialNivel2 = monedasSocialNivel2.GetComponent<Text> ();
				
				cM.calcular_monedaSocialNivel1 ();
				cM.calcular_monedasGenerales ();
				
				if (CE.Intentos == 1) 
				{
					if(DD.AEmpatia[2]==false)
					{
						CNotificaciones.Nivel3.SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					Invoke ("ActivarEstrella1", 1.0f);
					Invoke ("ActivarEstrella2", 2.0f);
					Invoke ("ActivarEstrella3", 3.0f);

                    SiguienteSituacion.SetActive(true);

                    DD.AEmpatia[2] = true;

					if(CE.NivelEmpatia == 2 &&CMisiones.ejerM_3estrellas[1]==false)
					{
						CMisiones.ejerM_3estrellas[1]=true;
						CMisiones.Mision_Robot();
						CNotificaciones.GMision.SetActive(true);
						CNotificaciones.MisionDino[1].SetActive(true);
						GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
					}
					
				} 
				else 
				{
					if (CE.Intentos == 2) 
					{
						if(DD.AEmpatia[2]==false)
						{
							CNotificaciones.Nivel3.SetActive(true);
							GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
						}

						Invoke ("ActivarEstrella1", 1.0f);
						Invoke ("ActivarEstrella2", 2.0f);

                        SiguienteSituacion.SetActive(true);
                        DD.AEmpatia[2] = true;
						
					} 
					else if(CE.Intentos == 3)
					{
						Invoke ("ActivarEstrella1", 1.0f);
                        SiguienteSituacion.SetActive(true);

                    }
				}
				
				//SiguienteSituacion.SetActive (true);
				
				//TpuntuacionFin.text = "\nIntentos: " + CE.Intentos.ToString();
				
				TmonedasSocialNivel2.text = cM.monedasSocialNivel1.ToString();

				SL.Save();

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
		GameObject.Find ("robot_animaciones_bake_v2").GetComponent<Animator> ().Play("fallo_robot");
		if(CE.Intentos==4)
		{
			Cargar_Em.vidas [CE.Intentos-2].SetActive (false);

			IfinJuego.SetActive(true);
			
			ControlMonedas = GameObject.Find ("controlMonedas");
			cM = ControlMonedas.GetComponent<Control_monedas> ();
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
			
			monedasSocialNivel2 = GameObject.Find ("monedas");
			TmonedasSocialNivel2 = monedasSocialNivel2.GetComponent<Text> ();
			
			cM.calcular_monedaSocialNivel1 ();
			cM.calcular_monedasGenerales ();
			
			if (CE.Intentos == 1) 
			{
				Invoke ("ActivarEstrella1", 1.0f);
				Invoke ("ActivarEstrella2", 2.0f);
				Invoke ("ActivarEstrella3", 3.0f);
                SiguienteSituacion.SetActive(true);
                DD.AEmpatia[2] = true;
				
			} 
			else 
			{
				if (CE.Intentos == 2) 
				{
					Invoke ("ActivarEstrella1", 1.0f);
					Invoke ("ActivarEstrella2", 2.0f);
                    SiguienteSituacion.SetActive(true);
                    DD.AEmpatia[2] = true;
					
				} 
				else if(CE.Intentos == 3)
				{
					Invoke ("ActivarEstrella1", 1.0f);
                    SiguienteSituacion.SetActive(true);
                    DD.AEmpatia[2] = true;
					
				}
			}
			
			//SiguienteSituacion.SetActive (true);
			
			TpuntuacionFin.text = "\nIntentos: " + CE.Intentos.ToString();
			
			TmonedasSocialNivel2.text = cM.monedasSocialNivel1.ToString();
			
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
