using UnityEngine;
using System.Collections;

public class CarHorn : MonoBehaviour {
	float time = 0; 
	public AudioSource source; 
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime; 
		if (time >= 5.0f) {
			print ("car horn is working"); 
			source.Play (); 
			time = 0; 
		}
	}
}
