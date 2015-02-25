using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	private bool alive = true;

	// when player recieves message from Guard sets up reset of level
	public void die()
	{
		if (!alive) return;
		alive = false;
		GetComponent<PlayerMove>().enabled = false;
		StartCoroutine("ResetLevel");
	}

	// resets level
	IEnumerator ResetLevel() {
		yield return new WaitForSeconds(1f);
		
		Application.LoadLevel(Application.loadedLevelName);
		
		yield break;
	}
}

