using UnityEngine;
using System.Collections;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {


	public GameObject GameCanvas;
	public GameObject MainMenuCanvas;
	public GameObject PauseCanvas;
	public GameObject GameOverCanvas;
	public GameObject NightCanvas;
	public GameObject MuteOff1;
	public GameObject MuteOff2;
	public GameObject MuteOff3;
	public GameObject MuteOn1;
	public GameObject MuteOn2;
	public GameObject MuteOn3;
	public static int GameHealth;
	public static int Highscore;
	public static int HealthScore;
	public static int isPaused;
	public static int GameScore;
	public bool isMute;
	public  bool isNight;
	public int i = 1;
	public static  int levels = 1;



	void Start () 
	{
		MainMenuCanvas.SetActive(true);
		GameCanvas.SetActive (false);
		PauseCanvas.SetActive (false);
		GameOverCanvas.SetActive (false);
		NightCanvas.SetActive (false);
		MuteOn1.SetActive (false);
		MuteOn2.SetActive (false);
		MuteOn2.SetActive (false);
		isPaused = 0;
		Time.timeScale = 0;
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
		if (GameHealth <= 0) 
		{
			GameOverScript ();
		}



		GameHealth = healthManager.currentHealth;
		GameScore = scoreManager.currentScore;
		HealthScore = healthManager.currentHealth;

		if (levels % 2 == 0)
		{
			NightCanvas.SetActive (true);
		}
			if (levels % 2 == 1)
		{
			NightCanvas.SetActive (false);
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
		if (isNight == true)
		{
			PauseCanvas.SetActive (true);
		}
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
		MuteOff1.SetActive(false);
		MuteOff2.SetActive(false);
		MuteOff3.SetActive(false);
		MuteOn1.SetActive (true);
		MuteOn2.SetActive (true);
		MuteOn3.SetActive (true);
		isMute = false;
	}

	public void MuteOFF()
	{
		AudioListener.volume = 1;
		MuteOff1.SetActive (true);
		MuteOff2.SetActive (true);
		MuteOff3.SetActive (true);
		MuteOn1.SetActive (false);
		MuteOn2.SetActive (false);
		MuteOn3.SetActive (false);
		isMute = true;
	}

	public void QuitButton()
	{
		Application.Quit ();
	}

	public void leaderboard()
	{
		Social.ShowLeaderboardUI ();
	}

	public void GameOverScript (){
		
			GameOverCanvas.SetActive (true);
			GameCanvas.SetActive (false);
			Time.timeScale = 0;
			Destroy (GameObject.FindGameObjectWithTag("Enemy"));
			StoreHighscore (scoreManager.currentScore);
		
	}
	void StoreHighscore(int newHighscore)
	{
		
		int oldHighscore = PlayerPrefs.GetInt ("highscore", 0);
		if (newHighscore > oldHighscore ){
			Highscore = newHighscore;
			PlayerPrefs.SetInt ("highscore", newHighscore);
		}
	}
}



