using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetClipData : MonoBehaviour
{
    public AudioSource BGM;
    public float[] data;
    public Scoring _scoring;
    
    // Start is called before the first frame update
    void Start()
    {
        Array.Resize(ref data, 2);
        
        BGM = GetComponent<AudioSource>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        /*_scoring.Miss.text = "0f";*/
        Invoke("CheckVolume", 0);
    }

    void CheckVolume()
    {
        BGM.clip.GetData(data, BGM.timeSamples);
        print(data[0]);
        print("OK");
    }
}
