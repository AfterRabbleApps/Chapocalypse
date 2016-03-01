using UnityEngine;
using System.Collections;

public class dogAttack : MonoBehaviour
{
	public float speed = 2f;
	private Transform player;
	public int Points;


	void Start()
	{
		player = GameObject.FindWithTag ("Player").transform;
	}

	void Update ()
	{
		if(player != null)
		{
			transform.LookAt(player);
			transform.position += transform.forward * Time.deltaTime * speed;
		}
	}

}