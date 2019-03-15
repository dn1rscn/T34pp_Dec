using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control_parental : MonoBehaviour
{
    public InputField año;
    //public bool MayorEdad = false;
    string URL;
    public GameObject CTRLPrarental;
    public GameObject warning;
    

	// Use this for initialization
	void Start ()
    {
        Cerrar();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    public void Confirmar()
    {
        if (año.text.Length == 4)
        {
            print(año.text + " tiene " + año.text.Length + " digitos");
            print(DateTime.Now.Year - Convert.ToInt32(año.text));
            if (DateTime.Now.Year - Convert.ToInt32(año.text) > 18)
            {
                Application.OpenURL(URL);
                Cerrar();
            }
            else if (DateTime.Now.Year - Convert.ToInt32(año.text) < 18)
            {
                warning.SetActive(true);
                warning.GetComponent<Text>().text = languageDictionary.stringList["Debes tener más de 18 años para seguir"];
                año.text = null;
            }
        }
        else
        {
            print("año no valido");
            warning.SetActive(true);
            warning.GetComponent<Text>().text = languageDictionary.stringList["El año introducido no es valido. introduce un año de 4 digitos"];
        }
    }

    public void Activar(string url)
    {
        URL = url;
        CTRLPrarental.SetActive(true);
        warning.SetActive(false);
    }

    public void Cerrar()
    {
        año.text = null;
        CTRLPrarental.SetActive(false);
        warning.SetActive(true);
    }
}
