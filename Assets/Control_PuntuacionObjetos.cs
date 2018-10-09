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
		

		if (cont == null) 
		{
			cont = this;
			DontDestroyOnLoad (gameObject);


		} else if (cont != this) 
		{
			Destroy(gameObject);
		}
        //actualizar_Objetos();
    }
	public void actualizar_Objetos()
	{
		print("actualizar puntuacion");
		if(GameObject.Find("NumGafas"))
		{
			GameObject.Find("NumGafas").GetComponent<Text> ().text = GafasRecogidas.ToString()+("/4");
            print("ACTUALIZAMOS GAFAS" + GafasRecogidas);
		}
		if(GameObject.Find("NumEnergia"))
		{
			print("energia");
			GameObject.Find("NumEnergia").GetComponent<Text> ().text = EnergiaRecogida.ToString()+("/4");
		}
	}
}
