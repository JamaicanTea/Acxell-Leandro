using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaypointHolder : MonoBehaviour {

	public static float score;
	public static float timer = 5f;
	public Text scoreCounter;
	public Text countdownTimer;

	// Use this for initialization
	public void UpdateScore ()
	{
		score += 100;
		scoreCounter.text = score.ToString ();
	}

	public void UpdateTime ()
	{
		timer += 20;
		countdownTimer.text = timer.ToString ();
	}


	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		countdownTimer.text = timer.ToString ("##.##");
	}
		
}
