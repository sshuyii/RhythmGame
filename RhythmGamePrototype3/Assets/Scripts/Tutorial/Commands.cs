using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Commands : MonoBehaviour
{
    public String commandName;

    public FurnitureInteractor targetFurniture;

    //public NarrativeControl narrativeManager;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(commandName, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Refresh()
    {
        NarrativeControl.narrativeControl.expectingInteraction = true;
    }

    void StartCradleRhythm()
    {
        targetFurniture.Waiting = false;
        targetFurniture.Free = true;
        NarrativeControl.narrativeControl.expectingInteraction = true;
    }

    IEnumerator Wait()
    {
        while (BeatController.beatController.BeatCount != 0)
        {
            yield return 0;
        }

    }

    void Pause()
    {
        Time.timeScale = 0;
    }
}
