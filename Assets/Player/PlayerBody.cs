using UnityEngine;
using System.Collections;

public class PlayerBody : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		


	}

	void OncollisionEnter (Collider coll){
		if (coll.gameObject.CompareTag ("Normal_Enemy")) {
		
		}

		if(coll.gameObject.CompareTag ("Boss_Enemy")){
			
		}
	}
}
