using UnityEngine;
using System.Collections;

public class Blocker1Placer : MonoBehaviour {
	public bool canmoveblocker1 = false;
	
	// when Main Camera recieves message from Level Exit sets up move of Main Camera position
	public void blocker1place ()
	{
		canmoveblocker1 = true;
	}
	
	// moves Main Camera to new position over Level 2
	void Update () {
		if (canmoveblocker1 == true) {
			Vector3 newPosition = transform.position;
			newPosition.x = -302;
			newPosition.y = 225;
			newPosition.z = 0;
			transform.position = newPosition;
		}
	}
}
