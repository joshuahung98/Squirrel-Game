using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	Vector3 pos; 
	Transform myTransform; 
	float time = 0f;
	public float moveSpeed = 2.0f; 
	public Animator anim;
	public AudioSource source; 
	float time2;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent <Transform> (); 
	}

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		time2 += Time.deltaTime;
		print (time2);
		if (time > 0.2) {
			if (myTransform.position.y < 226 && Input.GetKey (KeyCode.UpArrow)) {
				myTransform.localEulerAngles = new Vector3(0,0,0);
				myTransform.Translate (myTransform.up * 7f); 

				time = 0;
				anim.SetTrigger ("Move");
			}
			if (myTransform.position.y > 135 && Input.GetKey (KeyCode.DownArrow)) {
				myTransform.localEulerAngles = new Vector3(0,0,180);
				myTransform.Translate (myTransform.up * -7f);
				time = 0;

				anim.SetTrigger ("Move");
			}
			if (myTransform.position.x < -216.4 && Input.GetKey (KeyCode.LeftArrow)) { 
				myTransform.localEulerAngles = new Vector3(0,0,-90);
				myTransform.Translate (myTransform.right * -7f);
				time = 0;
				anim.SetTrigger ("Move");
			}
			if (myTransform.position.x > -286.3 && Input.GetKey (KeyCode.RightArrow)) {
				myTransform.localEulerAngles = new Vector3(0,0,90);
				myTransform.Translate (myTransform.right * 7f); 
				time = 0;
				anim.SetTrigger ("Move");
			}
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "left" || col.gameObject.tag == "right") {
			Destroy (this.gameObject); 
			crushed.cru = true;
			source.Play();

		}
	}

}
