using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class RhythmControllerSnap : MonoBehaviour
{
	
	//在inspector里勾选snap将开启snap模式，否则还是正常模式
	
	//public int chopEnabled = 0;
	[FormerlySerializedAs("beatPoint")] [Header("Preset Variables")]
	public float FallingHeight;
	public bool snap;

	[Header("In Game Variables")] 
	public float BallGeneratedHeight;
	public float BeatPointHeight;
	public bool beatWithinRange;
	public bool playerInPlace;
	public bool Timetoplay;

	//public List<GameObject> ToBeDestroyed;//创建一个待摧毁列表（关联Script：BeatWithinRange）

	public GameObject beater;
	public GameObject empty;

	[Header("Statics")] 
	public static int Perfect;
	public static int Miss;

	
	private AudioSource beat;
	//private Renderer rd;
	
	// Use this for initialization
	void Start ()
	{
		BeatPointHeight = transform.Find("BeatRange").transform.position.y;
		BallGeneratedHeight = FallingHeight + BeatPointHeight;
		beat = GetComponent<AudioSource>();
		//print("Beat Point:" + BeatPointHeight);
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
			//rd = beater.GetComponent<MeshRenderer>();
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
	                    Destroy(beater);
	                    Perfect++;
	                    beater = empty;
	                    beatWithinRange = false;
                    }

    				//beat.Play();
    				//chopEnabled += 1;
    			}
    		}

            if (beater.transform.position.y <= BeatPointHeight && Timetoplay)
            {
				beat.Play();
				Timetoplay = false;
	            Destroy(beater);
	            Perfect++;
	            beater = empty;
	            beatWithinRange = false;
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
			Miss++;
		}
			/*else
			{
				ToBeDestroyed.Remove(other.gameObject);
			}*/
	}
}
	
	// Update is called once per frame


