using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activarPantallaCarga : MonoBehaviour {

	Image loadingScreen;

	void Start(){
		loadingScreen = GameObject.Find("loadingScreen").GetComponent<Image>();
        loadingScreen.enabled = false;

    }
    public void activarLoadingScreen(){
		loadingScreen.enabled = true;
	}
}
