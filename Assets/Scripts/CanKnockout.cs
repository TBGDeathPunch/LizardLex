using UnityEngine;
using System.Collections;

public class CanKnockout : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("canknockout");
		}
	}
}
