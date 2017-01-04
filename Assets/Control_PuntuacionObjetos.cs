using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Control_PuntuacionObjetos : MonoBehaviour 
{
	public static Control_PuntuacionObjetos cont;

	public Text Gafas;
	public Text Energia;

	public int GafasRecogidas;
	public int EnergiaRecogida;


	void Awake ()
	{
		actualizar_Objetos ();

		if (cont == null) 
		{
			cont = this;
			DontDestroyOnLoad (gameObject);


		} else if (cont != this) 
		{
			Destroy(gameObject);
		}

	}
	public void actualizar_Objetos()
	{
		GameObject.Find("NumGafas").GetComponent<Text> ().text = GafasRecogidas.ToString()+("/4");
		GameObject.Find("NumEnergia").GetComponent<Text> ().text = EnergiaRecogida.ToString()+("/4");
	}
}
