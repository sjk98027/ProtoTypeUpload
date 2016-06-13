using UnityEngine;
using System.Collections;

public class Attack_foot : MonoBehaviour {

	public Collider foot;
	private PlayerStatus status;
	public float damage = 1;

	public float Getdamage(){
		return damage;
	}
	void Start(){
		status = GetComponentInParent<PlayerStatus> ();
	}
//	void OnTriggerEnter(Collider coll){
////		Destroy (NormalEnemy);
////		status.Hit ();
////		Debug.Log (collider.gameObject.name);
//		if (coll.gameObject.CompareTag ("Normal_Enemy")) {
//			coll.GetComponent<NormalType_Enemy> ().Ondamage (damage);
//		}
//
//		if (GetComponent<Collider>().gameObject.CompareTag ("Boss_Enemy")) {
//			//coll.gameObject.SendMessage ("Ondamage", damage);
//		}
//	}

	void Hit(Collider coll)
	{
		
	}

	void Ondamage(Collider coll)
	{
		//status.SendMessage ("Ondamage", damage);
	}
}
