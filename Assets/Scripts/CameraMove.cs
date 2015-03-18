using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public bool canmovecamera1 = false;
	public bool canmovecamera2 = false;

	// when Main Camera recieves message from Level Exit sets up move of Main Camera position
	public void camera1change ()
	{
		canmovecamera1 = true;
	}

	public void camera2change ()
	{
		canmovecamera2 = true;
	}

	// moves Main Camera to new position over Level 2
	void Update () {
		if (canmovecamera1 == true) {
			Vector3 newPosition = transform.position;
			newPosition.x = 1;
			newPosition.y = 520;
			newPosition.z = -10;
			transform.position = newPosition;
		}

		if (canmovecamera2 == true) {
			Vector3 newPosition = transform.position;
			newPosition.x = 1;
			newPosition.y = 1120;
			newPosition.z = -10;
			transform.position = newPosition;
		}
	}
}
