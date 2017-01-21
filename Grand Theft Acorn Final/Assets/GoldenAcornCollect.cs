using UnityEngine;
using System.Collections;

public class GoldenAcornCollect : MonoBehaviour {
	public AudioSource source; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Player") {
			Destroy (this.gameObject);
			GoldenAcornSound.collectedGold = true; 
			RightTruckMovement.rightSpeed += 0.5f;
			LeftTruckMovement.leftSpeed += 0.5f; 
			CooperLeftMovement.leftSpeed += 0.5f;
			CooperRightMovement.rightSpeed += 0.5f; 
			RightTruckMovement.rightSpeed += 0.5f;
			RaceCarMovement.leftSpeed += 0.5f;
			Application.LoadLevel(3);
		}
	}
}
