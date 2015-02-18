using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {
	private bool alive = true;
	
	public void die()
	{
		if (!alive) return;
		alive = false;
		GetComponent<PlayerMove>().enabled = false;
		StartCoroutine("ResetLevel");
	}
	
	IEnumerator ResetLevel() {
		yield return new WaitForSeconds(1f);
		
		Application.LoadLevel(Application.loadedLevelName);
		
		yield break;
	}
}

