using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelodyPlay : MonoBehaviour
{
    public int activatedFurnitureNum = 0;
    public int groupNum;
    
    private float timer = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (groupNum == 1 && activatedFurnitureNum == 4)
        {
            //以下用于games & players的ab test，判断打完第一组家具之后到底用了多长时间
            
            Tinylytics.AnalyticsManager.LogCustomMetric("TimeInTotal",
                    timer.ToString());
            activatedFurnitureNum = 0;
        }
    }
}
