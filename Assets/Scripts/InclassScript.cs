using UnityEngine;
using System.Collections;

public class InclassScript : MonoBehaviour {

	public delegate void resetbutton(bool activated);


	public static event resetbutton onActivation;
	// builds the button in the scene
	void OnGUI () 
	{
		if (GUI.Button(new Rect(400,400,150, 40), "Reset Level"))
		{
			if (onActivation != null)
			{
				onActivation(true);
			}
		}
	}
}
