using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;

public class BeatFalling : MonoBehaviour
{

	public float speed;
	public int FallingTime;
	
	private Vector3 position;
	
	// Use this for initialization
	void Start ()
	{
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		FallingTime++;
		position.y -= speed;
		transform.position = position;

		//if beat go below the floor, destroy it
		if (gameObject.transform.position.y < 0)
		{
			Destroy(gameObject);
		}

	}

	
}
