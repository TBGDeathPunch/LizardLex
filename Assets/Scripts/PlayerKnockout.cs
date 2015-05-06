using UnityEngine;
using System.Collections;

public class PlayerKnockout : MonoBehaviour {
	public GameObject GuardCan;
	public bool playerBehindGuard = false;

	// finds a single Guard GameObject and sets GuardCan to it 
	void FindGuard () {
		GuardCan = GameObject.Find ("Guard4");
		}
	// sets playerBehindGuard to true after recieving message
	void canknockout ()
	{
			playerBehindGuard = true;
	}

	// Update is called once per frame
	void Update () {
		// if playerBehindGuard is true the player can press the Space key to destroy the GuardCan
		if (playerBehindGuard == true) {
					if (Input.GetKeyDown (KeyCode.Space)) {
					Destroy (GuardCan);
				playerBehindGuard = false;
					}
			}
	}
}
