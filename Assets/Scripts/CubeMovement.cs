using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour {
	public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftArrow))
			transform.position +=  (Vector3.left*speed);
		if (Input.GetKeyDown (KeyCode.RightArrow))
			transform.position +=  (Vector3.right*speed);
		if (Input.GetKeyDown (KeyCode.UpArrow))
			transform.position +=  (Vector3.up*speed);
		if (Input.GetKeyDown (KeyCode.DownArrow))
			transform.position +=  (Vector3.down*speed);
	}
}
