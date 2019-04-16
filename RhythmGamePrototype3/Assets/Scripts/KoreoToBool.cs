using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class KoreoToBool : MonoBehaviour
{
    public static bool NewspaperEnable;
    public static bool GlassEnable;
    public static bool ChoppingEnable;

    private AudioSource _audio;


    //public static KoreoToBool instance;
    
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();    
            
        Koreographer.Instance.RegisterForEvents("AllBeats", AllBeats);
        //Koreographer.Instance.RegisterForEvents("NewspaperEndEventID", NewspaperEnd);
        Koreographer.Instance.RegisterForEvents("WindowOpen", WindowOpen);
        //Koreographer.Instance.RegisterForEvents("GlassEndEventID", GlassEnd);
        Koreographer.Instance.RegisterForEvents("WindowClose", WindowClose);
        //Koreographer.Instance.RegisterForEvents("ChoppingEndEventID", ChoppingEnd);
    }
    
    void AllBeats(KoreographyEvent evt)
    {
            NewspaperEnable = true;
            _audio.Play();
            print("NewspaperStart");
    }
	
    void NewspaperEnd(KoreographyEvent evt)
    {
            NewspaperEnable = false;
            print("NewspaperEnd");
    }

    void WindowOpen(KoreographyEvent evt)
    {
            GlassEnable = true;
            //_audio[0].Play();
            print("GlassStart");
    }
	
    void GlassEnd(KoreographyEvent evt)
    {
            GlassEnable = false;
            print("GlassEnd");
    }

    void WindowClose(KoreographyEvent evt)
    {
            ChoppingEnable = true;
            //_audio[2].Play();
            print("ChoppingStart");
    }
	
    void ChoppingEnd(KoreographyEvent evt)
    {
            ChoppingEnable = false;
            print("ChoppingEnd");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
