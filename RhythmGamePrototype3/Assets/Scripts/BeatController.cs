using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class BeatController : MonoBehaviour
{
    public static BeatController beatController;

    public int BeatCount;

    public string EventID;
    // Start is called before the first frame update

    private void Awake()
    {
        BeatController.beatController = this;
    }

    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventID, BeatIncrease);
    }

    void BeatIncrease(KoreographyEvent evt)
    {
        BeatCount = (BeatCount + 1) % 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
