using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScrpit : MonoBehaviour {


	/*int score = 0;
	// Use this for initialization
	void Start () 
	{
		score = PlayerPrefs.GetInt("Score");
	}
	
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 10, 80, 30), "GAMEOVER");

		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score:" + score);

		if(GUI.Button(new Rect(Screen.width/2-30,350,60,30),"Retry"))
			{
				//Application.LoadLevel(0);
			SceneManager.LoadScene(0);
			}
	}*/

	public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public void Quit()
	{
		Application.Quit ();
	}

}



/*GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "GAMEOVER");

GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score:" + score);

if(GUI.Button(new Rect(Screen.width/2-30,350,60,30),"Retry"))*/