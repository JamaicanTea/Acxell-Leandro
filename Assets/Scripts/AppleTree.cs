using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
	public GameObject applePrefab; //for instantiating apple objects
	public float speed = 1f; //speed which the object AppleTree moves in m/s
	public float leftAndRightEdge = 10f;//distance where AppleTree turns around
	public float chanceToChangeDirections= 0.1f;//chance that the tree will change directions
	public float secondsBetweenAppleDrops= 1f;//Rate of when an apple will be dropped.

	// Use this for initialization
	void Start () 
	{
		//apples are dropped per second
		InvokeRepeating ("DropApple", 2f, secondsBetweenAppleDrops);
	}

	void DropApple ()
	{
		GameObject apple = Instantiate (applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//basic movement script
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
	
		//changing directions
		if (pos.x < -leftAndRightEdge) { //if by any chance the tree runs far from the accepted distance..
			speed = Mathf.Abs (speed); //move right
		} else if (pos.x < leftAndRightEdge) {
			speed = -Mathf.Abs (speed);//move left
		}

	}
	void FixedUpdate () 
	{
		if (Random.value < chanceToChangeDirections)//randomly change directions 
		{
			speed *= -1; //change direction
		}
	}
}

