using UnityEngine;
using System.Collections;

public class CooperLeftMovement : MonoBehaviour {

	public Rigidbody myBody; 
	public static float leftSpeed = 1.0f; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		myBody.velocity = new Vector3 (-15.0f * leftSpeed, 0, 0);  
	}
	
	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Finish") {
			Destroy (this.gameObject); 
		}
	}
}