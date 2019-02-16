using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmControllerSnap : MonoBehaviour
{
	
	//在inspector里勾选snap将开启snap模式，否则还是正常模式
	
	//public int chopEnabled = 0;
	public bool beatWithinRange;
	public bool playerInPlace;
	public bool Timetoplay;

	//public List<GameObject> ToBeDestroyed;//创建一个待摧毁列表（关联Script：BeatWithinRange）

	public GameObject beater;
	public GameObject empty;
	public float beatPoint;
	public bool snap;
	
	private AudioSource beat;
	
	// Use this for initialization
	void Start ()
	{
		beat = GetComponent<AudioSource>();
		beatPoint = 4;
		print("Beat Point:" + beatPoint);
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
			beater = other.gameObject;
			//ToBeDestroyed.Add(other.gameObject);
			Timetoplay = false;
		}
	}
		void Update ()
    	{
    
    		//print(chopEnabled);	
    		
    		if (playerInPlace && beatWithinRange)
    		{
    			if (Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.E))
    			{
    				print("space key was pressed");
      				//下面几行都是新加的
                    /*for (int i = 0; i < ToBeDestroyed.Count; i++)
                    {
                        Destroy(ToBeDestroyed[i]);
                        ToBeDestroyed.Remove(ToBeDestroyed[i]);
                        //beatWithinRange = false;
                        //chopEnabled--;
                    }*///摧毁待摧列表里所有的beat
                    if (snap)
                    {
    				    Timetoplay = true;	                    
                    }
                    else
                    {
	                    beat.Play();
	                    beater.GetComponent<MeshRenderer>().enabled = false;	                    
                    }

    				//beat.Play();
    				//chopEnabled += 1;
    			}
    		}

            if (beater.transform.position.y <= beatPoint && Timetoplay)
            {
				beat.Play();
				Timetoplay = false;
				beater.GetComponent<MeshRenderer>().enabled = false;
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
			beater = empty;
		}
			/*else
			{
				ToBeDestroyed.Remove(other.gameObject);
			}*/
	}
}
	
	// Update is called once per frame


