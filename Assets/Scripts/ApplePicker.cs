using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottomY = -14f;
	public float basketSpacingY = 2f;
	public List<GameObject> basketList;

	// Use this for initialization
	public void AppleDestroyed()
	{
		//Destroy all falling apples
		GameObject [] tAppleArray = GameObject.FindGameObjectsWithTag ("Apple");
		foreach (GameObject tGO in tAppleArray) {
			Destroy (tGO);
		}
		int basketIndex = basketList.Count - 1; //getting index of last basket in list
		GameObject tBasketGO = basketList[basketIndex]; //getting reference of basket GameObject
		basketList.RemoveAt (basketIndex); //removes basket from list and destroys it
		Destroy (tBasketGO);

		if (basketList.Count == 0) //if there is no basket left, the game restarts
		{
			Application.LoadLevel ("_Scene_0");
		}
	}
	void Start () 
	{
		basketList = new List<GameObject> ();
		for (int i = 0; i < numBaskets; i++) 
		{
			GameObject tBasketGO = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			tBasketGO.transform.position = pos;
			basketList.Add (tBasketGO);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
