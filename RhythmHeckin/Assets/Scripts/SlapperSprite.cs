using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class SlapperSprite : MonoBehaviour {

	public Sprite neutralSprite, slappedSprite;
	//we want the left and right to be controlled by different keys
	public enum WhichSlapper {left, right};
	public WhichSlapper whichSlapper;
	
    //reference to the SpriteRenderer on this GameObject
    private SpriteRenderer spriteRenderer;
    
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		Koreographer.Instance.RegisterForEvents("SlapEventID", PlaySlapSound);
	}
	
	// Update is called once per frame
	void Update () {
		//Debug Only
		
	}

	public void SuccessfulSlap() 
	{
		StopAllCoroutines();
		spriteRenderer.sprite = slappedSprite;
		StartCoroutine(ReturnToNeutral(0.5f));
	}

	IEnumerator ReturnToNeutral(float returnTime) 
	{
		yield return new WaitForSeconds(returnTime);
		spriteRenderer.sprite = neutralSprite;

	}

	public void PlaySlapSound(KoreographyEvent koreographyEvent) 
	{
		Debug.Log("should slap here");
		if (Input.GetKeyDown(KeyCode.S) && whichSlapper == WhichSlapper.left) 
		{
			//activate left slapper
			SuccessfulSlap();
		}
		else if (Input.GetKeyDown(KeyCode.L) && whichSlapper == WhichSlapper.right) 
		{
			//activate right slapper
			SuccessfulSlap();
		}
		
	}
}
