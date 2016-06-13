using UnityEngine;
using System.Collections;
[RequireComponent(typeof(CharacterController))]

public class MovePlayer: MonoBehaviour {


	[Range(0f, 150f)]public float moveSpeed;
	[Range(0f, 2000f)]public float jumpSpeed;
	CharacterController player;
	private float gravity = 5f;
	Vector3 moveDirection;
	private float accel = 5f;

	// Use this for initialization
	void Start () {
		player = GetComponent<CharacterController> ();
//		y = y_base;
	}

	// Update is called once per frame
	void Update ()
	{
		moveDirection = new Vector3 (0f, 0f, Input.GetAxis ("Horizontal"));
		moveDirection = transform.TransformDirection (moveDirection);
		moveDirection.x *= moveSpeed;

		//moveDirection.y *= jumpSpeed;


		//Input.GetAxis("Vertical")"y축 변수를 위해 내버려둠"
		if (player.isGrounded) {
			
			if (Input.GetKey (KeyCode.C)) {
				moveDirection.y = jumpSpeed;

				//Debug.Log (moveDirection.y);
			}
		}

			moveDirection.y -= gravity;


			player.Move (moveDirection * Time.deltaTime);

		}
}
