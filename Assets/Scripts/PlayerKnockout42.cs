using UnityEngine;
using System.Collections;

public class PlayerKnockout42 : MonoBehaviour {
	public GameObject GuardCan2;
	public bool playerBehindGuard2 = false;
	
	// finds a single Guard GameObject and sets GuardCan to it 
	void FindGuard () {
		GuardCan2 = GameObject.Find ("L4Guard2");
	}
	// sets playerBehindGuard to true after recieving message
	void canknockout2 ()
	{
		playerBehindGuard2 = true;
	}
	
	// Update is called once per frame
	void Update () {
		// if playerBehindGuard is true the player can press the Space key to destroy the GuardCan2
		if (playerBehindGuard2 == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Destroy (GuardCan2);
				playerBehindGuard2 = false;
			}
		}
	}
}
