using UnityEngine;
using System.Collections;

public class Guard2Turn : MonoBehaviour {
	public GameObject L3Guard22;
	public GameObject L3Guard2;
	
	void Start () 
	{
		L3Guard2.SendMessage("guard2moveaway");
	}
	
	public void guard2moveaway()
	{
		StartCoroutine("moveaway2");
	}
	
	public void guard2movein2()
	{
		StartCoroutine("movein2");
	}
	
	void moveaway2 () {
		Vector3 newPosition = transform.position;
		newPosition.x = -752;
		newPosition.y = 63;
		newPosition.z = 1;
		transform.position = newPosition;
		L3Guard22.SendMessage("movein22");
	}
	
	IEnumerator movein2 () {
		Vector3 newPosition = transform.position;
		newPosition.x = -235;
		newPosition.y = 980;
		newPosition.z = 1;
		transform.position = newPosition;
		yield return new WaitForSeconds(2f);
		Vector3 newPosition2 = transform.position;
		newPosition2.x = -752;
		newPosition2.y = 63;
		newPosition2.z = 1;
		transform.position = newPosition2;
		L3Guard22.SendMessage("movein22");
	}
}
