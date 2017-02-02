using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Traduccion : MonoBehaviour
{
	Text textComponent;
	string text;
	//public string lenguaje = languageDictionary.lang;
	//languageDictionary LDIC;
	// Use this for initialization
	void Start ()
	{
		//LDIC=GameObject.Find("Diccionario").GetComponent<languageDictionary>();

		//languageDictionary.lang = "English";
		//print(languageDictionary.lang);
		//languageDictionary.Lenguaje();
	
		print(languageDictionary.lang);
		//languageDictionary.Lenguaje();
			
		textComponent=GetComponent<Text>();
		text=textComponent.text;
			
		print(text);
			
		textComponent.text=languageDictionary.stringList [text];



	}
	
	// Update is called once per frame
	/*void Awake ()
	{
		print(languageDictionary.lang);

		textComponent=GetComponent<Text>();
		text=textComponent.text;

		print(text);
		
		textComponent.text=languageDictionary.stringList [text];
	}*/
}

