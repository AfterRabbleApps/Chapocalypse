using UnityEngine;
using System.Collections;

public class spawnManger : MonoBehaviour {

	public GameObject[] enmey;
	public float spawnTime = 2.0f;
	public Transform[] spawnPoints;
	public bool resetStatic = false;

	//public GameObject Dogs;
 	
	void Start () {
		InvokeRepeating ("Spawn", 1.0f, 1.0f); // Dogs Get started Here
		// dogs need to be stopped within the scope of the call. 
	}
	void Update()
	{
		//			STUPID CODE// This does not work because for every frame that the score == 10
		//			it speeds the dogs up so they get super fast really quick. 
		//
		//			Debug.Log ("Yay your score is 10");
		//			CancelInvoke ("Spawn");
		//			spawnTime -= 0.1f;
		//
		//			InvokeRepeating ("Spawn", 0, spawnTime);

		if (((scoreManager.currentScore % 10) == 0 ) && (scoreManager.currentScore >1) && spawnTime > 0.1) 
		{
			// this is a switch statement
			switch (scoreManager.currentScore)  // it checks what ever you give it in this case its current score
			{
			case 10: 							// if currentScore is 10 
				if (spawnTime != 0.9f) { 		// and the dogs have not been made faster already
					CancelInvoke ("Spawn"); 	// stop making dogs
					spawnTime = 0.9f; 			// make dogs faster
					InvokeRepeating ("Spawn", 0, spawnTime); //make dogs
				}
				break;                         // break: just means done, "leave the switch statment, I found what I was looking for"
			case 20:  // repeat
				if (spawnTime != 0.8f) {
					spawnTime = 0.8f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 30:
				if (spawnTime != 0.7f) {
					spawnTime = 0.7f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 40:
				if (spawnTime != 0.7f) {
					spawnTime = 0.7f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 50:
				if (spawnTime != 0.6f) {
					spawnTime = 0.6f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 60:
				if (spawnTime != 0.5f) {
					spawnTime = 0.5f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 70:
				if (spawnTime != 0.4f) {
					spawnTime = 0.4f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 80:
				if (spawnTime != 0.3f) {
					spawnTime = 0.3f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;
			case 90:
				if (spawnTime != 0.2f) {
					spawnTime = 0.2f;
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, spawnTime);
				}
				break;

			default:                        //default means: If I cant find what I am looking for do this. 
				if (spawnTime == 0.2f) {
					spawnTime = 1.0f;   // this resets spawn time to 1
						CancelInvoke ("Spawn");
					InvokeRepeating ("Spawn", 0, 0.1f);
				}
				break;

			}

		}

	}

	void Spawn() {
		if (healthManager.currentHealth == 0)
		{
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		int enmeyIndex = Random.Range (0, enmey.Length);
		  
		if (GameManager.isPaused == 1)
		{
			Instantiate (enmey [enmeyIndex], spawnPoints [spawnPointIndex].position, spawnPoints[1].rotation );
		}
	}
}

