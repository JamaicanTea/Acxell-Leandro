using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour {
	public GUIText scoreGT;
	
	// Update is called once per frame
	void Start ()
	{
		//finding reference for GameObject ScoreCounter
		GameObject scoreGO = GameObject.Find ("ScoreCounter");
		//getting the GUIText component for mentioned GameObject
		scoreGT = scoreGO.GetComponent<GUIText>();
		//Set starting number to 0
		scoreGT.text ="0";
	}

	void Update () 
	{
		//get current screen position of mouse from Input
		Vector3 mousePos2D = Input.mousePosition;
		//makes the z position of the camera as a boundary to push mouse into 3d
		mousePos2D.z = -Camera.main.transform.position.z;
		//convert 2D screen space into 3D space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
		//moves basket's x position to mouse's x position
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}

	void OnCollisionEnter (Collision coll) 
	{
		//lets the basket detects what hit it
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.tag == "Apple") 
		{
			Destroy (collidedWith);
		}
		//parsing text from scoreGT into an integer
		int score = int.Parse (scoreGT.text);
		//adds 100 points per apple catched
		score += 100;
		//convert score back into string so it can be displayed
		scoreGT.text = score.ToString ();
		//tracks high score
		if (score > HighScore.score)
		{
			HighScore.score = score;
		}
	}
}
