using UnityEngine;
using System.Collections;

public class controlHuevoDino : MonoBehaviour {

	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	
	Animator animatorHuevo;
	ControlCamara ctlCamara;

	public bool primeraInteraccion = false;


	// Use this for initialization
	void Start () {
		//ACCEDEMOS AL SCRIPT DE DATOS GLOBALES
		CDG_Mundo3D = GameObject.Find("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D>();

		animatorHuevo = gameObject.GetComponent<Animator>();
		ctlCamara = GameObject.Find("PivoteCamaraPrincipal").GetComponent<ControlCamara>();

		if(!CDG_Mundo3D.huevoInvisible)
		{
			animatorHuevo.Play("AnimEgg_00_reposo");
		} else {
			animatorHuevo.Play("huevoInvisible");
		}
	}
	
	void OnTriggerEnter(Collider coli)
	{
		if (coli.gameObject.name == "Chico_TEAPlay") 
		{
			CDG_Mundo3D.destinoHuevo++; 
			print ("destinoHuevo = "+CDG_Mundo3D.destinoHuevo);
			ejecutarAnimHuevo();
		}
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
				break;
			case 2:
				animatorHuevo.Play("AnimEgg_02");
				print ("El huevo avanza hasta el portal de sonidos");

				//ctlCamara.

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
	
}
