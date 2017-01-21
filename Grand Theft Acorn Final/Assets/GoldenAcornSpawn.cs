using UnityEngine;
using System.Collections;

public class GoldenAcornSpawn : MonoBehaviour {

	public GameObject goldenAcorn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(AcornCollect.acornsCollected == 5) 
		{
			int randomSpawn = Random.Range(-284,-218); 
			Instantiate(goldenAcorn, new Vector3(randomSpawn, 226, -153f), Quaternion.identity);
			AcornCollect.acornsCollected = 0 ;
		
	   }
	}
}
