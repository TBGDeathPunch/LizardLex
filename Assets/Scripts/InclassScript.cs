using UnityEngine;
using System.Collections;

public class InclassScript : MonoBehaviour {

	public delegate void poweruphandle(bool activated);


	public static event poweruphandle onActivation;

	void OnGUI () 
	{
		if (GUI.Button(new Rect(5,5,150, 40), "Activate"))
		{
			if (onActivation != null)
			{
				onActivation(true);
			}
		}
		if (GUI.Button(new Rect(5,50,150, 40), "Deactivate"))
		{
			if (onActivation != null)
			{
				onActivation(false);
			}
		}
	}
}
