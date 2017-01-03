using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class control_introVideo : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audio;

	void Start () {

		GetComponent<RawImage>().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource>();
		audio.clip = movie.audioClip;
		movie.Play();
		audio.Play();

		//Handheld.PlayFullScreenMovie ("Compo_FINAL(Trailer+Show)_ParaUnity.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
	}

	void Update() {
		if(Input.GetKeyDown(KeyCode.Space)&& movie.isPlaying){
			movie.Pause();
		}
		else if (Input.GetKeyDown(KeyCode.Space)&& !movie.isPlaying){
			movie.Play();
		}
	}
}
