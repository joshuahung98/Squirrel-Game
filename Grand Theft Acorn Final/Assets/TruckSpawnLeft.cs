using UnityEngine;
using System.Collections;

public class TruckSpawnLeft : MonoBehaviour {
	
	public GameObject Car1; 
	public int platform;
	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, (1.5f+RightTruckMovement.rightSpeed)/(RightTruckMovement.rightSpeed - 0.5f));    //generate
	}
	
	void CreateObstacle()
	{
		if (Car1){ 
			platform = Random.Range (1, 5);             //radom number generator b/w 1 and 7
			float leftScreenBound = -198f; 
			int randomSpawn = Random.Range (0,4); 
			if(randomSpawn == 0)
			{
				Instantiate(Car1, new Vector3((float)leftScreenBound, 142 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 1)
			{
				Instantiate(Car1, new Vector3((float)leftScreenBound, 156 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 2)
			{
				Instantiate(Car1, new Vector3((float)leftScreenBound, 177 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 3)
			{
				Instantiate(Car1, new Vector3((float)leftScreenBound, 198 , -153f), Quaternion.identity);
			}
		}

	}
}


