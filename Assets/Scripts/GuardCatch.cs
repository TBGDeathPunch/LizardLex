using UnityEngine;
using System.Collections;

public class GuardCatch : MonoBehaviour {

	// sends message to Player when Player enters Guard vision collider
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("die");
		}
	}
}
