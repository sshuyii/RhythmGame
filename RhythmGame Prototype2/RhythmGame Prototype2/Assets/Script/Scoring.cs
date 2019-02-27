using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update

    public Text Perfect;
    public Text Miss;

    public int PerfectNum;
    public int MissNum;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PerfectNum = RhythmControllerSnap.Perfect;
        MissNum = RhythmControllerSnap.Miss;
        Perfect.text = "Perfect: " + PerfectNum;
        Miss.text = "Miss: " + MissNum;
    }
}
