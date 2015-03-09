using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			// sends message to Main Camera
			Camera.main.SendMessage("camerachange");
		}
	}
}
