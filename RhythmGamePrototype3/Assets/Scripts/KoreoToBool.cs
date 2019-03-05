using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class KoreoToBool : MonoBehaviour
{
    public static bool NewspaperEnable;
    public static bool GlassEnable;
    public static bool ChoppingEnable;


    //public static KoreoToBool instance;
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents("NewspaperEventID", NewspaperStart);
        Koreographer.Instance.RegisterForEvents("NewspaperEndEventID", NewspaperEnd);
        Koreographer.Instance.RegisterForEvents("GlassEventID", GlassStart);
        Koreographer.Instance.RegisterForEvents("GlassEndEventID", GlassEnd);
        Koreographer.Instance.RegisterForEvents("ChoppingEventID", ChoppingStart);
        Koreographer.Instance.RegisterForEvents("ChoppingEndEventID", ChoppingEnd);
    }
    
    void NewspaperStart(KoreographyEvent evt)
    {
            NewspaperEnable = true;
            print("NewspaperStart");
    }
	
    void NewspaperEnd(KoreographyEvent evt)
    {
            NewspaperEnable = false;
            print("NewspaperEnd");
    }

    void GlassStart(KoreographyEvent evt)
    {
            GlassEnable = true;
            print("GlassStart");
    }
	
    void GlassEnd(KoreographyEvent evt)
    {
            GlassEnable = false;
            print("GlassEnd");
    }

    void ChoppingStart(KoreographyEvent evt)
    {
            ChoppingEnable = true;
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
