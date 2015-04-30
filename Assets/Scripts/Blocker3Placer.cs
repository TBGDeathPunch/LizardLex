using UnityEngine;
using System.Collections;

public class Blocker3Placer : MonoBehaviour {
	public bool canmoveblocker3 = false;
	
	public void blocker3place ()
	{
		canmoveblocker3 = true;
	}
	
	// moves Main Camera to new position over Level 2
	void Update () {
		if (canmoveblocker3 == true) {
			Vector3 newPosition = transform.position;
			newPosition.x = 365;
			newPosition.y = 1050;
			newPosition.z = 0;
			transform.position = newPosition;
		}
	}
}
