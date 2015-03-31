using UnityEngine;
using System.Collections;

public class Blocker2Spawn : MonoBehaviour {
	public GameObject Blocker2;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Blocker2.SendMessage("blocker2place");
		}
	}
}
