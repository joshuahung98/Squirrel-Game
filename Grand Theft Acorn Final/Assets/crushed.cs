using UnityEngine;
using System.Collections;

public class crushed : MonoBehaviour {
	public static bool cru = false;
	float time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (cru == true) {
			time += Time.deltaTime;
			LeftTruckMovement.leftSpeed = 1.0f;
			RightTruckMovement.rightSpeed = 1.0f; 
			CooperLeftMovement.leftSpeed = 1.0f;
			CooperRightMovement.rightSpeed = 1.0f; 
			RightTruckMovement.rightSpeed = 1.0f;
			RaceCarMovement.leftSpeed =1.0f;
			if (time >1)
			Application.LoadLevel (2);
				
		}
	}


}
