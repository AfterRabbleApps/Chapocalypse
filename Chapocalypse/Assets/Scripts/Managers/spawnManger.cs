using UnityEngine;
using System.Collections;

public class spawnManger : MonoBehaviour {

	public GameObject[] enmey;
	public float spawnTime = 3f;
	public Transform[] spawnPoints;

	void Start () {
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn() {
		if (healthManager.currentHealth <= 0)
		{
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		int enmeyIndex = Random.Range (0, enmey.Length);

		//Debug.Log ("Enmey" + enmeyIndex);
		Debug.Log ("Spawn" + spawnPointIndex);


			Instantiate (enmey[enmeyIndex], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
