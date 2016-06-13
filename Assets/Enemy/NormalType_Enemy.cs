using UnityEngine;
using System.Collections;

public class NormalType_Enemy : MonoBehaviour {

	public Collider NormalEnemy;
	public float life = 1;
	private float damage = 1;
	public float Getlife(){
		return life;
	}

	public float Getdamage(){
		return damage;
	}

	void start(){
		
	}

	void OnTriggerEnter(Collider coll){
		if (coll.gameObject.CompareTag ("Player")) {
			coll.gameObject.transform.GetComponentInParent<PlayerStatus> ().life -= damage;
			//SendMessage("Ondamage", damage);
		} else if (coll.gameObject.CompareTag ("foot")) {
			//coll.gameObject.transform.GetComponent<NormalType_Enemy> ().life -= coll.gameObject.transform.GetComponent<Attack_foot>().damage;
			//life -= coll.GetComponent<Attack_foot>().Getdamage();
			if (life <= 0) {
				Debug.Log ("mon life is 0");
				Destroy(this.gameObject);
			}
			//Debug.Log("hit player");
		}
	}

	void Hit(Collider coll)
	{

	}

	public void Ondamage(float _damage)
	{
		life -= _damage;
	}

}
