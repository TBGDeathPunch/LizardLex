using UnityEngine;
using System.Collections;

public class EndStep : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			// sends message to Player
			other.gameObject.SendMessage("endgame");
		}
	}
}
