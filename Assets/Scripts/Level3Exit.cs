using UnityEngine;
using System.Collections;

public class Level3Exit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			// sends message to Main Camera
			Camera.main.SendMessage("camera3change");
		}
	}
}
