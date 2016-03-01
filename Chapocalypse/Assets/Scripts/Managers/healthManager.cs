using UnityEngine;
using System.Collections;

public class healthManager : MonoBehaviour {

	public static int currentHealth = 6;
	public int testHealth = 0;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		testHealth = currentHealth;
		if (currentHealth <= 0)
		{
			Destroy (GameObject.FindGameObjectWithTag("Player"));
		}
	}
}
