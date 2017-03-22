using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelecLenguaje : MonoBehaviour 
{
	ControlEscenas CE;
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	SaveLoad SL;

	public Sprite Check;
	public Sprite NoCheck;
	public GameObject BEspañol;
	public GameObject BIngles;
	public GameObject BEuskera;
	public GameObject BFrances;

	// Use this for initialization
	void Start () 
	{

		CE=GameObject.Find("control escenas").GetComponent<ControlEscenas>();

		switch(languageDictionary.lang)
		{
		case null:
			Español();
			break;
		case "Spanish":
			Español();
			break;
		case "English":
			Ingles();
			break;
		case "Euskara":
			Euskera();
			break;
		case "Frances":
			Frances();
			break;
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Español()
	{
		BEspañol.GetComponent<Image>().sprite = Check;
		BIngles.GetComponent<Image>().sprite = NoCheck;
		BEuskera.GetComponent<Image>().sprite = NoCheck;
		BFrances.GetComponent<Image>().sprite = NoCheck;

		languageDictionary.lang = "Spanish";
		//languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}
	public void Ingles()
	{
		BEspañol.GetComponent<Image>().sprite = NoCheck;
		BIngles.GetComponent<Image>().sprite = Check;
		BEuskera.GetComponent<Image>().sprite = NoCheck;
		BFrances.GetComponent<Image>().sprite = NoCheck;
		
		languageDictionary.lang = "English";
		//languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}
	public void Euskera()
	{
		BEspañol.GetComponent<Image>().sprite = NoCheck;
		BIngles.GetComponent<Image>().sprite = NoCheck;
		BEuskera.GetComponent<Image>().sprite = Check;
		BFrances.GetComponent<Image>().sprite = NoCheck;
		
		languageDictionary.lang = "Euskara";
		//languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}
	public void Frances()
	{
		BEspañol.GetComponent<Image>().sprite = NoCheck;
		BIngles.GetComponent<Image>().sprite = NoCheck;
		BEuskera.GetComponent<Image>().sprite = NoCheck;
		BFrances.GetComponent<Image>().sprite = Check;
		
		languageDictionary.lang = "Frances";
		//languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}

	public void confirmar_idioma()
	{
		languageDictionary.stringList.Clear();
		languageDictionary.Lenguaje();

		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();
		//Application.LoadLevel("Nivel1_dado2.0");
		CDG_Mundo3D = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		if (CDG_Mundo3D.islaBosque == true) 
		{
			Application.LoadLevel ("Isla_bosque");
			SL.Save();
		}
		else if (CDG_Mundo3D.islaMec == true) 
		{
			Application.LoadLevel ("Isla_Mecanica_v3");
			SL.Save();
		}
		else if (CDG_Mundo3D.islaFant == true) {
			Application.LoadLevel ("Isla_fantasma");
			SL.Save();
		}
		else
		{
			Application.LoadLevel("personalizacion2.0");
		}
		


	}

}
