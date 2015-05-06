using UnityEngine;
using System.Collections;

public class PlayerKnockout41 : MonoBehaviour {
	public GameObject GuardCan1;
	public bool playerBehindGuard1 = false;
	
	// finds a single Guard GameObject and sets GuardCan to it 
	void FindGuard () {
		GuardCan1 = GameObject.Find ("L4Guard1");
	}
	// sets playerBehindGuard to true after recieving message
	void canknockout1 ()
	{
		playerBehindGuard1 = true;
	}
	
	// Update is called once per frame
	void Update () {
		// if playerBehindGuard is true the player can press the Space key to destroy the GuardCan1
		if (playerBehindGuard1 == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Destroy (GuardCan1);
				playerBehindGuard1 = false;
			}
		}
	}
}
