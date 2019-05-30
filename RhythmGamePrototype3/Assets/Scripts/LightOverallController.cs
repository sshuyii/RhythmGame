using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOverallController : MonoBehaviour
{
    public int LightEnabled = 0;
    public bool lighted;
    public Light EnvironmentLight;

    public Light lightEX1;

    public Light lightEX2;
    // Start is called before the first frame update
    void Start()
    {
        //yardLight = Yard.GetComponentsInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (LightEnabled >= 16 && !lighted)
        {
            lighted = true;
            StartCoroutine(Lighting());

//            foreach (Light l in yardLight)
//            {
//                if (l.enabled == false)
//                {
//                    l.enabled = true;
//                }
//            }
        }
    }

    IEnumerator Lighting()
    {
        float timer = 0;

        while (timer < 1f)
        {
            EnvironmentLight.intensity = Mathf.Lerp(0, 0.5f, timer);
            lightEX1.intensity = Mathf.Lerp(0, 20, timer);
            lightEX2.intensity = Mathf.Lerp(0, 5, timer);
            timer += Time.deltaTime;
            yield return 0;
        }
    }
}
