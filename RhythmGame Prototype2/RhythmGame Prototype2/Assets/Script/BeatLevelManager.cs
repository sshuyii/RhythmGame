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
    //public GameObject DinnerTable;
    //public GameObject Chair;
    //public GameObject BeatType1;
    //public GameObject BeatType2;
    public Vector3 Beat;

    public GameObject ColliderPrefab;


    public int RemoveBeatNumber;
    public List<GameObject> FurnitureList;//创建一个家具列表
    public List<GameObject> BallList;//创建一个小球列表
    
    private List<float> beatTimeList = new List<float>();
    private float Timer;    
    private int nextBeat;
    
    private Vector3 BeatPlace;
    private GameObject ThisBeatType;
    private GameObject Prefab;
    
    //private int i = 0;
    //private List<int> nextBeat = new List<int>();


    [Header("My List of Beats")]
    public List<Vector3> beatList = new List<Vector3>();


    private void Awake()
    {
        Prefab = Resources.Load<GameObject>("Prefabs/Collider");

    }

    // Start is called before the first frame update
    void Start()
    {
        //recording a list of the exact time to generate the beats
        for (int i = 0; i < beatList.Count; i++)
        {
            beatTimeList.Add(beatList[i].x * 60f - 20f);//这里提前给了20帧用来当缓冲
            //产生之后等20帧就自行销毁，写在collider本身的script中了

            print("beatTimeList[0] = " + beatTimeList[0]);
        }

        //recording a list of beat generated height with the same index of the furniture list
        for (int i = 0; i < FurnitureList.Count; i++)
        {
            //HeightList.Add(FurnitureList[i].GetComponent<RhythmControllerSnap>().BallGeneratedHeight);
            //这一行暂时注释掉，因为现在还找不到RhythmControllerSnap
        }
        
    }


    // Update is called once per frame
    void Update()
    {
        //print("Frame = " + 1/Time.deltaTime);
        Timer += 1;
        //print(beatList.Count);
        //print(nextBeat);
        
            if (Timer == beatTimeList[nextBeat])
            {    
                Instantiate(ColliderPrefab, DecipherBeatPlace(nextBeat), Quaternion.identity);
                print("Update is generating beats.");
                if (nextBeat < beatTimeList.Count - 1)
                {
                    nextBeat++;                    
                }
                else
                {
                    print("Level Clear");
                }
            }
        
    }
/*
    private Vector3 DecipherBeatPlace(int i)
    {
        //这里有一个问题，产生球的地方是物体上方，真正合在节奏上的时间比产生的时间要晚（加上了掉下来的时间）
        //现在是判定范围的transform.y + 8,速度为0.2，因此在instantiate的时候减少了了8/0.2 = 40帧
        //the exact place to generate the beat
        /*if (beatList[i].x == 1)
        {
            BeatPlace.Set(DinnerTable.transform.position.x, 
                    DinnerTable.transform.position.y + BeatHeight,
                    DinnerTable.transform.position.z);
        }
        else if (beatList[i].x == 2)
        {
            BeatPlace.Set(Chair.transform.position.x, 
                Chair.transform.position.y + BeatHeight,
                Chair.transform.position.z);
        }

        int index = (int) (beatList[i].x - 1f);
        GameObject furniture = FurnitureList[index];//从家具列表中取得此时nextBeat所对应的家具
        float heightadjust = HeightList[index];//从高度列表中取得此时nextBeat所对应的小球生成高度
        BeatPlace.Set(furniture.transform.position.x, heightadjust, furniture.transform.position.z);//设定小球生成位置
        

        return BeatPlace;
    }
*/
    private Vector3 DecipherBeatPlace(int i)
    {

        Vector3 BeatPlace = new Vector3();
        BeatPlace.Set(beatList[i].y, 0, beatList[i].z);
        return BeatPlace;
    }
    

    private GameObject DecipherBeatType(int i)
    {
        //what types of beat to generate
        /*if (beatList[i].z == 1)
        { 
            ThisBeatType = BeatType1;
        }
        else if (beatList[i].z == 2)
        {
            ThisBeatType = BeatType2;
        }*/

        ThisBeatType = BallList[(int) (beatList[i].z - 1f)];//从小球列表中获取此时nextBeat所对应小球类型

        return ThisBeatType;
    }

    //decide when to create the beat
    /*private float BeatTiming(int i)
    {
        for (int a = 0; a < beatList.Count; a++)
        {
            Timer = beatList[i].y * 60 - 40;
            print("Timer = " + Timer);
        }

        return Timer;
    }*/
    
}
