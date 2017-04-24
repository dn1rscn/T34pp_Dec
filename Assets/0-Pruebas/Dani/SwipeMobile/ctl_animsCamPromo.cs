using UnityEngine;
using System.Collections;

public class ctl_animsCamPromo : MonoBehaviour {

	Animator animatorEscena;
	int contSwipe;

	void Start(){
		animatorEscena = gameObject.GetComponent<Animator>();
		contSwipe = 0;
	}

	private void Update()
	{
		if(SwipeManager.Instance.IsSwiping(SwipeDirection.Left))
		{
			contSwipe++;
			animCamara01();
		}
	}

	public void animCamara01 ()
	{
		switch (contSwipe) 
		{
		case 1:
			print ("animacion1");
			animatorEscena.Play("animPromo_01");
			break;
		case 2:
			print ("animacion2");
			animatorEscena.Play("animPromo_02");
			break;
		case 3:
			print ("animacion3");
			animatorEscena.Play("animPromo_03");
			break;
		}

	}
}
