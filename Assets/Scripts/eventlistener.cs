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

	// resets the game when the player presses the button that is in the scene
	void onActivation(bool activated)
	{
		Application.LoadLevel(Application.loadedLevelName);
	}
}
