using UnityEngine;
using System.Collections;

public class AcornCollect : MonoBehaviour {
	public static int acornsCollected = 0;
	// Use this for initialization
	void Start () {
		GuiController.LeftText ("Acorn: " + acornsCollected);
	}
	
	// Update is called once per frame
	void Update () {
	}


	void OnTriggerEnter (Collider col) {
		Debug.Log (col.gameObject);
		if (col.gameObject.tag == "Player") {
			acornsCollected++;
			print (acornsCollected);
			GuiController.LeftText ("Acorn: " + acornsCollected);
			AcornCollectSound.isCollected = true; 
			Destroy (this.gameObject);
		}
	}
}
