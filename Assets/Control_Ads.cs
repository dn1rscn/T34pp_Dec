using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_ADS
    using UnityEngine.Advertisements;
#endif


public class Control_Ads : MonoBehaviour
{
    public static Control_Ads Instance { get; private set; } //creamos una instancia interface
    private bool m_awaitingCallback = false;
    private string m_callbackVideoid;

    private void Awake()
    {
        Instance = this; //cargamos la instancia, este script
    }

    public void mostrarAnuncios(string videoID, bool enableCallback)  //llamamos al anuncio(videoID) y booleana que nos indica si el video se puede saltar o tiene recompensa
    {
       #if UNITY_ADS                                   //solo se ejecuta si tenemos el ads
            if(!Advertisement.IsReady(videoID))         //comprobamos si los ads funcionan
            {
                Debug.LogWarning("No esta disponible para cargar " + videoID);
            }
            else
            {
                ShowOptions opciones = new ShowOptions();
                if(enableCallback)                      //si queremos una recompensa
                {
                    if (m_awaitingCallback)             //comprobamos si hay algun video reproduciendose
                        return;
                    m_callbackVideoid = videoID;
                    m_awaitingCallback = true;
                    opciones.resultCallback = OnAdd_Result;
                }
                Advertisement.Show(videoID, opciones);
            }
      #endif
    }

#if UNITY_ADS
    private void OnAdd_Result(ShowResult resultados)
    {
        m_awaitingCallback = false;

        switch(resultados)
        {
            case ShowResult.Finished:
                Debug.Log("video finalizado");
                break;

            case ShowResult.Skipped:
                break;

            case ShowResult.Failed:
                break;
        }
    }
#endif
}
