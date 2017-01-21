using UnityEngine;
using System.Collections;

public class RaceCarSpawn : MonoBehaviour {
	public GameObject Car3;
	//float time = 0f; 
	public int platform;
	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, (1.5f+RightTruckMovement.rightSpeed)/(RightTruckMovement.rightSpeed - 0.5f));    //generate
	}
	
	void CreateObstacle()
	{
		if (Car3){ 
			platform = Random.Range (1, 5);             //radom number generator b/w 1 and 7
			float leftScreenBound = -198f; 
			Instantiate(Car3, new Vector3((float)leftScreenBound , 219 , -153f), Quaternion.identity);
			
			//		time = 0; 
		}
		
		
	}
}
