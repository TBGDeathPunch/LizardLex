using UnityEngine;
using System.Collections;

public class PlayerKnockout44 : MonoBehaviour {
	public GameObject GuardCan4;
	public bool playerBehindGuard4 = false;
	
	// finds a single Guard GameObject and sets GuardCan to it 
	void FindGuard () {
		GuardCan4 = GameObject.Find ("L4Guard4");
	}
	// sets playerBehindGuard to true after recieving message
	void canknockout4 ()
	{
		playerBehindGuard4 = true;
	}
	
	// Update is called once per frame
	void Update () {
		// if playerBehindGuard is true the player can press the Space key to destroy the GuardCan4
		if (playerBehindGuard4 == true) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				Destroy (GuardCan4);
				playerBehindGuard4 = false;
			}
		}
	}
}
