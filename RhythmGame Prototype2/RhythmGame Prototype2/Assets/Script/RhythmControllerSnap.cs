using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Serialization;
using SonicBloom.Koreo;

public class RhythmControllerSnap : MonoBehaviour
{
	private AudioSource AudioSource;
	private MeshRenderer rd;

	public static int Perfect;
	public static int Miss;

	public bool AlreadyStepped;

	//public bool NewspaperEnable;
	//public bool GlassEnable;
	//public bool ChoppingEnable;
	
	private void Start()
	{
		AudioSource = GetComponent<AudioSource>();
		rd = GetComponent<MeshRenderer>();
		//Koreographer.Instance.RegisterForEvents("NewspaperEventID", NewspaperStart);
		//Koreographer.Instance.RegisterForEvents("NewspaperEndEventID", NewspaperEnd);
		//Koreographer.Instance.RegisterForEvents("GlassEventID", GlassStart);
		//Koreographer.Instance.RegisterForEvents("GlassEndEventID", GlassEnd);
		//Koreographer.Instance.RegisterForEvents("ChoppingEventID", ChoppingStart);
		//Koreographer.Instance.RegisterForEvents("ChoppingEndEventID", ChoppingEnd);
	}

/*	void NewspaperStart(KoreographyEvent evt)
	{
	    //print("NewspaperEnable");		
		if (name == "TurningPageCollider(Clone)")
		{
			NewspaperEnable = true;
			print("NewspaperStart");
		}

	}
	
	void NewspaperEnd(KoreographyEvent evt)
	{
		//print("NewspaperEnable");		
		if (name == "TurningPageCollider(Clone)")
		{
			NewspaperEnable = false;
			print("NewspaperEnd");
		}

	}

	void GlassStart(KoreographyEvent evt)
	{
		if (name == "TappingOnGlassCollider(Clone)")
		{
			GlassEnable = true;
			print("GlassStart");
		}
	}
	
	void GlassEnd(KoreographyEvent evt)
	{
		if (name == "TappingOnGlassCollider(Clone)")
		{
			GlassEnable = false;
			print("GlassEnd");
		}
	}

	void ChoppingStart(KoreographyEvent evt)
	{
		if (name == "ChoppingCollider(Clone)")
		{
			ChoppingEnable = true;
			print("ChoppingStart");
		}
	}
	
	void ChoppingEnd(KoreographyEvent evt)
	{
		if (name == "ChoppingCollider(Clone)")
		{
			ChoppingEnable = false;
			print("ChoppingEnd");
		}
	}*/

	private void Update()
	{
		
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
	        rd.enabled = false;		
			if (!AlreadyStepped)
			{
				AlreadyStepped = true;			
    			if ((name == "TurningPageCollider(Clone)" && KoreoToBool.NewspaperEnable) || 
                    (name == "TappingOnGlassCollider(Clone)" && KoreoToBool.GlassEnable) ||
                    (name == "ChoppingCollider(Clone)" && KoreoToBool.ChoppingEnable))
    			{
    				AudioSource.Play();
                    Perfect++;
                    //Destroy(gameObject);			
			    }
				else
    			{
    				//Destroy(gameObject);
    				Miss++;
    			}		
			}
		}
	}
}


