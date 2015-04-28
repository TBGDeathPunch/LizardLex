using UnityEngine;
using System.Collections;

public class GameEnd : MonoBehaviour {
	public bool canendgame = false;

	// waiting for Player to recieve message from Level End Block
	public void endgame ()
	{
		canendgame = true;
	}

	// Update is called once per frame
	void Update () {
		if (canendgame == true) {
			Application.LoadLevel("Menu Scene");
		}
	}
}
