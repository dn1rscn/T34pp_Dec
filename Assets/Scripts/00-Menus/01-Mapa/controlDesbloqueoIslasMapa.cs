﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlDesbloqueoIslasMapa : MonoBehaviour 
{
	ControlDatosGlobales_Mundo3D cdg_3d;
	public GameObject[] Islas;

	public Sprite[] islas_unlocked;
	public Sprite[] islas_Locked;

	// Use this for initialization
	void Start () 
	{
		cdg_3d=GameObject.Find ("ControlDatosGlobales").GetComponent<ControlDatosGlobales_Mundo3D> ();

		if (cdg_3d.IslaFantasma_Desbloqueada == true && cdg_3d.Demo==false) 
		{
			Islas[0].GetComponent<Image>().sprite = islas_unlocked[0];
		} 
		else 
		{
			Islas[0].GetComponent<Image>().sprite = islas_Locked[0];
		}
		if (cdg_3d.IslaMec_Desbloqueada == true) 
		{
			Islas[1].GetComponent<Image>().sprite = islas_unlocked[1];
		} 
		else 
		{
			Islas[1].GetComponent<Image>().sprite = islas_Locked[1];
		}
	}
}
