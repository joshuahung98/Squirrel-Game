using UnityEngine;
using System.Collections;

public class RightTruckMovement : MonoBehaviour {
	public Rigidbody myBody; 
	public static float rightSpeed = 1.0f; 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		myBody.velocity = new Vector3 (10.0f * rightSpeed, 0, 0);  
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Boundary") {
			Destroy (this.gameObject); 
		}
	}
}