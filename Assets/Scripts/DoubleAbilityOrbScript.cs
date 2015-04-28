using UnityEngine;
using System.Collections;

public class DoubleAbilityOrbScript : MonoBehaviour {
	public GameObject OtherDoubleOrb;
	public AudioClip orbsound;
	public AudioSource source2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// sends message to PlayerMove script and destroys all orbs on all levels when Player enters collider
	IEnumerator OnTriggerEnter2D(Collider2D other) {
		other.gameObject.SendMessage("candouble");
		source2.PlayOneShot(orbsound);
		yield return new WaitForSeconds(0.5f);
		Destroy(this.gameObject);
		Destroy(OtherDoubleOrb);
	}
}
