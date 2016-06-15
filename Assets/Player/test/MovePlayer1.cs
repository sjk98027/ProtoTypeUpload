using UnityEngine; 
using System.Collections; 

using UnityEngine; 
using System.Collections; 

public class MovePlayer1: MonoBehaviour {




	Transform player;
	Vector3 movePosition;
	public float x = 0;
	public float x_speed = 30 ;

	public float x_base;

	public float y ; // 
	public float y_base;      // character y base;, 
	//float deltahigh=0;

	float friction = 13.0f;// machalpower;
	float gravity = 13.0f;     // gravity feel
	public int direction_y = 0;       // 0:stop0, 1:jump, 2:down
	public int direction_x = 0;
	public float Gety_base_y(){
		return player.transform.position.y;
	}
	public float Getx_base_x(){
		return player.transform.position.x;
	}
	// 설정값
	public float move_speed = 5f;	//
	const float move_accell = 0.01f;	//
	const float jump_speed = 0.2f;  // 
	const float jump_accell = 0.01f; // 



	public int oneTimeJumpCount = 1; // 1jump play count;
	public int maximumJumpCount = 1; // maximum jump play count;




	// Use this for initialization
	void Start () {
		player = GetComponent<Transform> ();
		y_base = Gety_base_y();
//		y = y_base;
		//x_base = Getx_base_x ();
	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 moveposition = gameObject.transform.position;
		moveposition.y = y;
		JumpProcess();
		gameObject.transform.position = moveposition;
		DoMove ();


			if (Input.GetKey (KeyCode.C)) {
				DoJump ();

		}




	}

	void OnTriggerEnter(Collider coll){
		y_base = Gety_base_y ();
	}

	public enum CharacterState
	{
		IDLE,
		AIR,
	}




	void DoMove()
	{
		Vector3 vecPos = gameObject.transform.position;
		if (Input.GetKey (KeyCode.LeftArrow)) {
			vecPos.x -= Time.deltaTime * move_speed;
			gameObject.transform.position = vecPos;
		}else if (Input.GetKey (KeyCode.RightArrow)) {
			vecPos.x += Time.deltaTime * move_speed;
			gameObject.transform.position = vecPos;
		}
	}


	void DoJump() // 
	{
		direction_y = 1; 
		gravity = jump_speed; 
	} 

	void JumpProcess()
	{
		switch (direction_y)
		{
		case 0: // 
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
						y =y_base;
					}
				}
				break;
			}
		case 1: // up
			{
				y += gravity;
				if (gravity <= 0.0f)
				{
					direction_y = 2;
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
				if (y > y_base) {
					gravity += jump_accell;
				} 
				else
				{
//					direction_y = 0;
//					y = y_base;
				}

				break;
			}
		}

	}

}






