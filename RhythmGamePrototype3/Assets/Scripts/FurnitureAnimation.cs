using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class FurnitureAnimation : MonoBehaviour
{
    public string EventID;
    public List<bool> BeatLoop;
    public float ShrinkDepth;
    public float RecoverRate;
    private int BeatCount;
    
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventID,BeatAnime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BeatAnime(KoreographyEvent evt)
    {
        print("Beat " + BeatCount + " " + BeatLoop[BeatCount]);
        if (BeatLoop[BeatCount])
        {
            transform.localScale = new Vector3(1, ShrinkDepth, 1);
            Invoke("Recover", RecoverRate);
        }
        BeatCount = (BeatCount + 1) % BeatLoop.Count;
    }

    void Recover()
    {
        transform.localScale = new Vector3(1, 1, 1);
    }
}
