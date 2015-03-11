using UnityEngine;
using System.Collections;

public class eventlistener : MonoBehaviour {
	void OnEnable() 
	{
		InclassScript.onActivation += onActivation;
	}

	void OnDisable () 
	{
		InclassScript.onActivation -= onActivation;
	}

	void onActivation(bool activated)
	{
		Debug.Log(activated);
	}
}
