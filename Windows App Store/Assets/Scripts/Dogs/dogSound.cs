using UnityEngine;
using System.Collections;


[RequireComponent(typeof(AudioSource))]
public class dogSound : MonoBehaviour {

    public AudioSource dogHit;




	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
       
	}
}
