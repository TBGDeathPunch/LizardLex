﻿using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.SendMessage("die");
		}
	}
}
