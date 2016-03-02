using UnityEngine;
using System.Collections;

public class spawnManger : MonoBehaviour {

	public GameObject[] enmey;
	public float spawnTime = 100f;
	public Transform[] spawnPoints;
	//public GameObject Dogs;



	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
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

