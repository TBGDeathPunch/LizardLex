using UnityEngine;
using System.Collections;

public class Blocker2Placer : MonoBehaviour {
	public bool canmoveblocker2 = false;

	public void blocker2place ()
	{
		canmoveblocker2 = true;
	}
	
	// moves Main Camera to new position over Level 2
	void Update () {
		if (canmoveblocker2 == true) {
			Vector3 newPosition = transform.position;
			newPosition.x = 225;
			newPosition.y = 825;
			newPosition.z = 0;
			transform.position = newPosition;
		}
	}
}
