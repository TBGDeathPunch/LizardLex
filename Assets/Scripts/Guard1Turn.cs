using UnityEngine;
using System.Collections;

public class Guard1Turn : MonoBehaviour {
	public GameObject L3Guard12;
	public GameObject L3Guard1;

	void Start () 
	{
		L3Guard1.SendMessage("guard1moveaway");
	}

	public void guard1moveaway()
	{
		StartCoroutine("moveaway1");
	}

	public void guard1movein1()
	{
		StartCoroutine("movein1");
	}
	
	void moveaway1 () {
		Vector3 newPosition = transform.position;
		newPosition.x = -847;
		newPosition.y = 403;
		newPosition.z = 1;
		transform.position = newPosition;
		L3Guard12.SendMessage("movein12");
	}

	IEnumerator movein1 () {
		Vector3 newPosition = transform.position;
		newPosition.x = 62;
		newPosition.y = 980;
		newPosition.z = 1;
		transform.position = newPosition;
		yield return new WaitForSeconds(2f);
		Vector3 newPosition2 = transform.position;
		newPosition2.x = -847;
		newPosition2.y = 403;
		newPosition2.z = 1;
		transform.position = newPosition2;
		L3Guard12.SendMessage("movein12");
	}
}
