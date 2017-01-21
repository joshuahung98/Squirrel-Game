using UnityEngine;
using System.Collections;

public class CooperSpawnRight : MonoBehaviour {
	
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
		//time += Time.deltaTime;
		if (Car2){ 
			platform = Random.Range (1, 5);             //radom number generator b/w 1 and 7
			float randomY = Random.Range(145.5f, 215.5f);      // appear b/w -5 and 5 in y-axis
			float rightScreenBound = -304f; 
			Instantiate(Car2, new Vector3((float)rightScreenBound , 149 , -153f), Quaternion.identity);
			//		time = 0; 
		}
		
		
	}
}