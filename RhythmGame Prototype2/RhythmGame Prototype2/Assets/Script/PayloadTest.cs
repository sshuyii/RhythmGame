using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class PayloadTest : MonoBehaviour
{
    private AudioSource _audio;
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents("TestTrack", TestPayload);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TestPayload(KoreographyEvent evt)
    {
        print(evt.GetIntValue());
    }
}
