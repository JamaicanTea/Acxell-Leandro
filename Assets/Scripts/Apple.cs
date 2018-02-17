using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {
	public static float bottomY = -20f; //where the apple prefab will be destroyed

	void Update () 
	{
		if (transform.position.y < bottomY) 
		{
			Destroy (this.gameObject);
		}
		//getting refernce from ApplePicker component of Main Camera
		ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
		//call public AppleDestroyed() method of apScript
		apScript.AppleDestroyed();
	}
}
