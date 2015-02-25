using UnityEngine;
using System.Collections;

public class DoubleAbilityOrbScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// sends message to PlayerMove script and destroys orb when Player enters collider
	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.SendMessage("candouble");
		Destroy(this.gameObject);
	}
}
