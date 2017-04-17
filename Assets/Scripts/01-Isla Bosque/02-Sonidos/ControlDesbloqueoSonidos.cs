using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlDesbloqueoSonidos : MonoBehaviour
	{

	DatosDesbloqueo DD;
	public Sprite[] imagenes_unlocked;
	public Sprite[] imagenes_Locked;


	public GameObject[] Acontrol_Sonidos;
	int i;

	// Use this for initialization
	void Start () 
	{
		DD = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();
		
		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
				.SetScreenName("Nivel Sonidos"));

		for (i=0; i<DD.ASonidos.Length; i++) 
		{
			if(DD.ASonidos[i]==true)
			{
				Acontrol_Sonidos[i].GetComponent<Image>().sprite = imagenes_unlocked[i];
				Acontrol_Sonidos[i].transform.GetChild(0).gameObject.SetActive(true);
				Acontrol_Sonidos[i].GetComponent<Button>().enabled=true;
			}
			else if(DD.ASonidos[i]==false)
			{
				Acontrol_Sonidos[i].GetComponent<Image>().sprite=imagenes_Locked[i];
				Acontrol_Sonidos[i].transform.GetChild(0).gameObject.SetActive(false);
				Acontrol_Sonidos[i].GetComponent<Button>().enabled=false;
			}
		}
		
	}
}
