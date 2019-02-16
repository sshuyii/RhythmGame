using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class BeatGenerator : MonoBehaviour
{

	public GameObject Beat;
	public GameObject Table;
	

	private float Timer = 1f;
	private float TimerEnd;
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		Vector3 startPosition = Table.transform.position;
		startPosition.y += 8;
		
		
		Timer -= Time.deltaTime;
		
		if(Timer < 0)
		{
			Instantiate(Beat, startPosition, Quaternion.identity);
			Timer = 1f;
		}
		
	}
}
