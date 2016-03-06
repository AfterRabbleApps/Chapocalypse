using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public GameObject bulletPrefab;
	GameObject HealthManager;
	public static float FireRate  = 40f;  // The number of bullets fired per second
	public static float lastfired = 0f;      // The value of Time.time at the last firing moment

	private Animator anim;

	void Awake ()
	{
		anim = GetComponent<Animator> ();
	}

	void Update ()
	{

		if (GameManager.isPaused == 1) 
		{
			Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mouseWorldPos.z = 0f;
			transform.LookAt (mouseWorldPos);

			if (Input.GetButtonDown ("Fire1")) {
				//if (Time.time - lastfired > 1 / FireRate) {
				//	lastfired = Time.time;
				//	GameObject bullet = GameObject.Instantiate (bulletPrefab);
					bullet.transform.position = transform.position;
					bullet.transform.forward = transform.forward;
			
				//}
			}
		}
	}

	void OnTriggerEnter2D (Collider2D aCollider)
	{
		if (aCollider.gameObject.layer == LayerMask.NameToLayer ("Enemy")) {
			Destroy (aCollider.gameObject);
			//Destroy(gameObject);
		}

		if (aCollider.gameObject.tag == "Enemy") {
			anim.SetTrigger ("playerHit");
			healthManager.currentHealth = healthManager.currentHealth - dogAttack.dogValue;

		}

	}
}
