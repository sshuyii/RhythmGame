using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Serialization;

public class RhythmControllerSnap : MonoBehaviour
{
	private AudioSource AudioSource;
	
	private void Start()
	{
		AudioSource = GetComponent<AudioSource>();

	}

	private void Update()
	{
		
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			AudioSource.Play();
		}
	}
}


