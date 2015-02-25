using UnityEngine;
using System.Collections;

public class CanKnockout : MonoBehaviour {
	public GameObject Guard;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("FindGuard");
			other.gameObject.SendMessage("canknockout");
		}
	}
}
