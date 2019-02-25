using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.NetworkSystem;

public class BeatFalling : MonoBehaviour
{

	public float speed;
	//public int FallingTime;
	
	private Vector3 position;
	
	// Use this for initialization
	void Start ()
	{	
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{

		position.y -= speed;
		transform.position = position;

		if (transform.position.y < 4)
		{
			Destroy(gameObject);
		}
	}

}
