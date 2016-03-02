using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreManager : MonoBehaviour {

	public static int currentScore;
	public int testScore = 0;

	Text text;

	void Awake()
	{

		text = GetComponent<Text> ();
		currentScore = 0;
	}



	void Update()
	{
		testScore = currentScore;
		text.text = "" + currentScore;
	}

}
