using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class A_NObjetos : MonoBehaviour
{
    Control_PuntuacionObjetos CPO;
    public Text texto_Actualizar;

    // Use this for initialization
    void Start ()
    {
        if (GameObject.Find("PuntuacionObjetos"))
        {
            CPO = GameObject.Find("PuntuacionObjetos").GetComponent<Control_PuntuacionObjetos>();
            print("num gafas = "+CPO.GafasRecogidas);
            texto_Actualizar.text = CPO.GafasRecogidas.ToString() + ("/4");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
