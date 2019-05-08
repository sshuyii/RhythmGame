using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOverallController : MonoBehaviour
{
    public int LightEnabled = 0;

    public Light EnvironmentLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LightEnabled == 13)
        {
            EnvironmentLight.intensity = Mathf.Lerp(0, 0.5f, 7f);
        }
    }
}
