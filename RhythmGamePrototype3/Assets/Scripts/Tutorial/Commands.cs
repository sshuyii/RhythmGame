using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Analytics;

public class Commands : MonoBehaviour
{
    public String commandName = "Refresh";

    public FurnitureInteractor targetFurniture;

    public AudioSource targetAudio;
    public GameObject instruction;

    public GameObject room1;
    public GameObject room2;

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
        //NarrativeControl.narrativeControl.expectingInteraction = true;
    }

    void Wait()
    {
        StartCoroutine(Waiting());
    }

    IEnumerator Waiting()
    {
        //print("Waiting");
        while (BeatController.beatController.BeatCount != 0)
        {
            yield return 0;
        }
        
        NarrativeControl.narrativeControl.NextStep();

    }

    void Pause()
    {
        Time.timeScale = 0;
        targetAudio.Pause();
        
    }

    void None()
    {
        
    }

    void StartCradleDemo()
    {
        targetFurniture.Waiting = false;
        targetFurniture.Free = false;
        targetFurniture.Resting = true;
    }

    void Resume()
    {
        Time.timeScale = 1;
        targetAudio.UnPause();
    }

    void WaitUntilFirstCorrect()
    {
        StartCoroutine(WaitingUntilFirstCorrect());
    }
    
    IEnumerator WaitingUntilFirstCorrect()
    {
        while (targetFurniture.localPerfectTimes == 0)
        {
            yield return 0;
        }
        
        NarrativeControl.narrativeControl.NextStep();
    }

    void WaitUntilActivated()
    {
        StartCoroutine(WaitingUntilActivated());
    }
    
    IEnumerator WaitingUntilActivated()
    {
        while (targetFurniture.Activated == false)
        {
            yield return 0;
        }
        
        NarrativeControl.narrativeControl.NextStep();
    }

    void HideInstruction()
    {
        instruction.SetActive(false);
    }

    void ShowInstruction()
    {
        instruction.SetActive(true);
    }

    void ChangeRoom()
    {
        StartCoroutine(MoveCamera(Camera.main.transform.position,
            Camera.main.transform.position + room2.transform.position - room1.transform.position, 120f));

        NarrativeControl.narrativeControl.currentInteractingPlayer = targetFurniture.playersInvolved[0].gameObject.GetComponent<PlayerController>().playerId;
        //room1.SetActive(false);
        //room2.SetActive(true);
    }

    IEnumerator MoveCamera(Vector3 ori, Vector3 des, float dur)
    {
        float timer = 0;
        while (timer < dur)
        {
            Camera.main.transform.position = Vector3.Lerp(ori, des, timer / dur);

            yield return 0;
            
            timer++;
        }
        
        NarrativeControl.narrativeControl.NextStep();
    }
}
