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

    
    //什么都不做：
    void None()
    {
        
    }
    
    
    //允许玩家按互动键进入下一条：
    void Refresh()
    {
        NarrativeControl.narrativeControl.expectingInteraction = true;
    }

    
    //让家具不断打节奏（需要在Target Furniture里填入该家具的Interactor）：
    void StartCradleRhythm()
    {
        targetFurniture.Waiting = false;
        targetFurniture.Free = true;
        //NarrativeControl.narrativeControl.expectingInteraction = true;
    }

    
    //等待至下一个第0拍，然后自动进入下一条：
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

    
    //让家具回到静止状态（需要在Target Furniture里填入该家具的Interactor）：
    void StopFurniture()
    {

        targetFurniture.Waiting = true;
        targetFurniture.Free = false;
        targetFurniture.Resting = false;
        targetFurniture.Demonstrating = false;
        targetFurniture.Checking = false;
        
        //targetFurniture._anim.SetBool("IsMoving", false);

    }


    //让家具开始演示并允许玩家打节奏（需要在Target Furniture里填入该家具的Interactor）：
    void StartCradleDemo()
    {
        targetFurniture.Waiting = false;
        targetFurniture.Free = false;
        targetFurniture.Resting = true;
        
        //targetFurniture._anim.SetBool("IsMoving", true);
    }

    
    //暂停游戏（需要在Target Audio里填入BGM物件）：
    void Pause()
    {
        Time.timeScale = 0;
        targetAudio.Pause();        
    }

    
    //继续游戏（需要在Target Audio里填入BGM物件）：
    void Resume()
    {
        Time.timeScale = 1;
        targetAudio.UnPause();
    }

    //等待至玩家打对第一次，然后自动进入下一条（需要在Target Furniture里填入该家具的Interactor）：
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

    //等待至玩家激活家具，然后自动进入下一条（需要在Target Furniture里填入该家具的Interactor）：
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

    //隐藏提示（需要在Instruction里填入TEXT物件）：
    void HideInstruction()
    {
        instruction.SetActive(false);
    }

    //显示提示（需要在Instruction里填入TEXT物件）：
    void ShowInstruction()
    {
        instruction.SetActive(true);
    }

    //切换房间，然后自动进入下一条（需要在Room1里填入起始房间， 在Room2里填入目标房间, 在Target Furniture里填入目标房间里的家具的Interactor）：
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
