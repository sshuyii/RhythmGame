using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatWithinRange : MonoBehaviour {

	public RhythmController RhythmController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Beat"))
		{
			RhythmController.chopEnabled += 1;
		}
	}
	
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Beat"))
		{
			RhythmController.chopEnabled -= 1;
		}
	}
	
	
}
