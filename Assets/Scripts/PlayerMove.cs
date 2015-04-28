using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	private Vector2 size;
	
	private bool moving_horizontally = false;
	private bool moving_vertically = false;
	
	public LayerMask layer_mask;

	public int id;

	public PlayerMovementType movementType;

	public bool moveDouble = false;

	public float movementTime;

	public AudioClip audio1;

	public AudioSource source1;
	
	private bool can_move = true;
	
	private Vector2 movement_start_position;

	void Start() {
		size = GetComponent<BoxCollider2D>().size;
	}

	/*void FixedUpdate ()
	{
		if (move == 0) {
						move = Input.GetAxis ("Horizontal");
						if (move != 0) {
								move = 15 * Mathf.Sign (move);
								rigidbody2D.velocity += new Vector2 (move, rigidbody2D.velocity.y);
						}
				} else 
						{
							rigidbody2D.velocity = new Vector2 (move, rigidbody2D.velocity.y);
						}
	}*/
	// two types of movement
	public enum PlayerMovementType {
		Single,
		Double,
	}

	// function that recieves message from orb and sets moveDouble to true
	void candouble ()
	{
		moveDouble = true;
	}

	// works out the method of simpe single movement of one space at a time
	private Vector2 getInput() {
		Vector2 movement = Vector2.zero;
		
		float horizontal_axis = Input.GetAxisRaw ("Horizontal");
		float vertical_axis   = Input.GetAxisRaw ("Vertical");
		
		if (horizontal_axis != 0 && moving_horizontally == false) {
			moving_horizontally = true;			
			movement.x = horizontal_axis * size.x * (movementType == PlayerMovementType.Single ? 1 : 2);
		}
		else if (horizontal_axis == 0) {
			moving_horizontally = false;
		}
		
		if (vertical_axis != 0 && moving_vertically == false) {
			moving_vertically = true;
			movement.y = vertical_axis   * size.y * (movementType == PlayerMovementType.Single ? 1 : 2);
		}
		else if (vertical_axis == 0) {
			moving_vertically = false;
		}
		
		return movement;
	}
	
	void Update () {
		if (!can_move) return;

		// allows Player to move in double when the Left Shift key is pressed down only when moveDouble is true
		if (moveDouble == true) {
		if (Input.GetKeyDown (KeyCode.LeftShift)) {
					movementType = PlayerMovementType.Double;
				}
		}
		// even after double movement is unlocked when Left Shift is not pressed the movement type will be single
		if (Input.GetKeyUp (KeyCode.LeftShift)) {
			movementType = PlayerMovementType.Single;
		}

		Vector2 movement = getInput();
		
		movement = BlockDetect(movement);
		
		if (movement.magnitude > 0) {
			//SetAnimationDirection(movement);
			StartCoroutine ("LerpMovement", movement);
		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			if (!audio.isPlaying)
			{
				source1.PlayOneShot(audio1);
			}
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			if (!audio.isPlaying)
			{
				source1.PlayOneShot(audio1);
			}
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			if (!audio.isPlaying)
			{
				source1.PlayOneShot(audio1);
			}
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			if (!audio.isPlaying)
			{
				source1.PlayOneShot(audio1);
			}
		}
	}
	// for later possible animations
	/*private void SetAnimationDirection(Vector2 movement) {
		int direction;
		if (movement.y == 0) {
			direction = (movement.x > 0) ? 1 : 3;
		}
		else {
			direction = (movement.y > 0) ? 2 : 0;
		}
		GetComponent<Animator>().SetInteger("direction", direction);
	}*/

	// to help set the amount of space that is moved per step depending on the movement type set
	private Vector2 BlockDetect(Vector2 movement) {
		RaycastHit2D hit;
		if (hit = Physics2D.Raycast(transform.position, movement, movement.magnitude, layer_mask)) {		
			switch(movementType) {
				
			case PlayerMovementType.Single:
				movement = Vector2.zero;
				break;
				
			case PlayerMovementType.Double:
				if (hit.distance > size.x || hit.distance > size.y) {
					movement = movement / 2;
				}
				else if (hit.distance < size.x || hit.distance < size.y) {
					movement = Vector2.zero;
				}
				break;
			}
		}
		
		return movement;
	}
	// to allow movement based on set time of movement if there is any
	private IEnumerator LerpMovement(Vector2 movement) {
		if (movement.magnitude == 0) yield break;
		
		movement_start_position = transform.position;
		startMoving();
		
		float elapsed_time = 0;
		
		while (elapsed_time < movementTime) {
			transform.position = Vector2.Lerp(movement_start_position, movement_start_position + movement, Mathf.Sqrt(elapsed_time / movementTime));
			elapsed_time += Time.deltaTime;
			yield return null;
		}
		
		transform.position = movement_start_position + movement;		
		stopMoving();
		
		yield break;
	}


	private void startMoving() {
		can_move = false;
		//GetComponent<Animator>().SetBool("walking", true);
	}
	
	private void stopMoving() {
		can_move = true;
		//GetComponent<Animator>().SetBool("walking", false);
	}

	// for ID if needed
	public int ID { get { return id; } }
}
