using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableCollider : MonoBehaviour
{
	public GameObject Father;
	public RhythmController RhythmController;

	//chopEnabled is put into RhythmController
	//public int chopEnabled = 0;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			RhythmController.chopEnabled += 1;
		}
		
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			RhythmController.chopEnabled -= 1;
		}
		
	}
}
