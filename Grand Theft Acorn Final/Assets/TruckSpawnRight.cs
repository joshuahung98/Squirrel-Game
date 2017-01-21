using UnityEngine;
using System.Collections;

public class TruckSpawnRight : MonoBehaviour {
	
	public GameObject Car1;
	//float time = 0f; 
	public int platform;
	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, (1.5f+RightTruckMovement.rightSpeed) /(RightTruckMovement.rightSpeed - 0.5f));    //generate
	}
	
	void CreateObstacle()
	{
		//time += Time.deltaTime;
		if (Car1){ 
			platform = Random.Range (1, 5);             //radom number generator b/w 1 and 7
			float randomY = Random.Range(145.5f, 215.5f);      // appear b/w -5 and 5 in y-axis
			float rightScreenBound = -304f; 
			int randomSpawn = Random.Range (0,2); 
			if(randomSpawn == 0)
			{
				Instantiate(Car1, new Vector3((float)rightScreenBound , 170 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 1)
			{
				Instantiate(Car1, new Vector3((float)rightScreenBound , 205 , -153f), Quaternion.identity);
			}
		}


	}
}