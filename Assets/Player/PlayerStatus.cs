using UnityEngine;
using System.Collections;

public class PlayerStatus : MonoBehaviour {
	public Collider PlayerBody;

	public float  life = 1;
	public float Getlife()
	{return life;
	}
	//private float life = 1;
	 
	[Range(0f, 200f)]public float LimitTime;
	public float PlayTime =0 ;
	public float OnPlayTime = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if (life == 0) {
//			Destroy (gameObject);
//		}
		PlayTime = Time.realtimeSinceStartup;
		if (PlayTime >= LimitTime) {
			

		}



	}

//	void OnTriggerEnter(Collider NormalEnemy){
//		//Debug.Break();
//		//		Destory
//	}



	public void Ondamage(){
		//life -= damage;
		return;
	}
}
