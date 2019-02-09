using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmController : MonoBehaviour
{
	public int chopEnabled = 0;
	public bool beatWithinRange = false;
	public bool playerInPlace = false;
	
	private AudioSource beat;
	
	// Use this for initialization
	void Start ()
	{
		beat = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		print(chopEnabled);
		
		
		
		
		if (chopEnabled == 2)
		{
			if (Input.GetKeyDown("space"))
			{
				print("space key was pressed");
				beat.Play();
				//chopEnabled += 1;
			}
		}
	}
}
