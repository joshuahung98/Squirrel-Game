﻿using UnityEngine;
using System.Collections;

public class LosingScreenLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			AcornCollect.acornsCollected = 0;
			Application.LoadLevel (1);
			crushed.cru = false;
		}
	}
}
