using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelecLenguaje : MonoBehaviour 
{
	public Sprite Check;
	public Sprite NoCheck;
	public GameObject BEspañol;
	public GameObject BIngles;
	public GameObject BEuskera;

	// Use this for initialization
	void Start () 
	{
		Español();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Español()
	{
		BEspañol.GetComponent<Image>().sprite = Check;
		BIngles.GetComponent<Image>().sprite = NoCheck;
		BEuskera.GetComponent<Image>().sprite = NoCheck;

		languageDictionary.lang = "Spanish";
		languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}
	public void Ingles()
	{
		BEspañol.GetComponent<Image>().sprite = NoCheck;
		BIngles.GetComponent<Image>().sprite = Check;
		BEuskera.GetComponent<Image>().sprite = NoCheck;
		
		languageDictionary.lang = "English";
		languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}
	public void Euskera()
	{
		BEspañol.GetComponent<Image>().sprite = NoCheck;
		BIngles.GetComponent<Image>().sprite = NoCheck;
		BEuskera.GetComponent<Image>().sprite = Check;
		
		languageDictionary.lang = "Euskara";
		languageDictionary.Lenguaje();
		print(languageDictionary.lang);
	}
}
