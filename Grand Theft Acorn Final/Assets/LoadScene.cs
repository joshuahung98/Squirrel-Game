using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			AcornCollect.acornsCollected = 0;
			Application.LoadLevel (4);
			crushed.cru = false;
		}
	}
}
