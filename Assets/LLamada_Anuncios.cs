using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLamada_Anuncios : MonoBehaviour {

    public void Anuncio()
    {
        Control_Ads.Instance.mostrarAnuncios("video", false);
    }
}
