using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class PayloadTest : MonoBehaviour
{
    private AudioSource _audio;
    public string EventID;
    //public float minScale = 0f;
    //public float maxScale = 1.2f;
    //private Vector3 interim;
    
    // Start is called before the first frame update
    void Start()
    {
        //Koreographer.Instance.RegisterForEvents("TestTrack", TestPayload);
        Koreographer.Instance.RegisterForEventsWithTime(EventID,TestOffset);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

/*    void TestPayload(KoreographyEvent evt)
    {
        print(evt.GetIntValue() + " " + Time.time);
    }*/

    void TestOffset(KoreographyEvent evt, int sampleTime, int sampleDelta, DeltaSlice deltaSlice)
    {
        /*print("OffSet " + Time.time);
        print(sampleTime);
        print(sampleDelta);*/
        if (evt.HasCurvePayload())
        {
            //print("Scale Start");
            // Get the value of the curve at the current audio position.  This will be a
            //  value between [0, 1] and will be used, below, to interpolate between
            //  minScale and maxScale.
            float curveValue = Mathf.Clamp(evt.GetValueOfCurveAtTime(sampleTime), 0.5f, 1);
            print(curveValue);


            //transform.position = new Vector3(Random.Range(0 , 5), 0, Random.Range(-5 , 0));
            
            //interim = Vector3.one * Mathf.Lerp(minScale, maxScale, curveValue);
            //interim.y = 1.2f;
            transform.localScale *= curveValue;
        }
    }
}
