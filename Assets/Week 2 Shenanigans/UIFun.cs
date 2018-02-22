using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIFun : MonoBehaviour {
	public Text countdownTimer;
	public Text playerInput;
	public float timer= 20f;

	// Use this for initialization
	void Start () 
	{
		countdownTimer.text = timer.ToString();
		countdownTimer.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer <= 20f) 
		{
			countdownTimer.text = timer.ToString("##.##");
			countdownTimer.color = Color.green;
		}
		if (timer <= 15f) 
		{
			countdownTimer.text = timer.ToString("##.##");
			countdownTimer.color = Color.red;
		}
		if (timer <= 10f) 
		{
			countdownTimer.text = timer.ToString("##.##");
			countdownTimer.color = Color.blue;
		}
		if (timer < 0f) 
		{
			countdownTimer.text = timer.ToString("##.##");
			countdownTimer.color = Color.red;
		}
	}
}
