using UnityEngine;
using System.Collections;

public class PlayerKnockout : MonoBehaviour {
	public GameObject GuardCan;
	public bool playerBehindGuard = false;

	void FindGuard () {
		GuardCan = GameObject.Find ("Guard4");
		}

	void canknockout ()
	{
			playerBehindGuard = true;
	}

	// Update is called once per frame
	void Update () {

		if (playerBehindGuard == true) {
					if (Input.GetKeyDown (KeyCode.Space)) {
								Destroy (GuardCan);
				playerBehindGuard = false;
					}
			}
	}
}
