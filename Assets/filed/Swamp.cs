using UnityEngine;
using System.Collections;

public class Swamp : MonoBehaviour {
	public CharacterController player;

	// Use this for initialization
	void Start () {
		player = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		//coll.GetComponent<MovePlayer>;
		//player.Move -= player;
	}


}
