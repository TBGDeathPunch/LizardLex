using UnityEngine;
using System.Collections;

public class CanKnockout : MonoBehaviour {
	public GameObject Guard;

	// sends message to Player when the Player enters the collider of the playerBehindGuard
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("FindGuard");
			other.gameObject.SendMessage("canknockout");
		}
	}
}
