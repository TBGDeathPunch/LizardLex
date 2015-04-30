using UnityEngine;
using System.Collections;

public class Guard12Turn : MonoBehaviour {
	public GameObject L3Guard1;
	
	public void movein12()
	{
		StartCoroutine("Turn2");
	}

	IEnumerator Turn2 () {
		Vector3 newPosition = transform.position;
		newPosition.x = 62;
		newPosition.y = 1125;
		newPosition.z = 1;
		transform.position = newPosition;
		yield return new WaitForSeconds(2f);
		Vector3 newPosition2 = transform.position;
		newPosition2.x = -847;
		newPosition2.y = 403;
		newPosition2.z = 1;
		transform.position = newPosition2;
		L3Guard1.SendMessage("guard1movein1");
	}
}
