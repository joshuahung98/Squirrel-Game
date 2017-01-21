using UnityEngine;
using System.Collections;

public class GoldenAcornSound : MonoBehaviour {

	public static bool collectedGold = false; 
	float time = 0; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (collectedGold == true) {
			time += Time.deltaTime;
			if (time >2)
				Application.LoadLevel (1);
		}
	}
}