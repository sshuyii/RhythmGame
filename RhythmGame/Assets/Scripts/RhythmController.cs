using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RhythmController : MonoBehaviour
{
	public int chopEnabled = 0;
	public bool beatWithinRange = false;
	public bool playerInPlace = false;

	public List<GameObject> ToBeDestroyed;//创建一个待摧毁列表（关联Script：BeatWithinRange）
	
	private AudioSource beat;
	
	// Use this for initialization
	void Start ()
	{
		beat = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{

		print(chopEnabled);
		
		
		
		
		if (chopEnabled == 2)
		{
			if (Input.GetKeyDown("space"))
			{
				print("space key was pressed");
				beat.Play();
				//chopEnabled += 1;
                
				//下面几行都是新加的
				for (int i = 0; i < ToBeDestroyed.Count; i++)
				{
					Destroy(ToBeDestroyed[i]);
					ToBeDestroyed.Remove(ToBeDestroyed[i]);
					chopEnabled--;
				}//摧毁待摧列表里所有的beat
			}
		}
	}
}
