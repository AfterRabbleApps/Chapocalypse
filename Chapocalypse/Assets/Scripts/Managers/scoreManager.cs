using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scoreManager : MonoBehaviour {

	public static int currentScore = 0;
	public int testScore = 0;

	void Update()
	{
		testScore = currentScore;
		//yGuiText = currentScore();
	}
}
