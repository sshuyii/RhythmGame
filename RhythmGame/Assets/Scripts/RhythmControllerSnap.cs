using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmControllerSnap : MonoBehaviour
{
	//public int chopEnabled = 0;
	public bool beatWithinRange;
	public bool playerInPlace;
	public bool Timetoplay;

	public List<GameObject> ToBeDestroyed;//创建一个待摧毁列表（关联Script：BeatWithinRange）
	
	private AudioSource beat;
	
	// Use this for initialization
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
			Timetoplay = false;
		}
	}
		void Update ()
    	{
    
    		//print(chopEnabled);	
    		
    		if (playerInPlace)
    		{
    			if (Input.GetKeyDown("space"))
    			{
    				print("space key was pressed");
    				Timetoplay = true;
    				//beat.Play();
    				//chopEnabled += 1;
                    
    				

    			}
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
			
			if (Timetoplay)
			{
				beat.Play();
				Timetoplay = false;
				
				//下面几行都是新加的
    			for (int i = 0; i < ToBeDestroyed.Count; i++)
    			{
    				Destroy(ToBeDestroyed[i]);
    				ToBeDestroyed.Remove(ToBeDestroyed[i]);
    				//beatWithinRange = false;
    				//chopEnabled--;
    			}//摧毁待摧列表里所有的beat				
			}
			else
			{
				ToBeDestroyed.Remove(other.gameObject);
			}
		}
	}
	
	// Update is called once per frame

}
