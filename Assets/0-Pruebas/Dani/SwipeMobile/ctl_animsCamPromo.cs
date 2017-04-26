using UnityEngine;
using System.Collections;

public class ctl_animsCamPromo : MonoBehaviour {

	Animator animatorEscena;
	Animator animatorSwipePoints;
	Animator animatorSwipeIcon;

	int contSwipe;
	int contFail;

	void Start(){
		animatorEscena = gameObject.GetComponent<Animator>();
		animatorSwipePoints = GameObject.Find("swipePoints_01").GetComponent<Animator>();
		animatorSwipeIcon = GameObject.Find("swipeIcon").GetComponent<Animator>();

		contSwipe = 0;
		contFail = 0;

	}

	private void Update()
	{
		//Si no hemos hecho swipe, y detecta que presionamos la pantalla:
		if(SwipeManager.Instance.IsSwiping(SwipeDirection.None) && Input.GetMouseButtonUp(0))
		{
			contFail++;
			print (contFail);

			if(contFail>2){
				contFail=0;
				animatorSwipeIcon.Play("animFail");
			}
		}
		if(SwipeManager.Instance.IsSwiping(SwipeDirection.Left))
		{
			contFail=0;
			animatorSwipeIcon.Play("noAnim");

			contSwipe++;
			if(contSwipe>4){
				contSwipe=4;
			}
			print (contSwipe);
			ejecutarAnimacion();
		}
		if(SwipeManager.Instance.IsSwiping(SwipeDirection.Right))
		{
			contFail=0;
			animatorSwipeIcon.Play("noAnim");

			contSwipe--;
			if(contSwipe<0){
				contSwipe=0;
			}
			print (contSwipe);
			ejecutarAnimacion();
		}
	}

	public void ejecutarAnimacion ()
	{
		animatorEscena.SetInteger("cont",contSwipe);
		animatorSwipePoints.SetInteger("cont",contSwipe);

	}
}
