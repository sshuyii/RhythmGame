using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;


//[ExecuteInEditMode]
public class BeatLevelManager : MonoBehaviour
{

    [FormerlySerializedAs("KitchenTable")] [Header("Public References")] 
    public GameObject DinnerTable;
    public GameObject BeatType1;
    public Vector3 Beat;

    private Vector3 BeatPlace;
    private float Timer = 0;
    private GameObject ThisBeatType;
    private int i = 0;
    private List<float> beatTimeList = new List<float>();
    //private List<int> nextBeat = new List<int>();
    private int nextBeat = 0;


       
    [Header("My List of Beats")]
    public List<Vector3> beatList = new List<Vector3>();
    
    // Start is called before the first frame update
    void Start()
    {
        //recording a list of the exact time to generate the beats
        for (int i = 0; i < beatList.Count; i++)
        {
            beatTimeList.Add(beatList[i].y * 60);

            print("beatTimeList[0] = " + beatTimeList[0]);
        }
        
        //is there a need to build another list??? not sure right now
//        int beatIndex = 0;
//        for (int i = 0; i < beatList.Count; i++)
//        {
//            nextBeat.Add(beatIndex);
//            beatIndex++;
//        }
        
    }


    // Update is called once per frame
    void Update()
    {
        Timer += 1;
        print(beatList[0]);
        
            if (Timer == beatTimeList[nextBeat])
            {    
                Instantiate(DecipherBeatType(nextBeat), DecipherBeatPlace(nextBeat), Quaternion.identity);
                print("Update is generating beats.");
                nextBeat++;
            }
        
    }

    
    private Vector3 DecipherBeatPlace(int i)
    {
        //这里有一个问题，产生球的地方是物体上方，真正合在节奏上的时间比产生的时间要玩（加上了掉下来的时间）
        //现在是判定范围的transform.y + 8,速度为0.2，因此在instantiate的时候减少了了8/0.2 = 40帧
        //the exact place to generate the beat
        if (beatList[i].x == 1)
        {
            BeatPlace.Set(DinnerTable.transform.position.x, 
                    DinnerTable.transform.position.y + 8,
                    DinnerTable.transform.position.z);
        }

        return BeatPlace;
    }

    private GameObject DecipherBeatType(int i)
    {
        //what types of beat to generate
        if (beatList[i].z == 1)
        {
            ThisBeatType = BeatType1;
        }

        return ThisBeatType;
    }

    //decide when to create the beat
    private float BeatTiming(int i)
    {
        for (int a = 0; a < beatList.Count; a++)
        {
            Timer = beatList[i].y * 60 - 40;
            print("Timer = " + Timer);
        }

        return Timer;
    }
    
}
