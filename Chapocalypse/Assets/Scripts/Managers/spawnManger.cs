using UnityEngine;
using System.Collections;

public class spawnManger : MonoBehaviour {

	public GameObject[] enmey;
	public float spawnTime = 1.0F;
	public Transform[] spawnPoints;
	//public GameObject Dogs;
 	


	void Start () {
		InvokeRepeating ("Spawn", 1, 1.0F);
		Debug.Log (spawnTime);
	}

	void update()
	{
		if (((scoreManager.currentScore % 10) == 0 ) && (scoreManager.currentScore > 9) ) 
		{
			CancelInvoke ("Spawn");

			spawnTime -= .1F;
			Debug.Log (spawnTime);

			//InvokeRepeating ("Spawn", 1, spawnTime);
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
			Instantiate (enmey [enmeyIndex], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);
		}
	}
}

