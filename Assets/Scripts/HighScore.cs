using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
		Text gt = this.GetComponent<Text> ();
		gt.text = "High Score: " + score;
	}


}

