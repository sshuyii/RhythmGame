using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Serialization;

public class RhythmControllerSnap : MonoBehaviour
{
	private AudioSource AudioSource;
	private MeshRenderer rd;

	public static int Perfect;
	public static int Miss;
	
	private void Start()
	{
		AudioSource = GetComponent<AudioSource>();
		rd = GetComponent<MeshRenderer>();

	}

	private void Update()
	{
		
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			if (true)
			{
				AudioSource.Play();
    			rd.enabled = false;
                Perfect++;
                //Destroy(gameObject);			
			}

		}
	}
}


