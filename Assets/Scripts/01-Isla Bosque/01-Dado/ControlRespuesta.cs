﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlRespuesta : MonoBehaviour 
{
	ControlDatosGlobales_Mundo3D cdg_3d;
	ControlMisiones CMisiones;
	ControlNotificaciones1 CNotificaciones;
	SaveLoad SL;

	ControlDatosGlobales_PICTOGRAMAS cdg;
	GameObject DGlobales;

	Control_monedas cM;
	GameObject ControlMonedas;

	DatosDesbloqueo DD;
	
	GameObject puntuacion;
	Text Tpuntuacion;

	GameObject monedasDado;
	Text TmonedasDado;

	ControlSlider CSlider;

	public Material Im_Dado;

	public GameObject[] vidas;

	public GameObject IfinJuego;
	public GameObject IfinJuego2;

	public GameObject estrella1;
	public GameObject estrella2;
	public GameObject estrella3;

	public GameObject boton_back;
	public GameObject boton_SiguienteNivel;
	public GameObject boton_VolverAJugar;
	public GameObject boton_SeguirJugando;


	Renderer miRender;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;

	Animator animator_Cartel1;
	Animator animator_Cartel2;
	Animator animator_Cartel3;

	Animator animator_panelCanvas;
	Animator animator_Dino;


	// Use this for initialization
	void Start () 
	{

		animator_Dino = GameObject.Find("Dinoi_animaciones_v3").GetComponent<Animator>();
		animator_panelCanvas = GameObject.Find("Panel_Canvas").GetComponent<Animator>();

		DD = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();
		DGlobales = GameObject.Find ("DatosGlobales");
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();
		cdg_3d=GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();
		CSlider = GameObject.Find ("Progreso").GetComponent<ControlSlider> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();


		if(boton_SiguienteNivel){
			if(DD.Nivel2Dado && Application.loadedLevelName!="Nivel2_dado2.0"){
				boton_SiguienteNivel.SetActive(true);
			} 
			else{
				boton_SiguienteNivel.SetActive(false);
			}
		}

		if (boton_VolverAJugar){
			boton_VolverAJugar.SetActive(false);
		}

		boton_back.SetActive(true);

		resetearDado ();
		actualizarPuntuacion ();
		CSlider.ProgresoDado ();

		IfinJuego.SetActive (false);
		IfinJuego2.SetActive (false);


	}

	public void SeleccionRespuesta ()
	{
		DGlobales = GameObject.Find ("DatosGlobales");
		cdg = DGlobales.GetComponent<ControlDatosGlobales_PICTOGRAMAS> ();

		if (!cdg.resp) {

			//print (gameObject.name);
			//print (cdg.correcto);
			//FUNCION PARA DETECTAR LA RESPUESTA
			if (gameObject.name == "Cartel1" && cdg.correcto == 1) {
				cdg.resp = true;
				correcto ();
			} else {
				if (gameObject.name == "Cartel2" && cdg.correcto == 2) {
					cdg.resp = true;
					correcto ();
				} else {

					if (gameObject.name == "Cartel3" && cdg.correcto == 3) {
						cdg.resp = true;
						correcto ();
					}

					//FALLO DE REPUESTA
					else {
						error ();

					}
				}
			}
		} 
		else 
		{
			print("tira otra vez el dado");
			GameObject.Find("Dado").GetComponent<Animator>().Play ("Tirar_dado");
		}
	}

	void correcto()
	{
		if(DD.Nivel2Dado && Application.loadedLevelName!="Nivel2_dado2.0"){
			if (boton_SiguienteNivel){
				boton_SiguienteNivel.SetActive(true);
			}
		}

		animator_Dino.Play("Acierto_01_dino");
		animator_Dino.Play("Acierto_02_dino");

		animator_panelCanvas.Play("acierto");

		CSlider = GameObject.Find ("Progreso").GetComponent<ControlSlider> ();
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones1> ();
		CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();

		print ("correcto");

		cdg.aciertos++;
		cdg.aciertosSeguidos++;
		CSlider.ProgresoDado ();

		//ejecutarSonidoAcierto
		//GameObject.Find("SonidoAcierto").GetComponent<AudioSource>().Play();

		GameObject.Find ("Dado").GetComponent<Renderer> ().sharedMaterial = Im_Dado;
		GameObject.Find("Dado").GetComponent<Animator>().Play ("Tirar_dado");

		actualizarPuntuacion ();

		if (cdg.aciertosSeguidos == 3) 
		{
			cdg.combos++;
			cdg.aciertosSeguidos=0;
		}
		if (cdg.aciertos == 5) 
		{
			if(CMisiones.dado1==true&&CMisiones.Dado1_Completado==false)
			{
				CMisiones.Dado1_Completado=true;
				/*GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("Notificaciones")
					.SetEventAction("Nivel 1 dado Completado"));*/
			}
			if(CMisiones.dado1==true&&CMisiones.Sonidos1_Completado==true&&cdg_3d.IslaFantasma_Desbloqueada==false)
			{
				cdg_3d.IslaFantasma_Desbloqueada=true;
				CNotificaciones.Isla.SetActive(true);
				CNotificaciones.GMision.SetActive(false);
				CNotificaciones.Nivel2.SetActive(false);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("Notificaciones")
					.SetEventAction("Isla Fantasma Desbloqueada"));
			}
		}
		if(cdg.aciertos==15)
		{
			boton_SiguienteNivel.SetActive(true);
			SalirDelJuego();

			if(CMisiones.dado1==true&&CMisiones.ejerB_3estrellas[0]==false)
			{
				CMisiones.ejerB_3estrellas[0]=true;
				CMisiones.Mision_Dino();
				CNotificaciones.Nivel2.SetActive(false);
				CNotificaciones.Isla.SetActive(false);
				CNotificaciones.GMision.SetActive(true);
				for(int i=0;i < CNotificaciones.MisionDino.Length; i++)
				{
					CNotificaciones.MisionDino[i].SetActive(false);
				}
				CNotificaciones.MisionDino[0].SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				//SalirDelJuego();
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("Notificaciones")
					.SetEventAction("Nivel 1 dado 3 estrellas"));
			}
			if(CMisiones.dado2==true&&CMisiones.ejerB_3estrellas[1]==false)
			{
				CMisiones.ejerB_3estrellas[1]=true;
				CMisiones.Mision_Dino();
				CNotificaciones.Nivel2.SetActive(false);
				CNotificaciones.Isla.SetActive(false);
				CNotificaciones.GMision.SetActive(true);
				for(int i=0;i < CNotificaciones.MisionDino.Length; i++)
				{
					CNotificaciones.MisionDino[i].SetActive(false);
				}
				CNotificaciones.MisionDino[1].SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				//SalirDelJuego();
				GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("Notificaciones")
					.SetEventAction("Nivel 2 dado Completado3 estrellas"));
			}
		}
		if (cdg.aciertos == 10 && DD.Nivel2Dado == false) 
		{
			CNotificaciones.Nivel2.SetActive(true);
			CNotificaciones.GMision.SetActive(false);
			CNotificaciones.Isla.SetActive(false);
			GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");

			//GameObject.Find ("Dado").GetComponent<ControlDado>().enabled=false;

			if(DD.Posicion+1<DD.ADado.Length)
			{
				DD.ADado[DD.Posicion=DD.Posicion+1]=true;
			}

			DD.Nivel2Dado=true;
			GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("Notificaciones")
					.SetEventAction("Nivel 2 dado Desbloqueado"));
		}
	}
	void error()
	{
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();

		print ("error");
		GameObject.Find("Dinoi_animaciones_v3").GetComponent<Animator>().Play("Fallo_01_dino");

		cdg.fallos++;
		cdg.aciertosSeguidos=0;


		//ejecutar animacionError
		GameObject.Find("Panel_Canvas").GetComponent<Animator>().Play("Fallo");
		
		//ejecutarSonidoFallo
		//GameObject.Find("SonidoFallo").GetComponent<AudioSource>().Play();

		if (cdg.fallos == 3) 
		{
			vidas [cdg.fallos-1].SetActive (false);
			boton_back.SetActive(false);
			boton_VolverAJugar.SetActive(true);
			boton_SeguirJugando.SetActive(false);

			cdg_3d=GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
			CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();

			IfinJuego.SetActive (true);
			IfinJuego.GetComponent<Animator>().Play ("AnimFinPartida");
			
			puntuacionfin = GameObject.Find ("puntuacionFin");
			TpuntuacionFin = puntuacionfin.GetComponent<Text> ();

			monedasDado = GameObject.Find ("monedas");
			TmonedasDado = monedasDado.GetComponent<Text> ();

			cM.calcular_monedasDado ();
			cM.calcular_monedasGenerales ();

			if (cdg.aciertos >= 5) 
			{
				Invoke ("ActivarEstrella1", 1.0f);

				if(cdg_3d.Ejer_Bosque[0]==false)
				{
					cdg_3d.Ejer_Bosque[0]=true;
				}

			}
			if (cdg.aciertos >= 10) 
			{
				Invoke ("ActivarEstrella2", 2.0f);
			
			}
			if (cdg.aciertos >= 15) 
			{
				Invoke ("ActivarEstrella3", 3.0f);
			}

			
			TpuntuacionFin.text = "\n" + cdg.aciertos.ToString () + "\n" + cdg.combos.ToString ();

			TmonedasDado.text = cM.monedas_dado.ToString();


			//TmonedasDado.text=languageDictionary.stringList [TmonedasDado];
			//languageDictionary.lang = "Spanish";

			TpuntuacionFin.text=languageDictionary.stringList [TpuntuacionFin.text];

			GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("puntuacion")
					.SetEventAction(Application.loadedLevelName)
					.SetEventLabel("aciertos")
					.SetEventValue(cdg.aciertos));

			resetearDado();

		} 
		else 
		{
			vidas [cdg.fallos-1].SetActive (false);
		}
	}

	void actualizarPuntuacion()
	{
		puntuacion = GameObject.Find ("puntuacion");
		Tpuntuacion = puntuacion.GetComponent<Text> ();

		Tpuntuacion.text = cdg.aciertos.ToString();
	}


	void ActivarEstrella1()
	{
		//estrella1.SetActive (true);
		GameObject.Find ("estrellas").GetComponent<Animator> ().Play ("AnimEstrella1");
		//estrella1.SetActive (true);
	}
	void ActivarEstrella2()
	{
		//estrella2.SetActive (true);
		GameObject.Find ("estrellas").GetComponent<Animator> ().Play ("AnimEstrella2");
		//estrella2.SetActive (true);
	}
	void ActivarEstrella3()
	{
		//estrella3.SetActive (true);
		GameObject.Find ("estrellas").GetComponent<Animator> ().Play ("AnimEstrella3");
		//estrella3.SetActive (true);
	}
	void resetearDado()
	{
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();

		cdg.aciertos = 0;
		cdg.fallos = 0;
		cdg.aciertosSeguidos = 0;
		cdg.combos = 0;
		cM.monedas_dado = 0;
	}
	public void SalirDelJuego()
	{
		boton_back.SetActive (false);

		IfinJuego.SetActive (true);
		IfinJuego.GetComponent<Animator>().Play ("AnimFinPartida");

		cdg_3d=GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		
		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
		
		monedasDado = GameObject.Find ("monedas");
		TmonedasDado = monedasDado.GetComponent<Text> ();
		
		cM.calcular_monedasDado ();
		cM.calcular_monedasGenerales ();
		
		
		if (cdg.aciertos >= 5) 
		{
			Invoke ("ActivarEstrella1", 1.0f);
			if(cdg_3d.Ejer_Bosque[0]==false)
			{
				cdg_3d.Ejer_Bosque[0]=true;
			}

		}
		if (cdg.aciertos >= 10) 
		{
			Invoke ("ActivarEstrella2", 2.0f);
			boton_SiguienteNivel.SetActive(true);
		
		}
		if (cdg.aciertos >= 15) 
		{			
			Invoke ("ActivarEstrella3", 3.0f);
			boton_SiguienteNivel.SetActive(true);

		}
		
		TpuntuacionFin.text =cdg.aciertos.ToString ()+ "\n" + cdg.combos.ToString ();
		
		TmonedasDado.text = cM.monedas_dado.ToString();

		SL.Save ();

		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogEvent(new EventHitBuilder()
					.SetEventCategory("puntuacion")
					.SetEventAction(Application.loadedLevelName)
					.SetEventLabel("aciertos")
					.SetEventValue(cdg.aciertos));

	}
	public void seguirJugando()
	{
		boton_back.SetActive (true);
		IfinJuego.SetActive (false);
		IfinJuego2.SetActive (false);
		GameObject.Find ("Dado").GetComponent<ControlDado>().enabled=true;
		cM.monedas = cM.monedas - cM.monedas_dado;
	}
}
