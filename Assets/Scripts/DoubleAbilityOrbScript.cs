using UnityEngine;
using System.Collections;

public class DoubleAbilityOrbScript : MonoBehaviour {
	public GameObject OtherDoubleOrb;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// sends message to PlayerMove script and destroys all orbs on all levels when Player enters collider
	void OnTriggerEnter2D(Collider2D other) {
		other.gameObject.SendMessage("candouble");
		Destroy(this.gameObject);
		Destroy(OtherDoubleOrb);
	}
}
