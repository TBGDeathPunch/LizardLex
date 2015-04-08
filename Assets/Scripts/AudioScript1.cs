using UnityEngine;
using System.Collections;

public class AudioScript1 : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip audioClip;

	// Use this for initialization
	void Start () {
		audioSource = this.gameObject.AddComponent<AudioSource>();
		audioSource.PlayOneShot(audioClip);
	}

}
