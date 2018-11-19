using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctl_CartelIslaAltar : MonoBehaviour {


    public Texture textCartel_ESP;
    public Texture textCartel_ENG;
    public Texture textCartel_EUS;
    public Texture textCartel_FRA;

    public GameObject CartelFelicitacion;

    // Use this for initialization
    void Start () {

        //CartelFelicitacion = GameObject.Find("Isla_Altar_Cartel")();

        switch (languageDictionary.lang)
        {
            case null:
                CartelFelicitacion.GetComponent<Renderer>().material.mainTexture = textCartel_ESP;
                break;

            case "Spanish":
                CartelFelicitacion.GetComponent<Renderer>().material.mainTexture = textCartel_ESP;
                break;

            case "English":
                CartelFelicitacion.GetComponent<Renderer>().material.mainTexture = textCartel_ENG;
                break;

            case "Euskara":
                CartelFelicitacion.GetComponent<Renderer>().material.mainTexture = textCartel_EUS;
                break;

            case "Frances":
                CartelFelicitacion.GetComponent<Renderer>().material.mainTexture = textCartel_FRA;
                break;
        }
    }
	
}
