using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light[] _myLights;
    public LightOverallController LightOverallController;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        _myLights = GetComponentsInChildren<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            foreach (Light l in _myLights)
            {
                if (l.enabled == false)
                {
                    l.enabled = true;
                    LightOverallController.LightEnabled ++;
                }
                
            }
        }
    }
}
