using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class controlRespAleatoria : MonoBehaviour 
{
	public Sprite[] AImRespuesta;
	public GameObject[] ARespuestas;

	ControlEmociones CE;
	
	public int RespuestaAleat;

	// Use this for initialization
	void Start () 
	{
		//RespuesAleatoria ();
	}
	public void RespuesAleatoria()
	{
		CE = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		//CE.EjercicioSocial = Random.Range (0,3);
		RespuestaAleat = Random.Range (1, 3);
		//ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [RespuestaAleat];
		switch(CE.EjercicioSocial)
		{
		
		case 0:
			print("CAse 0");
			print(CE.EjercicioSocial);
			switch (RespuestaAleat) 
			{
			case 1:					//respuesta correcta en cartel1
				ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [1];
				ARespuestas [1].GetComponent<Image> ().sprite = AImRespuesta [0];
				break;
				
			case 2:					//respuesta correcta en cartel2
				ARespuestas [1].GetComponent<Image> ().sprite = AImRespuesta [1];
				ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [0];
				break;
				
			default:
				break;
			}
			break;
		case 1:
			print("CAse 1");
			print(CE.EjercicioSocial);
			switch (RespuestaAleat) 
			{
			case 1:					//respuesta correcta en cartel1
				ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [2];
				ARespuestas [1].GetComponent<Image> ().sprite = AImRespuesta [3];
				break;
				
			case 2:					//respuesta correcta en cartel2
				ARespuestas [1].GetComponent<Image> ().sprite = AImRespuesta [2];
				ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [3];
				break;
				
			default:
				break;
			}
			break;
		case 2:
			print("CAse 2");
			print(CE.EjercicioSocial);
			switch (RespuestaAleat) 
			{
			case 1:					//respuesta correcta en cartel1
				ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [5];
				ARespuestas [1].GetComponent<Image> ().sprite = AImRespuesta [4];
				break;
				
			case 2:					//respuesta correcta en cartel2
				ARespuestas [1].GetComponent<Image> ().sprite = AImRespuesta [5];
				ARespuestas [0].GetComponent<Image> ().sprite = AImRespuesta [4];
				break;
				
			default:
				break;
			}
			break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
