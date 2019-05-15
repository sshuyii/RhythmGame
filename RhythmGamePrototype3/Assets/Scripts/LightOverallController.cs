using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOverallController : MonoBehaviour
{
    public int LightEnabled = 0;

    public Light EnvironmentLight;

    public GameObject Yard;

    private Light[] yardLight;
    // Start is called before the first frame update
    void Start()
    {
        yardLight = Yard.GetComponentsInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LightEnabled == 13)
        {
            EnvironmentLight.intensity = Mathf.Lerp(0, 0.2f, 7f);

            foreach (Light l in yardLight)
            {
                if (l.enabled == false)
                {
                    l.enabled = true;
                }
            }


        }
    }
}
