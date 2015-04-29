using UnityEngine;
using System.Collections;

public class Guard1Turn : MonoBehaviour {
	
	// Update is called once per frame
	IEnumerator Turn () {
		Vector3 Rotation2 = transform.rotation;
		Rotation2.x = 1;
		Rotation2.y = 520;
		Rotation2.z = -10;
		transform.rotation = Rotation2;
		yield return new WaitForSeconds(2f);
		Vector3 Rotation1 = transform.rotation;
		Rotation1.x = 1;
		Rotation1.y = 520;
		Rotation1.z = -10;
		transform.rotation = Rotation1;
	}
}
