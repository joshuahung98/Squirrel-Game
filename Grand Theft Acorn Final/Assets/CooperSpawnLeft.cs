using UnityEngine;
using System.Collections;

public class CooperSpawnLeft : MonoBehaviour {

	public GameObject Car2;
	//float time = 0f; 
	public int platform;
	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, (1.5f+RightTruckMovement.rightSpeed)/(RightTruckMovement.rightSpeed - 1.0f));    //generate
	}
	
	void CreateObstacle()
	{
		if (Car2){ 
			platform = Random.Range (1, 5);             //radom number generator b/w 1 and 7
			float leftScreenBound = -198f; 
			Instantiate(Car2, new Vector3((float)leftScreenBound , 184 , -153f), Quaternion.identity);

			//		time = 0; 
		}
		
		
	}
}
