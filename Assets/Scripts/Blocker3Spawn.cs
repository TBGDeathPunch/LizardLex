using UnityEngine;
using System.Collections;

public class Blocker3Spawn : MonoBehaviour {
	public GameObject Blocker3;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			Blocker3.SendMessage("blocker3place");
		}
	}
}
