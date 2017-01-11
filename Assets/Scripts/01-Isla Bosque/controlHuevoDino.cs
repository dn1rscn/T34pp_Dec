 using UnityEngine;
using System.Collections;

public class controlHuevoDino : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	ControlMisiones CMisiones;

	Animator animatorHuevo;
	ControlCamara ctlCamara;

	public GameObject huevoParaCoger;

	public bool primeraInteraccion = false;


	// Use this for initialization
	void Start () {
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		//ACCEDEMOS AL SCRIPT DE SEGUIMIENTO DE LAS MISIONES
		CMisiones=GameObject.Find ("Misiones").GetComponent<ControlMisiones>();

		animatorHuevo = gameObject.GetComponent<Animator>();
		ctlCamara = GameObject.Find("PivoteCamaraPrincipal").GetComponent<ControlCamara>();

		if(!CDG_Mundo3D.huevoInvisible)
		{
			animatorHuevo.Play("AnimEgg_00_reposo");
		} else {
			//Si nos hemos pasado el ejercicio 1 del dado
			if(CDG_Mundo3D.Ejer_Bosque[0] == true && CDG_Mundo3D.destinoHuevo == 1){
				//activamos el huevo y la preparamos su segunda animacion
				animatorHuevo.Play("AnimEgg_00_reposo");
				destinoHuevo_Sonidos();
			}

			else if(CMisiones.misionDinoCompletada) 
			{
				huevoParaCoger.SetActive(true);
				if(!CDG_Mundo3D.tenemosHuevoDino){
					huevoParaCoger.SetActive(false);
				}
				animatorHuevo.Play("huevoInvisible");
			} 
			else {
				huevoParaCoger.SetActive(false);
				animatorHuevo.Play("huevoInvisible");
			}
		}
	}
	
	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			print ("destinoHuevo = "+CDG_Mundo3D.destinoHuevo);
			ejecutarAnimHuevo();
		}
	}

	public void destinoHuevo_Sonidos()
	{

		CDG_Mundo3D.destinoHuevo = 2;
		CDG_Mundo3D.huevoInvisible = false;
	}

	public void ejecutarAnimHuevo()
	{
		if(!CDG_Mundo3D.huevoInvisible)
		{
			switch(CDG_Mundo3D.destinoHuevo)
			{
			case 1:
				animatorHuevo.Play("AnimEgg_01");
				print ("El huevo avanza hasta el portal del dado");
				primeraInteraccion=true;
				CDG_Mundo3D.huevoInvisible = true;
				break;
			case 2:
				ctlCamara.rotarCam_Izq();
				Invoke("rotarCamSegundaVez",0.1f);
				animatorHuevo.Play("AnimEgg_02");
				print ("El huevo avanza hasta el portal de sonidos");

				CDG_Mundo3D.huevoInvisible = true;
				break;
			case 3:
				print ("Hemos conseguido el huevo!!");
				CDG_Mundo3D.huevoInvisible = true;
				break;
			}
		}
		else {
			animatorHuevo.Play("huevoInvisible");
		}
	}

	public void rotarCamSegundaVez()
	{
		ctlCamara.rotarCam_Izq();
	}
}
