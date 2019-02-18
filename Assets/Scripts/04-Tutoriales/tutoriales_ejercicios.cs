using UnityEngine;
using System.Collections;
using UnityEngine.iOS;

public class tutoriales_ejercicios : MonoBehaviour 
{
	public GameObject botonTuto;
    public GameObject botonTutoIpad;
	// Use this for initialization
	void Start ()
    {
        if (Application.loadedLevelName.Contains("1")|| Application.loadedLevelName.Contains("Canasta")|| Application.loadedLevelName.Contains("Dientes")|| Application.loadedLevelName.Contains("Emociones"))
        {
            if ((Device.generation.ToString()).Contains("iPad"))
            {
                botonTuto.SetActive(false);
                botonTutoIpad.SetActive(true);
            }
            else
            {
                botonTuto.SetActive(true);
                botonTutoIpad.SetActive(false);
            }
        }
        else
        {
            CerrarPantallaTutorial();
        }
    }
	
	//CERRAR LA PANTALLA DE TUTORIAL
	public void CerrarPantallaTutorial()
	{
        botonTuto.SetActive(false);
        botonTutoIpad.SetActive(false);
    }

	public void info()
	{
        if ((Device.generation.ToString()).Contains("iPad"))
        {
            botonTuto.SetActive(false);
            botonTutoIpad.SetActive(true);
        }
        else
        {
            botonTuto.SetActive(true);
            botonTutoIpad.SetActive(false);
        }
    }
}
