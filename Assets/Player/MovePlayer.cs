using UnityEngine; 
using System.Collections; 
[RequireComponent(typeof(CharacterController))]

public class MovePlayer: MonoBehaviour {


	[Range(0f, 150f)]public float moveSpeed;
	[Range(0f, 10000f)]public float jumpSpeed;
	CharacterController player;

	Vector3 movePosition;

	float y = 0.0f; // 씨발이거
	const float y_base = 0.5f;      // character y base;, 씨빨 이거
	float deltahigh=0;
	float gravity = 13.0f;     // gravity feel
	int direction = 0;       // 0:stop0, 1:jump, 2:down
//	int oneTimeCurrentJumpCount = 0; // 1jump play
//	int currentJumpCount = 0; // jump count
	// 설정값
	const float jump_speed = 0.2f;  // 
	const float jump_accell = 0.01f; // 

	public int oneTimeJumpCount = 1; // 1jump play count;
	public int maximumJumpCount = 1; // maximum jump play count;
	CharacterController Player;



	// Use this for initialization
	void Start () {
		player = GetComponent<CharacterController> ();
				y = y_base;
	}

	// Update is called once per frame
	void Update ()
	{
		
		JumpProcess();

		//movePosition = new Vector3 (0f, 0f, Input.GetAxis ("Horizontal"));
//		moveDirection = transform.TransformDirection (moveDirection);
//		moveDirection.x *= moveSpeed;
		movePosition = gameObject.transform.position;
		movePosition.y = y;
		gameObject.transform.position = movePosition;
		//moveDirection.y *= jumpSpeed;
		if (Input.GetKey (KeyCode.C)) {
			DoJump ();

		//Input.GetAxis("Vertical")"y축 변수를 위해 내버려둠"
//		if (player.isGrounded) {
//			}
		}

//		moveDirection.y -= gravity*Time.deltaTime;

		//player.Move (moveDirection * Time.deltaTime);

		//player.Move (moveDirection * Time.deltaTime);
		movePosition.y -=gravity;
	}

	void DoJump() // 점프키 누를때 1회만 호출
	{

		//		if(oneTimeCurrentJumpCount == oneTimeJumpCount) 
		//			return; 
		//
		//		if(currentJumpCount >= maximumJumpCount) 
		//			return; 
		//
		//
		//		oneTimeCurrentJumpCount++; 
		//		currentJumpCount++; 
		direction = 1; 
		gravity = jump_speed; 


	} 

	void JumpProcess()
	{
		switch (direction)
		{
		case 0: // 2단 점프시 처리
			{
				if (y > y_base)
				{
					if (y >= jump_accell)
					{
						y -= jump_accell;
						y -= gravity;
					}
					else
					{
						y = y_base;
					}
				}
				break;
			}
		case 1: // up
			{
				y += gravity;
				if (gravity <= 0.0f)
				{
					direction = 2;
				}
				else
				{
					gravity -= jump_accell;
				}
				break;
			}

		case 2: // down
			{
				y -= gravity;
				if (y > y_base)
				{
					gravity += jump_accell;
				}
				else
				{
					direction = 0;
					y = y_base;
				}
				break;
			}
		}

	}

}
