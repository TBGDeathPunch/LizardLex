using UnityEngine;
using System.Collections;

public class PlayerKnockout : MonoBehaviour {
	public GameObject other;
	public bool playerBehindGuard = false;

	void canknockout ()
	{
			playerBehindGuard = true;
	}

	// Update is called once per frame
	void Update () {

		if (playerBehindGuard == true) {
					if (Input.GetKeyDown (KeyCode.Space)) {
								Destroy (other);
				playerBehindGuard = false;
					}
			}
	}
}
