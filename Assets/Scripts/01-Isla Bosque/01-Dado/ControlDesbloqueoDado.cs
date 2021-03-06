﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlDesbloqueoDado : MonoBehaviour 
{
	DatosDesbloqueo DD;
	public Sprite[] imagenes_unlocked;
	public Sprite[] imagenes_Locked;

	public GameObject[] Acontrol_Dado;

	// Use this for initialization
	void Start () 
	{
		DD = GameObject.Find ("ctrDesbloqueo").GetComponent<DatosDesbloqueo> ();

		GameObject.Find("GAv4").GetComponent<GoogleAnalyticsV4>().LogScreen(new AppViewHitBuilder()
				.SetScreenName("Nivel Dado"));
		
		for (int i=0; i<DD.ADado.Length; i++) 
		{
			if(DD.ADado[i]==true)
			{
				Acontrol_Dado[i].GetComponent<Image>().sprite = imagenes_unlocked[i];
				Acontrol_Dado[i].transform.GetChild(0).gameObject.SetActive(true);
				Acontrol_Dado[i].GetComponent<Button>().enabled = true;
			}
			else if(DD.ADado[i]==false)
			{
				Acontrol_Dado[i].GetComponent<Image>().sprite=imagenes_Locked[i];
				Acontrol_Dado[i].transform.GetChild(0).gameObject.SetActive(false);
				Acontrol_Dado[i].GetComponent<Button>().enabled = false;
			}
		}
	
	}
}
