using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

//make sure you're using the Koreo namespace
using SonicBloom.Koreo;


public class JumpingScript : MonoBehaviour {

	
	//We will use this when we implement the other characters
	public enum Character {
		B,
		C,
		D
	};
	public Character thisCharacter;

	//audio clips for jumping and falling
	public AudioClip jumpClip, fallClip;

	//component references;
	private AudioSource _audioSource;
	private Animator _animator;

	//an extra bool because the animator doesn't like when i check "isJumping";
	private bool _BCanJump;

	
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
		_audioSource = GetComponent<AudioSource>();
		_BCanJump = false;
		
		//Register for the events being broadcasted from our koreography track
		//In this case we called the event "BJumpEventID"
		Koreographer.Instance.RegisterForEvents("BJumpEventID", BJumpWindow);
		//We also need an event that signals when we are out of our jump window.
		Koreographer.Instance.RegisterForEvents("BJumpEndEventID", BOutofJumpWindow);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.B))
		{
			//check to see if we are within the window (and aren't already falling)
			//if so, then jump!
			if (_BCanJump) {
				BJump();
			}
			
			//if not, fall :-(
			else {
				BFall();
			}
			
		}
	}

	//We trigger this in our animation clip so that B returns to idle after the jump/fall is complete
	public void ReturnToIdle() {
		_animator.SetBool("isJumping", false);
		_animator.SetBool("isFalling", false);
	}

	
	//Koreographer is going to call BJumpWindow across the span that we set
	//in the Koreography track
	
	//We listen for that event, and set _BCanJump to true so that the player input
	//is recognized across that event
	public void BJumpWindow(KoreographyEvent koreographyEvent) {
		_BCanJump = true;
	}

	public void BOutofJumpWindow(KoreographyEvent koreographyEvent) {
		_BCanJump = false;
	}

	public void BFall() {
		_animator.SetTrigger("Fall");
		_animator.SetBool("isFalling", true);
		_audioSource.clip = fallClip;
		_audioSource.Play();
	}

	public void BJump() {
		_animator.SetTrigger("Jump");
		_animator.SetBool("isJumping", true);
		_BCanJump = false;
		_audioSource.clip = jumpClip;
		_audioSource.Play();
	}

}
