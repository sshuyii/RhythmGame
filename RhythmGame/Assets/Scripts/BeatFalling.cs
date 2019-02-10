using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatFalling : MonoBehaviour
{

	public float speed;
	

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

	}

	
}
