using UnityEngine;
using System.Collections;

public class CanKnockout4 : MonoBehaviour {
	public GameObject Guard44;
	
	// sends message to Player when the Player enters the collider of the playerBehindGuard
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("FindGuard");
			other.gameObject.SendMessage("canknockout4");
		}
	}
}
