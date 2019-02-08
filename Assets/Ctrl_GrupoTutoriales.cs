using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;

public class Ctrl_GrupoTutoriales : MonoBehaviour
{
    public GameObject Tutoriales_Movil;
    public GameObject Tutoriales_ipad;

	// Use this for initialization
	void Start ()
    {
        if ((Device.generation.ToString()).Contains("iPad"))
        {
            Tutoriales_ipad.SetActive(true);
            Tutoriales_Movil.SetActive(false);
        }
        else
        {
            Tutoriales_Movil.SetActive(true);
            Tutoriales_ipad.SetActive(false);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
