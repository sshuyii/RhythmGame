using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class LightOn : MonoBehaviour
{

    private Light light;
    private float targetIntensity;
    private int timer;
    private float duration;
    
    void Awake()
    {
        light = GetComponent<Light>();
        targetIntensity = light.intensity;
        light.intensity = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        duration = Camera.main.GetComponent<CameraMove>().duration;
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraMove.zooming)
        {
            timer++;
            light.intensity = Mathf.Lerp(0, targetIntensity, timer / duration);
        }
    }
}
