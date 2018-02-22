using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {
	public WaypointHolder waypointHolder;

	void Start ()
	{
		waypointHolder = GameObject.Find ("WaypointHolder").GetComponent<WaypointHolder> ();
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.name == "ColliderBottom") 
		{
			waypointHolder.UpdateScore();
			waypointHolder.UpdateTime ();
			Destroy (this.gameObject);
		}
	}
		
}

