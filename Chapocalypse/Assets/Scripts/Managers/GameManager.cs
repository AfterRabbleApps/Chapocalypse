using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {


	public GameObject GameCanvas;
	public GameObject MainMenuCanvas;
	public GameObject PauseCanvas;
	public GameObject GameOverCanvas;
	public GameObject MuteOff;
	public GameObject MuteOff1;
	public GameObject MuteOff2;
	public GameObject MuteOn;
	public GameObject MuteOn1;
	public GameObject MuteOn2;
	public static int isPaused;


	void Start () 
	{
		MainMenuCanvas.SetActive(true);
		GameCanvas.SetActive (false);
		PauseCanvas.SetActive (false);
		GameOverCanvas.SetActive (false);
		Time.timeScale = 0;
		MuteOn.SetActive (false);
		MuteOn1.SetActive (false);
		MuteOn2.SetActive (false);
		isPaused = 0;
	}
	

	void Update () 
	{
		GameOverCanvas.SetActive (false);
		if (Time.timeScale == 1) 
		{
			isPaused = 1;
		}

		if (Time.timeScale == 0) 
		{
			isPaused = 0;
		}
		if (healthManager.currentHealth <= 0) 
		{
			GameOverCanvas.SetActive (true);
			GameCanvas.SetActive (false);
			Time.timeScale = 0;
			Destroy (GameObject.FindGameObjectWithTag("Enemy"));

		}
	}

	public void PlayButton()
	{
		PauseCanvas.SetActive (false);
		MainMenuCanvas.SetActive (false);
		GameCanvas.SetActive (true);
		Time.timeScale = 1;
	}

	public void PauseButton()
	{
		//DealthCanvas.SetActive (false);
		GameCanvas.SetActive (false);
		PauseCanvas.SetActive (true);
		Time.timeScale = 0;
	
	}
	public void Restart ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void MuteON()
	{
		AudioListener.volume = 0;
		MuteOff.SetActive (false);
		MuteOn.SetActive (true);
		MuteOff1.SetActive (false);
		MuteOn1.SetActive (true);
	}

	public void MuteOFF()
	{
		AudioListener.volume = 1;
		MuteOff.SetActive (true);
		MuteOn.SetActive (false);
		MuteOff1.SetActive (true);
		MuteOn1.SetActive (false);
	}

	public void ScoreZero()
	{
		if(scoreManager.currentScore <=0)
		{

		}
			
	}

}

