using UnityEngine;
using System.Collections;

public class Guard22Turn : MonoBehaviour {
	public GameObject L3Guard2;
	
	public void movein22()
	{
		StartCoroutine("Turn2");
	}
	
	IEnumerator Turn2 () {
		Vector3 newPosition = transform.position;
		newPosition.x = -235;
		newPosition.y = 1125;
		newPosition.z = 1;
		transform.position = newPosition;
		yield return new WaitForSeconds(2f);
		Vector3 newPosition2 = transform.position;
		newPosition2.x = -752;
		newPosition2.y = 63;
		newPosition2.z = 1;
		transform.position = newPosition2;
		L3Guard2.SendMessage("guard2movein2");
	}
}
