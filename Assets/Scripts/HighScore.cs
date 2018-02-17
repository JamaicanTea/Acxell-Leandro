using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour {
	public static int score = 1000;

	void Awake()
	{
		//if there is ApplePickerHighScore, read it
		if (PlayerPrefs.HasKey ("ApplePickerHighScore"))
		{
			score = PlayerPrefs.GetInt ("ApplePickerHighScore");
		}
		PlayerPrefs.SetInt ("ApplePickerHighScore", score); //assign highscore to ApplePickerHighScore
	}

	// Update is called once per frame
	void Update () 
	{
		GUIText gt = this.GetComponent<GUIText> ();
		gt.text = "High Score: " + score;
	}


}

