using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class Control_sonidos_dino : MonoBehaviour
{
	public AudioSource fallodino; 
	public AudioSource aciertodino;
	
	void Aciertodino ()
	{
		aciertodino.Play (); 
	}
	void Fallodino ()
	{
		fallodino.Play (); 
	}
}