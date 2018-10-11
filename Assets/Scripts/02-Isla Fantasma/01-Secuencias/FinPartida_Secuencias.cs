using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinPartida_Secuencias : MonoBehaviour 
{
	public GameObject IfinJuego;
	public GameObject SiguienteSecuencia;
	public GameObject ISalir;
	public GameObject boton_Back;
	
	Control_monedas cM;
	GameObject ControlMonedas;
	
	GameObject puntuacion;
	Text Tpuntuacion;
	
	GameObject monedasSecuencia;
	Text TmonedasSecuencia;
	
	GameObject puntuacionfin;
	Text TpuntuacionFin;
	ControlSecuencias cs;
	GameObject ctrlsecuencias;
	ControlMisiones CMisiones;
	DatosDesbloqueo DD;
	ControlNotificaciones2 CNotificaciones;
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	SaveLoad SL;

	// Use this for initialization
	void Start () 
	{
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones2> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();

		boton_Back.SetActive (true);

		IfinJuego.SetActive (false);
		CNotificaciones.Siguiente_Secuencia.SetActive(false);
		CNotificaciones.Isla.SetActive (false);
		CNotificaciones.misiones.SetActive (false);
		for(int i=0;i < CNotificaciones.MisionFantasma.Length; i++)
		{
			CNotificaciones.MisionFantasma[i].SetActive(false);
		}
	}
	
	public void finjuego()
	{
		boton_Back.SetActive (false);

		CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();
		DD = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();
		CNotificaciones = GameObject.Find ("Notificaciones").GetComponent<ControlNotificaciones2> ();
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		ctrlsecuencias = GameObject.Find ("DatosGlobalesSecuencias");
		cs = ctrlsecuencias.GetComponent<ControlSecuencias> ();
		Debug.Log("finjuego2");

		IfinJuego.SetActive(true);
		IfinJuego.GetComponent<Animator>().Play ("AnimFinPartida");

		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		
		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
		
		monedasSecuencia = GameObject.Find ("monedas");
		TmonedasSecuencia = monedasSecuencia.GetComponent<Text> ();
		
		cM.calcular_monedasSecuencia ();
		cM.calcular_monedasGenerales ();
		
		if (cs.fallos == 2 ) 
		{
			if(cs.Secuencia==1&&DD.Canasta==true&&CDG_Mundo3D.IslaMec_Desbloqueada==false)
			{
				CDG_Mundo3D.IslaMec_Desbloqueada=true;
				CNotificaciones.Isla.SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
			}
			else if(cs.Secuencia==1&&DD.Canasta==false)
			{
				DD.secuencia1=true;
			}
			Invoke ("ActivarEstrella1", 1.0f);
			//ActivarEstrella1();
			SiguienteSecuencia.SetActive(true);
			if(cs.Secuencia<cs.Asecuencias.Length&&cs.Asecuencias[cs.Secuencia]==false)
			{
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				CNotificaciones.Siguiente_Secuencia.SetActive(true);
				if(cs.Secuencia<cs.Asecuencias.Length)
				{
					cs.Asecuencias[cs.Secuencia]=true;
				}
			}
		}
		if (cs.fallos == 1) 
		{
			if(cs.Secuencia==1&&DD.Canasta==true&&CDG_Mundo3D.IslaMec_Desbloqueada==false)
			{
				CDG_Mundo3D.IslaMec_Desbloqueada=true;
				CNotificaciones.Isla.SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
			}
			else if(cs.Secuencia==1&&DD.Canasta==false)
			{
				DD.secuencia1=true;
			}
			Invoke ("ActivarEstrella1", 1.0f);
			Invoke ("ActivarEstrella2", 2.0f);
			SiguienteSecuencia.SetActive(true);
			print(cs.Secuencia);
			if(cs.Secuencia<cs.Asecuencias.Length&&cs.Asecuencias[cs.Secuencia]==false)
			{
				CNotificaciones.Siguiente_Secuencia.SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				if(cs.Secuencia<cs.Asecuencias.Length)
				{
					cs.Asecuencias[cs.Secuencia]=true;
				}
			}
		}
		if (cs.fallos == 0) {
			Invoke ("ActivarEstrella1", 1.0f);
			Invoke ("ActivarEstrella2", 2.0f);
			Invoke ("ActivarEstrella3", 3.0f);
			if(cs.Secuencia==1&&DD.Canasta==true&&CDG_Mundo3D.IslaMec_Desbloqueada==false)
			{
				CDG_Mundo3D.IslaMec_Desbloqueada=true;
				CNotificaciones.Isla.SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
			}
			else if(cs.Secuencia==1&&DD.Canasta==false)
			{
				DD.secuencia1=true;
			}
			SiguienteSecuencia.SetActive(true);
			if(cs.Secuencia<cs.Asecuencias.Length&&cs.Asecuencias[cs.Secuencia]==false)
			{
				CNotificaciones.Siguiente_Secuencia.SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
				if(cs.Secuencia<cs.Asecuencias.Length)
				{
					cs.Asecuencias[cs.Secuencia]=true;
				}
			}
			if(CMisiones.ejerF_3estrellas[cs.Secuencia-1]==false)
			{
				CNotificaciones.misiones.SetActive(true);
				CMisiones.ejerF_3estrellas[cs.Secuencia-1]=true;
				CMisiones.Mision_Fantasma();
				CNotificaciones.MisionFantasma[cs.Secuencia-1].SetActive(true);
				GameObject.Find("Notificaciones").GetComponent<Animator>().Play("abrirNotificacion");
			}
		}
		
		
		TpuntuacionFin.text = cs.fallos.ToString ();
		
		TmonedasSecuencia.text = cM.monedas_secuencia.ToString();

		SL.Save();
		
		resetar_secuencias ();
		
	}
	
	void ActivarEstrella1()
	{
		print ("ZZZZZZZ");
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
	
	public void resetar_secuencias()
	{
		ctrlsecuencias = GameObject.Find ("DatosGlobalesSecuencias");
		cs = ctrlsecuencias.GetComponent<ControlSecuencias> ();
		
		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		
		cs.fallos = 0;
		cM.monedas_secuencia = 0;
		cs.p1 = false;
		cs.p2 = false;
		cs.p3 = false;
	}

	public void SalirSecuencias()
	{
		boton_Back.SetActive (false);
		ISalir.SetActive (true);
		ISalir.GetComponent<Animator>().Play ("AnimFinPartida");

		ControlMonedas = GameObject.Find ("controlMonedas");
		cM = ControlMonedas.GetComponent<Control_monedas> ();
		
		puntuacionfin = GameObject.Find ("puntuacionFin");
		TpuntuacionFin = puntuacionfin.GetComponent<Text> ();
		
		monedasSecuencia = GameObject.Find ("monedas");
		TmonedasSecuencia = monedasSecuencia.GetComponent<Text> ();
    
		TpuntuacionFin.text = "¿Quieres salir?";
		
		TmonedasSecuencia.text = cM.monedas_secuencia.ToString();
	}
	public void SeguirJugando()
	{
		ISalir.SetActive (false);
		boton_Back.SetActive (true);
	}

}
