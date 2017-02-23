using UnityEngine;
using System.Collections;

public class ControlEscenaIKKI : MonoBehaviour 
{
	ControlDatosGlobales_Mundo3D CDG_Mundo3D;
	SaveLoad SL;
	// Use this for initialization
	void Start () 
	{
		CDG_Mundo3D = GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();
		SL = GameObject.Find ("saveload").GetComponent<SaveLoad> ();

		CDG_Mundo3D.IKKI = true;
		languageDictionary.Lenguaje();
		SL.Default();
		SL.Load ();
	}
}
