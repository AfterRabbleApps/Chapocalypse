
using UnityEngine;
using System.Collections;

public class dogSpawner : MonoBehaviour
{
	public float m_MinimumSpawnDelay = 2f;
	public float m_MaximumSpawnDelay = 4f;
	public GameObject[] enemies;

	void Start ()
	{
		StartCoroutine("DoSpawn");
	}

	IEnumerator DoSpawn()
	{
		while(true)
		{
			yield return new WaitForSeconds(Random.Range(m_MinimumSpawnDelay, m_MaximumSpawnDelay));

			//Instantiate a random enemy.
			int enemyIndex = Random.Range(0, enemies.Length);
			GameObject newDog = Instantiate(enemies[enemyIndex]);
			newDog.transform.position = transform.position;
		}
	}
}