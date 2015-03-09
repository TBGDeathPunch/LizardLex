using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public bool canmovecamera = false;

	// when Main Camera recieves message from Level Exit sets up move of Main Camera position
	public void camerachange ()
	{
		canmovecamera = true;
	}

	// moves Main Camera to new position over Level 2
	void Update () {
		if (canmovecamera == true) {
			Vector3 newPosition = transform.position;
			newPosition.x = 1;
			newPosition.y = 520;
			newPosition.z = -10;
			transform.position = newPosition;
		}
	}
}
