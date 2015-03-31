using UnityEngine;
using System.Collections;

public class Blocker1Spawn : MonoBehaviour {
	public GameObject Blocker1;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Blocker1.SendMessage("blocker1place");
		}
	}
}
