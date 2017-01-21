using UnityEngine;
using System.Collections;

public class AcornSpawn : MonoBehaviour {
	public GameObject Acorn1;
	
	public int platform;
	public int acorns = 0;	
	// Use this for initialization
	void Start()
		
	{
		InvokeRepeating("CreateObstacle", 1f, 1.5f);    //generate
	}
	
	void CreateObstacle()
	{
		if (acorns < 5) { 
			Debug.Log("Running"); 
			acorns++;
			platform = Random.Range (1, 5);             //radom number generator b/w 1 and 7
			float randomY = Random.Range(143f, 218f);      // appear b/w -5 and 5 in y-axis
			float randomX = Random.Range(-290f,-214f);                // spawn this much right of the screen
			int randomSpawn = Random.Range (0,12); 
			if(randomSpawn == 0)
			{
				Instantiate(Acorn1, new Vector3(randomX, 142 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 1)
			{
				Instantiate(Acorn1, new Vector3(randomX, 149 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 2)
			{
				Instantiate(Acorn1, new Vector3(randomX, 156 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 3)
			{
				Instantiate(Acorn1, new Vector3(randomX, 163 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 4)
			{
				Instantiate(Acorn1, new Vector3(randomX, 170 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 5)
			{
				Instantiate(Acorn1, new Vector3(randomX, 177 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 6)
			{
				Instantiate(Acorn1, new Vector3(randomX, 184 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 7)
			{
				Instantiate(Acorn1, new Vector3(randomX, 191 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 8)
			{
				Instantiate(Acorn1, new Vector3(randomX, 198 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 9)
			{
				Instantiate(Acorn1, new Vector3(randomX, 205 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 10)
			{
				Instantiate(Acorn1, new Vector3(randomX, 212 , -153f), Quaternion.identity);
			}
			else if(randomSpawn == 11)
			{
				Instantiate(Acorn1, new Vector3(randomX, 219 , -153f), Quaternion.identity);
			}
			//Instantiate(Acorn1, new Vector3(randomX, randomY, -152f), Quaternion.identity);
		}
	}
}

