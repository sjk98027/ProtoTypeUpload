using UnityEngine; 
using System.Collections; 

using UnityEngine; 
using System.Collections; 

public class MovePlayer1: MonoBehaviour {




	Transform player;
	Vector3 movePosition;
	float x ;
	float x_max;

	float y ; // 
	float y_base;      // character y base;, 
	//float deltahigh=0;
	float gravity = 13.0f;     // gravity feel
	int direction = 0;       // 0:stop0, 1:jump, 2:down

	float Gety_base(){
		return player.transform.position.y;
	}

	// 설정값
	const float jump_speed = 0.2f;  // 
	const float jump_accell = 0.01f; // 



	public int oneTimeJumpCount = 1; // 1jump play count;
	public int maximumJumpCount = 1; // maximum jump play count;




	// Use this for initialization
	void Start () {
		player = GetComponent<Transform> ();
		y_base = Gety_base();
	}

	// Update is called once per frame
	void Update ()
	{
		Vector3 moveposition = gameObject.transform.position;
		moveposition.y = y;
		JumpProcess();
//		Vector3 moveDirection = new Vector3(Input.GetAxis("Horizontal", 0f, 0f));
//			transform.Translate(moveDirection * Time.deltaTime);
//

		gameObject.transform.position = moveposition;

		if (Input.GetKey (KeyCode.C)) {
			DoJump ();
//			if(Input.GetKey(KeyCode.LeftArrow)
//				{moveposition.x > }

		}

	}

	void OnTriggerEnter(Collider coll){
		y_base = Gety_base ();
		if (coll.gameObject.tag == "field") {
			gravity = 0;
			//jump_speed = 0;
		}
	}



	void DoMove()
	{
		
	}
	void DoJump() // 
	{


		direction = 1; 
		gravity = jump_speed; 


	} 

	void JumpProcess()
	{
		switch (direction)
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
				if (y > y_base) {
					gravity += jump_accell;
				} 

				else if (y <= y_base) {
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






