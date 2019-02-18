using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;

public class RhythmController : MonoBehaviour
{
	//public int chopEnabled = 0;
	public bool beatWithinRange;
	public bool playerInPlace;

	public bool snap;
	public GameObject BeatStop;
	public List<GameObject> ToBeDestroyed;//创建一个待摧毁列表（关联Script：BeatWithinRange）
	
	private AudioSource beat;
	private bool beatStop = false;
	private GameObject beatStopObject;
	private float stopMoving;
	
	
	
	void Start ()
	{
		beat = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			playerInPlace = true;
		}
		
		if (other.gameObject.CompareTag("Beat"))
		{
			beatWithinRange = true;
			ToBeDestroyed.Add(other.gameObject);
		}
		
		else if(other.gameObject.CompareTag("BeatStop"))
		{
			beatWithinRange = true;
			beatStop = true;
			print("beat should stop");
			beatStopObject = other.gameObject;
			stopMoving = other.gameObject.GetComponent<BeatFalling>().speed;

		}
	}
	
	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			playerInPlace = false;
		}
		
		if (other.gameObject.CompareTag("Beat"))
		{
			beatWithinRange = false;
			ToBeDestroyed.Remove(other.gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		//print(chopEnabled);

		if (beatStop)
		{
			stopMoving = 0;
		}
		
		
		if (playerInPlace && beatWithinRange)
		{
			if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.E))
			{
				print("square key was pressed");
				if (beatStop == true)
				{
					beat.Stop();
					ToBeDestroyed.Add(beatStopObject);

				}
				else
				{
					beat.Play();
					//chopEnabled += 1;
				}
				

				
				
				//下面几行都是新加的
				for (int i = 0; i < ToBeDestroyed.Count; i++)
				{
					Destroy(ToBeDestroyed[i]);
					ToBeDestroyed.Remove(ToBeDestroyed[i]);
					beatWithinRange = false;
					//chopEnabled--;
				}//摧毁待摧列表里所有的beat
			}
		}
	}
}
