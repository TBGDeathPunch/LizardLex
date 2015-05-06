using UnityEngine;
using System.Collections;

public class PlayerKnockout43 : MonoBehaviour {
	public GameObject GuardCan3;
	public bool playerBehindGuard3 = false;
	
	// finds a single Guard GameObject and sets GuardCan to it 
	void FindGuard () {
		GuardCan3 = GameObject.Find ("L4Guard3");
	}
	// sets playerBehindGuard to true after recieving message
	void canknockout3 ()
	{
		playerBehindGuard3 = true;
	}
	
	// Update is called once per frame
	void Update () {
		// if playerBehindGuard is true the player can press the Space key to destroy the GuardCan3
		if (playerBehindGuard3 == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Destroy (GuardCan3);
				playerBehindGuard3 = false;
			}
		}
	}
}
