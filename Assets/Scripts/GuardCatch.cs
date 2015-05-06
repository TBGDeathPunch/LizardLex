using UnityEngine;
using System.Collections;

public class GuardCatch : MonoBehaviour {
	public AudioClip catchsound;
	public AudioSource source3;

	// sends message to Player when Player enters Guard vision collider
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			source3.PlayOneShot(catchsound);
			other.gameObject.SendMessage("die");
		}
	}
}
