using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControlScroll : MonoBehaviour 
{
	ControlEmociones CEm;

	//public Slider Slider;
	public Scrollbar Barra_Scroll;

	public GameObject[] Opciones;
	public GameObject contenido;

	public float transition;

	public float Valor_Scala;

	public GameObject Nivel_1;
	public GameObject Nivel_2;
	public GameObject Nivel_3;

	int B;
	// Use this for initialization
	void Start () 
	{
		tamaño_Scroll ();
		Barra_Scroll.value=0;
		Opciones[1].transform.localScale=Vector2.Lerp(Opciones[1].transform.localScale,new Vector2 (1,1),transition);
		Opciones[0].transform.localScale=Vector2.Lerp(Opciones[0].transform.localScale,new Vector2 (Valor_Scala,Valor_Scala),transition);
		Opciones[0].transform.SetAsLastSibling();
	}
	
	// Update is called once per frame
	/*void Update () 
	{
		if (Input.GetMouseButtonUp (0)&&gameObject.name=="Panel") 
		{
			print("suelto barra");
		}

	}
	*/

	void OnMouseDown()
	{

	}
	public void arrastrar()
	{
		
		CEm = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		switch (CEm.NivelEmociones) 
		{
		case 1:
			if (Barra_Scroll.value < 0.25f) { //boton
				B = 0;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.25f && Barra_Scroll.value < 0.75f) { //boton 1
				B = 1;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.75) { //boton 2
				B = 2;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			break;
		case 2:
			if (Barra_Scroll.value < 0.1f) { //boton
				B = 0;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.1f && Barra_Scroll.value < 0.35f) { //boton 1

				B = 1;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.35f && Barra_Scroll.value < 0.65f) { //boton 2

				B = 2;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.65f && Barra_Scroll.value < 0.85f) { //boton 3

				B = 3;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.85) { //boton 4

				B = 4;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			break;
		case 3:
			if (Barra_Scroll.value < 0.1f) { //boton
				B = 0;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.1f && Barra_Scroll.value < 0.26f) { //boton 1
			
				B = 1;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.26f && Barra_Scroll.value < 0.43f) { //boton 2

				B = 2;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.43f && Barra_Scroll.value < 0.59f) { //boton 3
			
				B = 3;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.59 && Barra_Scroll.value < 0.76) { //boton 4
			
				B = 4;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.76 && Barra_Scroll.value < 0.93) { //boton 5

				B = 5;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			if (Barra_Scroll.value >= 0.93) { //boton 5
			
				B = 6;
				Reducir_tamaño ();
				Ampliar_tamaño ();
			}
			break;
		}

	}

	public void detectarSoltarBarra()
	{
		CEm = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();
		
		switch (CEm.NivelEmociones) 
		{
		case 1:
			Control_Nivel1();
			break;
		case 2:
			Control_Nivel2();
			break;
		case 3:
			Control_Nivel3();
			break;
		}


	}
	void Control_Nivel1()
	{
		if (Barra_Scroll.value < 0.25f) { //boton
			//Barra_Scroll.value = 0;
			B = 0;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.25f && Barra_Scroll.value < 0.75f) { //boton 1
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.5f;
			B = 1;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.75) { //boton 2
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 1f;
			B = 2;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
	}
	void Control_Nivel2()
	{
		if (Barra_Scroll.value < 0.1f) { //boton
			//Barra_Scroll.value = 0;
			B = 0;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.1f && Barra_Scroll.value < 0.35f) { //boton 1
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.25f;
			B = 1;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.35f && Barra_Scroll.value < 0.65f) { //boton 2
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.5f;
			B = 2;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.65f && Barra_Scroll.value < 0.85f) { //boton 3
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.75f;
			B = 3;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.85) { //boton 4
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 1f;
			B = 4;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
	}
	void Control_Nivel3()
	{
		if (Barra_Scroll.value < 0.1f) { //boton
			//Barra_Scroll.value = 0;
			B = 0;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.1f && Barra_Scroll.value < 0.26f) { //boton 1
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.17f;
			B = 1;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.26f && Barra_Scroll.value < 0.43f) { //boton 2
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.34f;
			B = 2;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.43f && Barra_Scroll.value < 0.59f) { //boton 3
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.5f;
			B = 3;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.59 && Barra_Scroll.value < 0.76) { //boton 4
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.67f;
			B = 4;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.76 && Barra_Scroll.value < 0.93) { //boton 5
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 0.84f;
			B = 5;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
		if (Barra_Scroll.value >= 0.93) { //boton 5
			//Barra_Scroll.GetComponent<Scrollbar> ().value = 1f;
			B = 6;
			Reducir_tamaño ();
			Ampliar_tamaño ();
		}
	}
	void Reducir_tamaño()
	{
		for (int i=0; Opciones.Length>i; i++) 
		{
			Opciones[i].transform.localScale=Vector2.Lerp(Opciones[3].transform.localScale,new Vector2 (1,1),transition);
		}
	}
	void Ampliar_tamaño()
	{
		Opciones[B].transform.localScale=Vector2.Lerp(Opciones[B].transform.localScale,new Vector2 (Valor_Scala,Valor_Scala),transition);
		Opciones[B].transform.SetAsLastSibling();
	}
	void tamaño_Scroll()
	{
		CEm = GameObject.Find ("ctrEmociones").GetComponent<ControlEmociones> ();

		switch (CEm.NivelEmociones) 
		{
		case 1:

			contenido.GetComponent<RectTransform>().sizeDelta=new Vector2(1121f,350f);

			Nivel_1.SetActive(true);
			Nivel_2.SetActive(false);
			Nivel_3.SetActive(false);

			break;
		case 2:

			contenido.GetComponent<RectTransform>().sizeDelta=new Vector2(1747f,350f);

			Nivel_1.SetActive(true);
			Nivel_2.SetActive(true);
			Nivel_3.SetActive(false);

			break;
		case 3:

			contenido.GetComponent<RectTransform>().sizeDelta=new Vector2(2243f,350f);

			Nivel_1.SetActive(true);
			Nivel_2.SetActive(true);
			Nivel_3.SetActive(true);

			break;
		}
	}

	public void Volver_Jugar()
	{
		Application.LoadLevel ("Emociones");
	}

	public void siguiente_Nivel()
	{
		CEm.NivelEmociones++;

		Application.LoadLevel ("Emociones");
	
	}
	public void salir()
	{
		if (CEm.NivelEmociones < 3)
		{
			Application.LoadLevel ("2-Emociones_SelecNivel");
		} 
		else if(CEm.NivelEmociones==3)
		{
			Application.LoadLevel ("Isla_Mecanica_v3");
		}

		CEm.Intentos=1;
		CEm.respuesta=true;
	}
}
