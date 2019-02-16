using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Boo.Lang;
using UnityEngine;

public class BeatWithinRange : MonoBehaviour {

	public RhythmController RhythmController;
	public float beatHeight = 8;
	//public float selfHeight = 4;
	
	// Use this for initialization
	void Start ()
	{

		//selfHeight = transform.position.y;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/*private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Beat"))
		{
			//RhythmController.chopEnabled += 1;
			
			RhythmController.ToBeDestroyed.Add(other.gameObject);//将进入范围的Beat标记添加到待摧毁列表（关联Script：RhythmController）
		}
	}
	
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("Beat"))
		{
			//RhythmController.chopEnabled -= 1;
			
			RhythmController.ToBeDestroyed.Remove(other.gameObject);//将离开范围的Beat标记从待摧毁列表中移除
		}
	}*/
	
	
}
