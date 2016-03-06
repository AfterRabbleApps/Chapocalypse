using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelsManager : MonoBehaviour {

	public GameObject Levels;
	bool toggleGui;

	Text text;

	void Start () {
		text = GetComponent<Text> ();
	
	}

	void Update () {
		int gameLevels = GameManager.levels;
		text.text = "Level: " + gameLevels;
		}
}
