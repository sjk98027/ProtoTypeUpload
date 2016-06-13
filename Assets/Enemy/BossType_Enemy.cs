using UnityEngine;
using System.Collections;

public class BossType_Enemy : MonoBehaviour {
	public Collider BossEnemy;
	private float life = 3;
	private float damage;
	void OnTriggerEnter(Collider coll){	

		if (coll.gameObject.CompareTag ("Player")) {

		}

		if (coll.gameObject.CompareTag ("foot")) {
			//coll.gameObject.SendMessage ("Ondamage", damage);
		}
//		GameObject.Destroy (PlayerBody);
	}
	void Hit(Collider coll)
	{

	}

	void Ondamage(Collider coll)
	{

	}

}
