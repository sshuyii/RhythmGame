using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Serialization;

public class RhythmControllerSnap : MonoBehaviour
{
	
	//在inspector里勾选snap将开启snap模式，否则还是正常模式
	
	//public int chopEnabled = 0;
	[FormerlySerializedAs("beatPoint")] [Header("Preset Variables")]
	public float FallingHeight;
	public bool snap;
	public BeatFalling BeatFalling;

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
	private bool beatStop = false;
	private float beatSpeed;
	private int playerNum;
	private List<int> playerInColliderList = new List<int>();
	private bool Player1Enabled = false;
	private bool Player2Enabled = false;
	private bool Player3Enabled = false;

		
	
	//private Renderer rd;
	
	// Use this for initialization
	void Start ()
	{
		BeatPointHeight = transform.Find("BeatRange").transform.position.y;
		BallGeneratedHeight = FallingHeight + BeatPointHeight;
		beat = GetComponent<AudioSource>();
		//print("Beat Point:" + BeatPointHeight);
	}

	private float beatY;
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			playerInPlace = true;
			
			//记录下进入范围的player编号
			playerNum = other.gameObject.GetComponent<PlayerController>().playerNum;
			print("playerNum = " + playerNum);
			playerInColliderList.Add(playerNum);
		}
		
		if (other.gameObject.CompareTag("Beat"))
		{
			beatWithinRange = true;
			beater = other.gameObject;
			//rd = beater.GetComponent<MeshRenderer>();
			//ToBeDestroyed.Add(other.gameObject);
			Timetoplay = false;
		}
		else if(other.gameObject.CompareTag("BeatStop"))
		{
			beatWithinRange = true;
			beater = other.gameObject;
			Timetoplay = false;
			
			beatStop = true;
			print("beat should stop");
			BeatFalling = beater.GetComponent<BeatFalling>();

		}
	}
		void Update ()
    	{
    
	        //把停止的节奏球限制在range的正中间
	        if (beatStop && beater.transform.position.y < BeatPointHeight)
	        {
		        BeatFalling.speed = 0;
	        }
	        
    		//print(chopEnabled);	
    		
    		if (playerInPlace && beatWithinRange)
    		{	
	            //判断到底是哪个player在按键
	            for (int i = 0; i < playerInColliderList.Count; i++)
	            {
		            if (playerInColliderList[i] == 1)
		            {
			            Player1Enabled = true;
		            }
		            else if (playerInColliderList[i] == 2)
		            {
			            Player2Enabled = true;
		            }
		            else if (playerInColliderList[i] == 3)
		            {
			            Player3Enabled = true;
		            }
	            }

	            if (Player1Enabled)
	            {
		            if(Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.E))
			      
		            GenerateBeat();
		            print("space key was pressed");
	            }
                
	            if (Player2Enabled)
	            {
		            if(Input.GetKeyDown("joystick button 0") || Input.GetKeyDown("shift"))
			      
			            GenerateBeat();
		            print("space key was pressed");
	            }
	            
	            if (Player3Enabled)
	            {
		            if(Input.GetKeyDown("joystick button 0") || Input.GetKeyDown(KeyCode.O))
			      
			            GenerateBeat();
		            print("space key was pressed");
	            }
    		}

		    if (beater != null)
		    {
	            if (beater.transform.position.y <= BeatPointHeight && Timetoplay)
                {
    	            if (beatStop)
    	            {
    		            beat.Stop();
    	            }
    	            else
    	            {
    		            beat.Play();
    	            }
    
    	            Timetoplay = false;
    		        Destroy(beater);
    		        Perfect++;
    		        beater = empty;
    		        beatWithinRange = false;
    	          
                }		    
		    }
    	}


		private void GenerateBeat()
		{
			if (snap)
			{
				Timetoplay = true;	                    
			}
			else
			{
				if (beatStop)
				{beat.Stop();}
				else{beat.Play();}
	                    
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
			//把离开collider的player从list中删除
			playerNum = other.gameObject.GetComponent<PlayerController>().playerNum;
			playerInColliderList.Remove(playerNum);

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


