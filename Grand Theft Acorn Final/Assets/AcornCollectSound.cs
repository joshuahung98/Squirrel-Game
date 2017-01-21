using UnityEngine;
using System.Collections;

public class AcornCollectSound : MonoBehaviour {
	public AudioSource acornSound; 
	public static bool isCollected = false; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (isCollected == true) {
			acornSound.Play (); 
			isCollected = false; 
		}
	}
}
